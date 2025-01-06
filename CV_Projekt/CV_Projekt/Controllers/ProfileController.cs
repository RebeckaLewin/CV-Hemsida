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
        public IActionResult Profile(int id)
        {
            var user = _context.Users.FirstOrDefault(u=> u.Id == id);
            if (user == null) 
            { 
                return NotFound();
            }
            
            var cvs = _context.CVs.Where(cv=>cv.OwnerId==id).ToList();

            var projCreator = _context.Projects.Where(p => p.CreatorId == id).ToList();
            
            var projColl = _context.Projects.Where(p => p.CVs.Any(cv => cv.OwnerId == id )).ToList();
            
            var tags = _context.Tags.Where(t => t.CVs.Any(cv => cv.OwnerId == id)).ToList();
            
            var exp = _context.Experiences.Where(e=>e.UserId==id).ToList();
            var skills = cvs.Where(cv => cv.Skills != null && cv.Skills.Any())
                .SelectMany(cv => cv.Skills)
                .Distinct()
                .ToList();

            ProfileViewModel pvm = new ProfileViewModel
            {
                Cvs = cvs,
                User = user,
                ProjectCollaborator = projColl,
                ProjectsCreated = projCreator,
                Tags = tags,
                Experiences = exp,
                Skills = skills
            };
            return View(pvm);
        }
    }
}
