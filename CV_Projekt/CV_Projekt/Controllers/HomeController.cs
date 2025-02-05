using System.Diagnostics;
using System.Security.Claims;
using Azure.Identity;
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
        //metod f�r att fylla startsidan med information
        public IActionResult Index()
        {
            var cvs = _context.CVs.ToList();
            var users = _context.Users.ToList();
            var experiences = _context.Experiences.ToList();

            var latestProject = _context.Projects.OrderByDescending(p => p.Id)
                .FirstOrDefault();

            var random = new Random();
            //h�mtar de CVn som ska visas p� startsidan. Filtrerar bort inaktiva users och privata user om man �r utloggad
            var usersWithCvs = users
                .Where(u => u.isActive &&
                    cvs.Any(cv => cv.OwnerId == u.Id) &&
                    (User.Identity.IsAuthenticated || !u.isPrivate)
                    )
                .OrderBy(u => random.Next()) //randomiserar hela listan
                .Take(4) //v�ljer ut fyra cvn
                .Distinct()
                .ToList();

            User loggedInUser = new User();
			if (User.Identity.IsAuthenticated)
            {
				loggedInUser = _context.Users.Where(u => u.Id.Equals(User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
			}

            HomeViewModel viewModel = new HomeViewModel(_context, loggedInUser.Id)
            {
                Users = usersWithCvs,
                LatestProject = latestProject,
                Cvs = cvs,
                Experiences = experiences, 
                LoggedInUser = loggedInUser
            };
            return View(viewModel);
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
