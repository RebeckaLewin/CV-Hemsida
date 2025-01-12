using CV_Projekt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;

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
			LogInViewModel viewModel = new LogInViewModel();
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
					lockoutOnFailure: true
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
			RegisterViewModel viewModel = new RegisterViewModel();
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
					ContactInformation = contactInformation
				};
				Debug.WriteLine(viewModel.Password);
				var result = await userManager.CreateAsync(newUser, newUser.Password);
				if (result.Succeeded)
				{
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
			return View(new RegisterViewModel());
		}

		[HttpGet]
		public IActionResult Settings()
		{
			SettingsViewModel viewModel = new SettingsViewModel();
			try
			{
				viewModel.User = context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();
				if (viewModel.User == null)
				{
					throw new Exception(message: "Användare med den angivna eposten saknas.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

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

				string profileImageURL = "";

				if(viewModel.ImageFile != null)
				{
					string fileName = "profilepic_" + "test" + Path.GetExtension(viewModel.ImageFile.FileName).ToLower();
					string newFilePath = "..\\CV_Projekt\\wwwroot\\images\\" + fileName;

					using (FileStream fs = new FileStream(newFilePath, FileMode.Create))
					{
						viewModel.ImageFile.CopyTo(fs);
					}

					profileImageURL = "~/images/" + fileName;
				}

				User userToUpdate = context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();

				userToUpdate.FirstName = viewModel.User.FirstName;
				userToUpdate.LastName = viewModel.User.LastName;
				userToUpdate.UserName = viewModel.User.UserName;
				userToUpdate.Password = viewModel.User.Password;

				userToUpdate.isPrivate = viewModel.User.isPrivate;
				userToUpdate.isActive = viewModel.User.isActive;

				userToUpdate.ContactInformation.Address = viewModel.User.ContactInformation.Address;
				userToUpdate.ContactInformation.Phone = viewModel.User.ContactInformation.Phone;

				userToUpdate.PictureUrl = profileImageURL;

				context.Users.Update(userToUpdate);
				context.SaveChanges();

				viewModel.User = userToUpdate;

				RedirectToAction("UserProfile", "UserProfile", viewModel);
			}
			return View(viewModel);
		}
	}
}
