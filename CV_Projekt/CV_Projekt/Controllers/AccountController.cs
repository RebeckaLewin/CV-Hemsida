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

		public IActionResult LogIn()
		{
			return View();
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
				ContactInformation contactInformation = new ContactInformation
				{
					Email = viewModel.Email,
					Phone = viewModel.Phone,
					Address = viewModel.Address
				};
				context.ContactInformations.Add(contactInformation);
				context.SaveChanges();
				var contactId = context.ContactInformations.Max(info => info.Id);

				User newUser = new User
				{
					UserName = viewModel.UserName.Trim(),
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
	}
}
