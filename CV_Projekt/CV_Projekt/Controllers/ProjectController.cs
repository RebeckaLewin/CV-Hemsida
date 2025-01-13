using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CV_Projekt.Controllers
{
	public class ProjectController : Controller
	{
		private CvContext context;

		public ProjectController(CvContext context)
		{
			this.context = context;
		}

		[HttpGet]
        public IActionResult Project(int id)
        {
            var project = context.Projects
				.Where(p => p.Id == id)
                .Include(p => p.Participants)
                .FirstOrDefault();

            var projCreator = context.Users
                .Where(u => u.Id == project.CreatorId)
                .FirstOrDefault();

			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			var proj = new ProjectViewModel(context, loggedInId)
            {
                Project = project,
                Creator = projCreator
            };
            return View(proj);
        }
        public IActionResult ShowProjectsView() 
		{
			var projects = context.Projects
				.Include(p => p.Participants)
				.ToList();

			var projCreator = context.Users
				.Where(u => projects.Select(p => p.CreatorId)
				.Contains(u.Id))
				.ToList();

			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			var proj = new ProjectViewModel(context, loggedInId)
			{
				Projects = projects,
				Creators = projCreator
			};
			return View(proj);
		}
		public IActionResult Add()
		{
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User loggedInUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel viewModel = new ProjectViewModel(context, loggedInId) { Users = context.Users.ToList(), ProjectToSave = newProject };
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Add(ProjectViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				context.Add(viewModel.ProjectToSave);
				context.SaveChanges();
			}
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User loggedInUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel newViewModel = new ProjectViewModel(context, loggedInId) { Users = context.Users.ToList(), ProjectToSave = newProject };
			return View(newViewModel);
		}

		[HttpPost]
		public IActionResult AddParticipant(int projectId) 
		{
			var currentUser = context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();


            var project = context.Projects.
				Where(p => p.Id == projectId)
				.Include(p => p.Participants)
				.FirstOrDefault();
			if (!project.Participants.Any(u => u.Id == currentUser.Id) && project.CreatorId != currentUser.Id)
			{
				project.Participants.Add(currentUser);
				context.SaveChanges();
			}

			return RedirectToAction("Project", new {id = projectId});
		}
	}
}
