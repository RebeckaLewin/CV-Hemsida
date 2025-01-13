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
        public IActionResult CV(int id)
        {
            var cv = _context.CVs.Where(cv => cv.Id == id)
                .FirstOrDefault();
            if (cv == null)
            {
                return NotFound();
            }

            cv.Views++;
            _context.SaveChanges();

            var user = _context.Users.Where(u => u.Id == cv.OwnerId)
                .FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            var work = _context.Experiences
                .Where(e => e.UserId.Equals(user.Id) && e is Work)
                .ToList();
            var educations = _context.Experiences
                .Where(e => e.UserId.Equals(user.Id) && e is Education)
                .ToList();
            var other = _context.Experiences
                .Where(e => e.UserId.Equals(user.Id) && e is OtherExperience)
                .ToList();

            var userCv = new CvViewModel
            {
                CV = cv,
                Owner = user,
                Skills = cv.Skills ?? new List<string>(),
                Work = work,
                Educations = educations,
                OtherExperiences = other,
            };
            return View(userCv);
        }
    }
}
