using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class CVController : Controller
    {
        private CvContext context;

        public CVController (CvContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult CVView()
        {
            CVViewModel cvvm = new CVViewModel { 
                Users = context.Users.ToList(),
                Projects = context.Projects.ToList(),
                Cvs = context.CVs.ToList(),
                Experiences = context.Experiences.ToList(),
                Tags = context.Tags.ToList(),
                
            };
            return View(cvvm);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
