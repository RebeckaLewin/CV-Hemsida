using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Emils
        private CvContext cvContext;

        public HomeController(ILogger<HomeController> logger, CvContext context)
        {
            _logger = logger;
            cvContext = context;
        }

        //Emils test
        public IActionResult Test()
        {
            IQueryable<User> userList = from user in cvContext.Users select user;
            
            return View(userList.ToList());
        }
        public IActionResult Index()
        {
            var cvList = cvContext.CVs.ToList();
            return View();
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
