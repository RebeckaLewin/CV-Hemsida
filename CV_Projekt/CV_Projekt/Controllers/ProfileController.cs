using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CV_Projekt.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private CvContext _context;

        public ProfileController(ILogger<ProfileController> logger, CvContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Profile()
        {
            var users = _context.Users.ToList();
            var cvs = _context.CVs.ToList();
            var msg = _context.Messages.ToList();
            var proj = _context.Projects.ToList();
            var tags = _context.Tags.ToList();
            var exp = _context.Experiences.ToList();
            var skills = cvs.Where(cv => cv.Skills != null && cv.Skills.Any())
                .SelectMany(cv => cv.Skills)
                .Distinct()
                .ToList();
            
            return View();
        }
    }
}
