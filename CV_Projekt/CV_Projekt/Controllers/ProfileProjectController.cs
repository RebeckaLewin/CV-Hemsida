using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class ProfileProjectController : Controller
    {
        private CvContext _context;

        public ProfileProjectController (CvContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ProfileProject()
        {
            ProfileProjectViewModel ppvm = new ProfileProjectViewModel
            {

            };
            return View(ppvm);
        }
    }
}
