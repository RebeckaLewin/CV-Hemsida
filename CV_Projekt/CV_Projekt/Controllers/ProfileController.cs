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
        public IActionResult Profile(string id)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Id == id);
                    

            var cvs = _context.CVs.Where(cv => cv.OwnerId == id);

            var projCreated = _context.Projects
                .Where(p => p.CreatorId == id)
                .ToList();
            var projColl = _context.Projects
                .Where(p => p.Participants.Any(u => u.Id == user.Id))
                .ToList();
            var exp = _context.Experiences
                .Where(e => e.UserId == id)
                .ToList();
            
            var pvm = new ProfileViewModel
            {
                User = user,
                ProjectParticipant = projColl,
                ProjectCreator = projCreated,
                Experience = exp
            };
            return View(pvm);
        }
    }
}
