using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

		public IActionResult ShowProjectsView() 
		{
			var projects = context.Projects
				.Include(p => p.Participants)
				.ToList();

			var projCreator = context.Users
				.Where(u => projects.Select(p => p.CreatorId)
				.Contains(u.Id))
				.ToList();

			var proj = new ProjectViewModel()
			{
				Projects = projects,
				Creator = projCreator
			};
			return View(proj);
		}
		public IActionResult Add()
		{
			User loggedInUser = context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel viewModel = new ProjectViewModel { Users = context.Users.ToList(), ProjectToSave = newProject };
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
			User loggedInUser = context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel newViewModel = new ProjectViewModel { Users = context.Users.ToList(), ProjectToSave = newProject };
			return View(newViewModel);
		}
	}
}
