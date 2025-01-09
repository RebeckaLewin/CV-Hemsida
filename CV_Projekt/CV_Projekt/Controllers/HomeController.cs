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

            var random = new Random();

            var usersWithCvs = users
                .Where(u => u.isActive &&
                    cvs.Any(cv => cv.OwnerId == u.Id) &&
                    (User.Identity.IsAuthenticated || !u.isPrivate)
                    )
                .OrderBy(u => random.Next())
                .Take(4)
                .Distinct()
                .ToList();
            
            HomeViewModel cvvm = new HomeViewModel
            {
                Users = usersWithCvs,
                Projects = latestProject,
                Cvs = cvs,
                Experiences = experiences,              
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
