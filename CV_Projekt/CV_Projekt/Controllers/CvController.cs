using System.Diagnostics;
using System.Security.Claims;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

            if (!user.Id.Equals(loggedInId))
            {
                cv.Views++;
                _context.SaveChanges();
            }

            var work = _context.Experiences
                .Where(e => e.CvId.Equals(cv.Id) && e is Work)
                .ToList();
            var educations = _context.Experiences
                .Where(e => e.CvId.Equals(cv.Id) && e is Education)
                .ToList();
            var other = _context.Experiences
                .Where(e => e.CvId.Equals(cv.Id) && e is OtherExperience)
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

        [HttpGet]
        public IActionResult Update(string id)
        {
            var cv = _context.CVs.Where(cv => cv.OwnerId == id)
                .FirstOrDefault();
            if (cv == null)
            {
                return NotFound();
            }

            List<Experience> workList = _context.Experiences.Where(e => e.CvId == cv.Id && e is Work).ToList();
            List<Experience> educationList = _context.Experiences.Where(e => e.CvId == cv.Id && e is Education).ToList();
            List<Experience> otherList = _context.Experiences.Where(e => e.CvId == cv.Id && e is OtherExperience).ToList();
            List<string> skillList = cv.Skills;

            UpdateCvViewModel viewModel = new UpdateCvViewModel(_context, cv.OwnerId) { CvId = cv.Id, Work = workList, Educations = educationList, Other = otherList, Skills = skillList };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddWork(UpdateCvViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(viewModel.WorkToAdd);
                _context.SaveChanges();
            }
            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("Update", "Cv", new { id = loggedInId });
        }

        [HttpPost]
        public IActionResult AddEducation(UpdateCvViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(viewModel.EducationToAdd);
                _context.SaveChanges();
            }
            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("Update", "Cv", new { id = loggedInId });
        }

        [HttpPost]
        public IActionResult AddOtherExperience(UpdateCvViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(viewModel.OtherToAdd);
                _context.SaveChanges();
            }
            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("Update", "Cv", new { id = loggedInId });
        }

        public IActionResult RemoveExperience(int id)
        {
            if (ModelState.IsValid)
            {
                Experience experienceToRemove = _context.Experiences.Where(e => e.Id == id).FirstOrDefault();
                _context.Experiences.Remove(experienceToRemove);
                _context.SaveChanges();
            }
            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("Update", "Cv", new { id = loggedInId });
        }

        public IActionResult AddSkill(UpdateCvViewModel viewModel)
        {
			if (ModelState.IsValid)
			{
                CV cvToUpdate = _context.CVs.Where(cv => cv.Id == viewModel.CvId).FirstOrDefault();
                cvToUpdate.Skills.Add(viewModel.SkillToAdd);
                _context.Update(cvToUpdate);
				_context.SaveChanges();
			}
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			return RedirectToAction("Update", "Cv", new { id = loggedInId });
		}

        public IActionResult RemoveSkill(int id, int index)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    CV cvToUpdate = _context.CVs.Where(cv => cv.Id == id).FirstOrDefault();
                    cvToUpdate.Skills.RemoveAt(index);
                    _context.Update(cvToUpdate);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
			}
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			return RedirectToAction("Update", "Cv", new { id = loggedInId });
		}
    }
}
