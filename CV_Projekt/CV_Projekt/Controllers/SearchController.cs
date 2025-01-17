using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CV_Projekt.Controllers
{
    public class SearchController : Controller
    {
        private readonly CvContext context;

    public SearchController(CvContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult SearchWindow(string searchTerm)
        {
            var usersWithSkills = new List<(User user, List<string> skills)>();
            
            var users = new List<User>();

            var cvs = new List<CV>();


            if(!string.IsNullOrEmpty(searchTerm))
            {
                var searchTerms = searchTerm.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                users = context.Users
                .Where(u => u.isActive &&
                       searchTerms.Any(term =>
                           u.FirstName.ToLower().Contains(term) ||
                           u.LastName.ToLower().Contains(term)) &&
                       (User.Identity.IsAuthenticated || !u.isPrivate))
                .ToList();

                //users = context.Users
                //    .Where(u => u.isActive &&
                //        searchTerms.Any(term => 
                //        u.FirstName.ToLower().Contains(term) ||
                //        u.LastName.ToLower().Contains(term)) &&
                //        (User.Identity.IsAuthenticated || !u.isPrivate)))
                //    .ToList();

                cvs = context.CVs
                     .Where(cv => cv.Skills
                         .Any(skill => searchTerms.Any(term => skill.ToLower().Contains(term))))
                     .Include(cv => cv.Owner)
                     .ToList();

                usersWithSkills = cvs
                    .Where(cv => cv.Owner != null && cv.Owner.isActive &&
                        (User.Identity.IsAuthenticated || !cv.Owner.isPrivate))
                    .Select(cv => (cv.Owner, cv.Skills
                        .Where(skill => searchTerms.Any(term => skill.ToLower().Contains(term)))
                        .ToList()))
                    .ToList();
                        
                        
                    //    skill.ToLower().Contains(searchTerm.ToLower()))
                    //    .ToList()))
                    //.ToList();

                var usersNotInSkills = users
                    .Where(u => !usersWithSkills.Any(uws => uws.user.Id == u.Id))
                    .Select(u => (u, new List<string>()))
                    .ToList();

                usersWithSkills.AddRange(usersNotInSkills);

                ViewData["SearchedName"] = searchTerm;
            }

            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var svm = new SearchViewModel(context, loggedInId)
            {
                UsersWithSkills = usersWithSkills,
            };
            return View(svm);
        }
    }
}
