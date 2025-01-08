using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult SearchWindow()
        {
            return View();
        }
    }
}
