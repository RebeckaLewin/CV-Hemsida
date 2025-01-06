using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CV_Projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CvContext _context;

        public HomeController(ILogger<HomeController> logger, CvContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cvs = _context.CVs.ToList();
            var users = _context.Users.ToList();
            var experiences = _context.Experiences.ToList();

            var latestProject = _context.Projects.OrderByDescending(p => p.Id)
                .Take(1)
                .ToList();
            
            var skills = cvs.Where(cv => cv.Skills !=null && cv.Skills.Any())
                .SelectMany(cv => cv.Skills)
                .Distinct()
                .ToList();

            var random = new Random();

            var usersWithCvs = users.Where(u => cvs.Any(cv => cv.OwnerId == u.Id))
                .OrderBy(u => random.Next())
                .Take(4)
                .Distinct()
                .ToList();
            
            CVViewModel cvvm = new CVViewModel
            {
                Users = usersWithCvs,
                Projects = latestProject,
                Cvs = cvs,
                Experiences = experiences,
                Skills = skills
                
            };
            return View(cvvm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
