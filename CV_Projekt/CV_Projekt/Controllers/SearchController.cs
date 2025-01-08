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
        public IActionResult SearchWindow(string searchTerm)
        {
            var users = new List<User>();

            if(!string.IsNullOrEmpty(searchTerm))
            {
                users = _context.Users
                    .Where(u => u.FirstName.ToLower().Contains(searchTerm.ToLower()) || u.LastName.ToLower().Contains(searchTerm.ToLower()))
                    .ToList();

                ViewData["SearchedName"] = searchTerm;
            }
            var svm = new SearchViewModel
            {
                Users = users
            };
            return View(svm);
        }
    }
}
