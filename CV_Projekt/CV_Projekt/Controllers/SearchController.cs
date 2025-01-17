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
            //sätter upp en tom lista för att lagra users och tillhörande skills
            var usersWithSkills = new List<(User user, List<string> skills)>();
            //tom lista med users utan skills
            var users = new List<User>();
            //tom lista med CVs
            var cvs = new List<CV>();


            if(!string.IsNullOrEmpty(searchTerm))
            {
                //delar upp en sökterm i flera strängar
                var searchTerms = searchTerm.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //hämtar aktiva användare där någon del av namnet mathar någon del av söktermen
                users = context.Users
                .Where(u => u.isActive &&
                       searchTerms.Any(term =>
                           u.FirstName.ToLower().Contains(term) ||
                           u.LastName.ToLower().Contains(term)) &&
                       (User.Identity.IsAuthenticated || !u.isPrivate))
                .ToList();
                //hämtar CV där någon String Skill matchar söktermen
                //eagerLoadar även User Owner för varje CV som hittas
                cvs = context.CVs
                     .Where(cv => cv.Skills
                         .Any(skill => searchTerms.Any(term => skill.ToLower().Contains(term))))
                     .Include(cv => cv.Owner)
                     .ToList();
                //fyller usersWithSkills med värden ifrån tidigare LINQ 
                usersWithSkills = cvs
                    .Where(cv => cv.Owner != null && cv.Owner.isActive &&
                        (User.Identity.IsAuthenticated || !cv.Owner.isPrivate))
                    .Select(cv => (cv.Owner, cv.Skills
                        .Where(skill => searchTerms.Any(term => skill.ToLower().Contains(term)))
                        .ToList()))
                    .ToList();
                //Hämta users som som inte redan finns i den tidigare listan
                var usersNotInSkills = users
                    .Where(u => !usersWithSkills.Any(uws => uws.user.Id == u.Id))
                    .Select(u => (u, new List<string>()))
                    .ToList();
                //kombinerar båda tidigare linq-resultat för att hantera en utförlig sökning
                usersWithSkills.AddRange(usersNotInSkills);
                //skickar söktermen för att kunna visa den för användaren i fönstret
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
