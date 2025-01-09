using CV_Projekt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
					FirstName = viewModel.FirstName,
					LastName = viewModel.LastName,
					PasswordHash = viewModel.Password,
					ContactInformation = contactInformation
				};
				Debug.WriteLine(viewModel.Password);
				var result = await userManager.CreateAsync(newUser, newUser.PasswordHash);
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
	}
}
