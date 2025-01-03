using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Emils
        private CvContext context;

        public HomeController(ILogger<HomeController> logger, CvContext context)
        {
            _logger = logger;
            this.context = context;
        }

        //Emils test
        public IActionResult Test()
        {
            IQueryable<User> userList = from user in context.Users select user;
            
            return View(userList.ToList());
        }

        [HttpGet]
        //public IActionResult CVView()
        //{
        //    CVViewModel cvvm = new CVViewModel
        //    {
        //        Users = context.Users.ToList(),
        //        Projects = context.Projects.ToList(),
        //        Cvs = context.CVs.ToList(),
        //        Experiences = context.Experiences.ToList(),
        //        Tags = context.Tags.ToList(),

        //    };
        //    return View(cvvm);
        //}
        public IActionResult Index()
        {
            CVViewModel cvvm = new CVViewModel
            {
                Users = context.Users.ToList(),
                Projects = context.Projects.ToList(),
                Cvs = context.CVs.ToList(),
                Experiences = context.Experiences.ToList(),
                Tags = context.Tags.ToList(),

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
