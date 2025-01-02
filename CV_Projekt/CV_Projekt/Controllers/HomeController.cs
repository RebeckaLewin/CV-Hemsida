using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Emils
        private CvContext cvs;

        public HomeController(ILogger<HomeController> logger, CvContext service)
        {
            _logger = logger;
            cvs = service;
        }

        //Emils test
        public IActionResult Test()
        {
            IQueryable<User> userList = from user in cvs.Users select user;
            
            return View(userList.ToList());
        }
        public IActionResult Index()
        {
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
