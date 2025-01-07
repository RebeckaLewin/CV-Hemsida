﻿using System.Diagnostics;
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
        //public IActionResult UserProfile(string id)
        //{
        //    var user = _context.Users.FirstOrDefault(u => u.Id == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    var cvs = _context.CVs.Where(cv => cv.OwnerId == id).ToList();

        //    var projCreator = _context.Projects.Where(p => p.CreatorId == id).ToList();

        //    var projColl = _context.Projects.Where(p => p.CVs.Any(cv => cv.OwnerId == id)).ToList();

        //    var tags = _context.Tags.Where(t => t.CVs.Any(cv => cv.OwnerId == id)).ToList();

        //    var exp = _context.Experiences.Where(e => e.UserId == id).ToList();
        //    var skills = cvs.Where(cv => cv.Skills != null && cv.Skills.Any())
        //        .SelectMany(cv => cv.Skills)
        //        .Distinct()
        //        .ToList();

        //    UserProfileViewModel upvm = new UserProfileViewModel
        //    {
        //        Cvs = cvs,
        //        User = user,
        //        ProjectCollaborator = projColl,
        //        ProjectsCreated = projCreator,
        //        Tags = tags,
        //        Experiences = exp,
        //        Skills = skills
        //    };
        //    return View(upvm);
        //}
    }
}