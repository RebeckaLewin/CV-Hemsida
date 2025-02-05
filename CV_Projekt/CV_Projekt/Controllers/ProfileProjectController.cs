﻿using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CV_Projekt.Controllers
{
    public class ProfileProjectController : Controller
    {
        private CvContext _context;

        public ProfileProjectController (CvContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ProfileProject(string id)
        {
            var user = _context.Users
                .Where(u => u.Id == id)
                .FirstOrDefault();
            if (user == null) 
            {
                return NotFound();
            }
            
            var projCreated = _context.Projects
                .Where(p => p.CreatorId == id)
                .ToList();

            var projPart = _context.Projects
                .Where(p => p.Participants.
                Any(u => u.Id == id))
                .ToList();

			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			ProfileProjectViewModel ppvm = new ProfileProjectViewModel(_context, loggedInId)
            {
                User = user,
                ProjectParticipant = projPart,
                CreatedProjects = projCreated
            };
            return View(ppvm);
        }
    }
}
