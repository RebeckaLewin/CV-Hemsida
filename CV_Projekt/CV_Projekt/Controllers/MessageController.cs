using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
