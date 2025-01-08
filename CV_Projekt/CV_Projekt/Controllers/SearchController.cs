using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class SearchController : Controller
    {
        private readonly CvContext _context;

    public SearchController(CvContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult SearchWindow(CvContext context)
        {
            
            return View();
        }
    }
}
