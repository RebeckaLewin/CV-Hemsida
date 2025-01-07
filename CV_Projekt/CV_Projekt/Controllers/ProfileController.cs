using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Profile(string id)
        {
            var user = _context.Users
                .Include(u => u.ContactInformation)
                .FirstOrDefault(u=> u.Id == id);
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

        [HttpGet]
        public IActionResult ViewCV(int id)
        {
            var cv = _context.CVs
                .Include(cv => cv.Owner)
                .ThenInclude(u => u.ContactInformation)
                .FirstOrDefault(cv => cv.Id == id);

            if(cv == null)
            {
                return NotFound();
            }

            var userCv = new UserCVViewModel
            {
                CV = cv,
                Owner = cv.Owner,
                Skills = cv.Skills ?? new List<string>(),
                Projects = _context.Projects
                .Where(p => p.CVs.Any(c => c.Id == id))
                .ToList(),
                Tags = _context.Tags
                .Where(t => t.CVs.Any(cv => cv.Id == id))
                .ToList()
            };
            return View(userCv);
        }

        //[HttpPost]
        //public IActionResult IncrementCvViews(string id)
        //{
        //    var user = _context.Users.FirstOrDefault(u => u.Id == id);
        //    var views = _context.CVs
        //    if (user != null)
        //    {
        //        user.Views++;
        //        _context.SaveChanges();
        //    }
        //}
    }
}
