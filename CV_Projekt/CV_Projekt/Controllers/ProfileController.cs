using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CV_Projekt.Controllers
{
    public class ProfileController : Controller
    {
        private CvContext _context;

        public ProfileController(CvContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Profile(string id)
        {
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			ProfileViewModel viewModel = new ProfileViewModel(_context, loggedInId);
			viewModel.User = _context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
			viewModel.Projects = _context.Projects.ToList();
            viewModel.Tags = _context.Tags.ToList();
            return View(viewModel);
        }

        public IActionResult FindSimilarProfile(string id)
        {
            string suitableUserId = "";

            User user = _context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();

            return View("Profile", new { id = user.Id });
        }
	}
}
