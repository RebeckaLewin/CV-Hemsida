using CV_Projekt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography;
using System;

namespace CV_Projekt.Controllers
{
	public class AccountController : Controller
	{
		private UserManager<User> userManager;
		private SignInManager<User> signInManager;
		private CvContext context;

		public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, CvContext context)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.context = context;
		}

		[HttpGet]
		public IActionResult LogIn()
		{
			LogInViewModel viewModel = new LogInViewModel(context, null);
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> LogIn(LogInViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				var result = await signInManager.PasswordSignInAsync(
					viewModel.UserName,
					viewModel.Password,
					isPersistent: viewModel.RememberMe,
					lockoutOnFailure: false
					);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Fel användarnamn eller lösenord.");
				}
			}
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> LogOut()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult Register()
		{
			RegisterViewModel viewModel = new RegisterViewModel(context, null);
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				if (!viewModel.ConfirmedPassword.Equals(viewModel.Password))
				{
					ModelState.AddModelError("", "De angivna lösenorden matchar inte.");
					return View(viewModel);
				}

				ContactInformation contactInformation = new ContactInformation
				{
					Phone = viewModel.Phone,
					Address = viewModel.Address
				};
				context.ContactInformations.Add(contactInformation);
				context.SaveChanges();
				var contactId = context.ContactInformations.Max(info => info.Id);

				User newUser = new User
				{
					UserName = viewModel.Email.Trim(),
					Email = viewModel.Email.Trim(),
					FirstName = viewModel.FirstName,
					LastName = viewModel.LastName,
					Password = viewModel.Password,
					ContactInformation = contactInformation,
					PictureUrl = "~/images/profilepic_default.jpg",
					isActive = true,
					isPrivate = viewModel.IsPrivate
				};
				var result = await userManager.CreateAsync(newUser, newUser.Password);
				if (result.Succeeded)
				{
					CV newCV = new CV { Owner = newUser };
					context.CVs.Add(newCV);
					context.SaveChanges();

					await signInManager.SignInAsync(newUser, isPersistent: true);
					return RedirectToAction("Index", "Home");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}
			return View(new RegisterViewModel(context, null));
		}

		[HttpGet]
		public IActionResult Settings()
		{
			var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
			SettingsViewModel viewModel = new SettingsViewModel(context, id);
			try
			{
				viewModel.User = context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
				if (viewModel.User == null)
				{
					throw new Exception(message: "Användare med den angivna eposten saknas.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			viewModel.Tags = context.Tags.ToList();
			List<SelectListItem> tags = context.Tags.Select
				(x => new SelectListItem { Text = x.Descriptor, Value = x.Id.ToString() }).ToList();
			ViewBag.options = tags;

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Settings(SettingsViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				if (!viewModel.User.Password.Equals(viewModel.ConfirmedPassword))
				{
					ModelState.AddModelError("", "De angivna lösenorden matchar inte.");
					return View(viewModel);
				}

				var id = User.FindFirstValue(ClaimTypes.NameIdentifier);

				string profileImageURL = "";

				if(viewModel.ImageFile != null)
				{
					string fileName = "profilepic_" + id + Path.GetExtension(viewModel.ImageFile.FileName).ToLower();
					string newFilePath = "..\\CV_Projekt\\wwwroot\\images\\" + fileName;

					using (FileStream fs = new FileStream(newFilePath, FileMode.Create))
					{
						viewModel.ImageFile.CopyTo(fs);
					}

					profileImageURL = "~/images/" + fileName;
				}

				User userToUpdate = context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();

				userToUpdate.FirstName = viewModel.User.FirstName;
				userToUpdate.LastName = viewModel.User.LastName;
				userToUpdate.UserName = viewModel.User.UserName;
				userToUpdate.Password = viewModel.User.Password;

				userToUpdate.isPrivate = viewModel.User.isPrivate;
				userToUpdate.isActive = viewModel.User.isActive;

				userToUpdate.ContactInformation.Address = viewModel.User.ContactInformation.Address;
				userToUpdate.ContactInformation.Phone = viewModel.User.ContactInformation.Phone;

				if(!profileImageURL.Equals(string.Empty))
				{
					userToUpdate.PictureUrl = profileImageURL;
				}

				context.Users.Update(userToUpdate);
				context.SaveChanges();

				viewModel.User = userToUpdate;

				return RedirectToAction("Profile", "Profile", new { id = userToUpdate.Id });
			}
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult SetDisabled(SettingsViewModel viewModel)
		{
			viewModel.User.isActive = !viewModel.User.isActive;

			string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User userToUpdate = context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();

			userToUpdate.isActive = viewModel.User.isActive;
			context.Update(userToUpdate);
			context.SaveChanges();

			return RedirectToAction("Settings", viewModel);
		}

		[HttpPost]
		public IActionResult AddTag(SettingsViewModel viewModel)
		{
			if(viewModel.TagId != null && viewModel.User.Id != null)
			{
				User user = context.Users.Where(u => u.Id.Equals(viewModel.User.Id)).FirstOrDefault();
				Tag tag = context.Tags.Where(t => t.Id.ToString() == viewModel.TagId).FirstOrDefault();

				user.Tags.Add(tag);
				context.Users.Update(user);
				context.SaveChanges();
			}
			return RedirectToAction("Settings", "Account");
		}

		[HttpPost]
		public IActionResult RemoveTag(SettingsViewModel viewModel)
		{
			if (viewModel.TagId != null && viewModel.User.Id != null)
			{
				User user = context.Users.Where(u => u.Id.Equals(viewModel.User.Id)).FirstOrDefault();
				Tag tag = context.Tags.Where(t => t.Id.ToString() == viewModel.TagId).FirstOrDefault();

				user.Tags.Remove(tag);
				context.Users.Update(user);
				context.SaveChanges();
			}
			return RedirectToAction("Settings");
		}
	}
}
