using System.Diagnostics;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CV_Projekt.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly ILogger<UserProfileController> _logger;
        private CvContext _context;

        public UserProfileController(ILogger<UserProfileController> logger, CvContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult UserProfile()
        {
            return View();
        }

    }
}
