using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Profile(string aUserName)
        {
            ProfileViewModel viewModel = new ProfileViewModel();
            if (aUserName == null)
            {
                viewModel.User = _context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();
			}
            else
            {
				viewModel.User = _context.Users.Where(u => u.UserName.Equals(aUserName)).FirstOrDefault();
			}
			viewModel.Projects = _context.Projects.ToList();
            viewModel.Tags = _context.Tags.ToList();
            return View(viewModel);
        }
    }
}
