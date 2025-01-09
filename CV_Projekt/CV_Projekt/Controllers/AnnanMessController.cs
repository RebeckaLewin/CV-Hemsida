using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CV_Projekt.Controllers
{
	public class AnnanMessController : Controller
	{
		private CvContext _context;

		public AnnanMessController(CvContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult AllUserList()
		{
			var allUsers = _context.Users.ToList();

            var viewModel = new UserViewModel
            {
                _users = allUsers
            };
            return View();
		}

		[HttpGet]
		public IActionResult NewAdd()
		{

		}



		public IActionResult Index()
		{
			return View();
		}
	}
}
