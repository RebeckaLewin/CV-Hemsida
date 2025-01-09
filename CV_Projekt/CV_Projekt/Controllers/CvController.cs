using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CV_Projekt.Controllers
{
    public class CvController : Controller
    {
        private readonly ILogger<CvController> _logger;
        private CvContext _context;

        public CvController(ILogger<CvController> logger, CvContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]

        public IActionResult CV()
        {
            return View();
        }
        public IActionResult Cv(int id)
        {

            var cv = _context.CVs
                .Include(cv => cv.Owner)
                .ThenInclude(u => u.ContactInformation)
                .FirstOrDefault(cv => cv.Id == id);
            if (cv == null)
            {
                return NotFound();
            }

            var user = _context.Users
                    .Include(u => u.ContactInformation)
                    .FirstOrDefault(u => u.Id == cv.OwnerId);
            if (user == null)
            {
                return NotFound();
            }

            var cvs = _context.CVs.Where(cv => cv.OwnerId == user.Id).ToList();

            var projCreated = _context.Projects
                .Where(p => p.CreatorId == cv.OwnerId)
                .ToList();
            var projColl = _context.Projects
                .Where(p => p.CVs.Any(c => c.Id == id))
                .ToList();
            var exp = _context.Experiences
                .Where(e => e.UserId == cv.OwnerId)
                .ToList();

            var userCv = new CvViewModel
            {
                CV = cv,
                Cvs = cvs,
                Owner = cv.Owner,
                User = cv.Owner,
                Skills = cv.Skills ?? new List<string>(),
                ProjectsCreated = projCreated,
                ProjectCollaborator = projColl,
                Experiences = exp
            };
            return View(userCv);
        }

        [HttpPost]
        public IActionResult IncrementCvViews(int id)
        {
            var cv = _context.CVs.FirstOrDefault(c => c.Id == id);
            var views = _context.CVs;
            if (cv != null)
            {
                cv.Views++;
                _context.SaveChanges();
            }
            return RedirectToAction("Cv", new {id});
        }
    }
}
