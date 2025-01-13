using System.Diagnostics;
using System.Security.Claims;
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
        public IActionResult Inspect(string id)
        {
			var user = _context.Users.Where(u => u.Id.Equals(id))
	                   .FirstOrDefault();
			if (user == null)
			{
				return NotFound();
			}

			var cv = _context.CVs.Where(cv => cv.Owner == user)
                .FirstOrDefault();
            if (cv == null)
            {
                return NotFound();
            }

            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(!user.Id.Equals(loggedInId))
            {
				cv.Views++;
				_context.SaveChanges();
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

            var viewModel = new CvViewModel(_context, loggedInId)
            {
                CV = cv,
                Owner = user,
                Skills = cv.Skills ?? new List<string>(),
                Work = work,
                Educations = educations,
                OtherExperiences = other,
                Projects = _context.Projects.ToList()
            };

            return View(viewModel);
        }
    }
}
