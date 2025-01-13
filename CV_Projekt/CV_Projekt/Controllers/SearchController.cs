using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
                    .Where(u => u.FirstName.ToLower().Contains(searchTerm.ToLower()) || u.LastName.ToLower().Contains(searchTerm.ToLower())
                     && (User.Identity.IsAuthenticated || !u.isPrivate) && u.isActive)
                    .ToList();

                ViewData["SearchedName"] = searchTerm;
            }
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var svm = new SearchViewModel(_context, loggedInId)
            {
                Users = users
            };
            return View(svm);
        }
    }
}
