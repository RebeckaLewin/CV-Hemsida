using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography;

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

			if (project != null) 
			{
				project.Participants = project.Participants
					.Where(part => part.isActive &&
						(User.Identity.IsAuthenticated || !part.isPrivate))
					.ToList();
			}

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

            if (projects != null)
            {
				foreach (var project in projects)
				{
					project.Participants = project.Participants
						.Where(part => part.isActive &&
							(User.Identity.IsAuthenticated || !part.isPrivate))
						.ToList();
				}
            }

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

		[HttpGet]
		public IActionResult Add()
		{
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User loggedInUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel viewModel = new ProjectViewModel(context, loggedInId) { Users = context.Users.ToList(), ProjectToSave = newProject, Creator = loggedInUser }; 
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Add(ProjectViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				context.Add(viewModel.ProjectToSave);
				context.SaveChanges();
				return RedirectToAction("ShowProjectsView");
			}

			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User loggedInUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel newViewModel = new ProjectViewModel(context, loggedInId) { Users = context.Users.ToList(), ProjectToSave = newProject, Creator = loggedInUser };
			return View(newViewModel);
		}

		[HttpPost]
		public IActionResult AddParticipant(int pid) 
		{
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var currentUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();

            var project = context.Projects.
				Where(p => p.Id == pid)
				.FirstOrDefault();
			if (!project.Participants.Any(u => u.Id == currentUser.Id) && !project.CreatorId.Equals(currentUser.Id))
			{
				project.Participants.Add(currentUser);
				context.Projects.Update(project);
				context.SaveChanges();
			}

			return RedirectToAction("Project", new { id = pid } );
		}

		[HttpGet]
		public IActionResult Update(int id)
		{
			Project projectToEdit = context.Projects.Where(p => p.Id == id).FirstOrDefault();

			string loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			UpdateProjectViewModel viewModel = new UpdateProjectViewModel(context, loggedInId) { Project = projectToEdit };
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Update(UpdateProjectViewModel viewModel)
		{
			Project projectToUpdate = context.Projects.Where(p => p.Id == viewModel.Project.Id).FirstOrDefault();
			if (ModelState.IsValid)
			{
				projectToUpdate.Title = viewModel.Project.Title;
				projectToUpdate.Description = viewModel.Project.Description;
				projectToUpdate.StartDate = viewModel.Project.StartDate;
				projectToUpdate.EndDate = viewModel.Project.EndDate;

				context.Projects.Update(projectToUpdate);
				context.SaveChanges();
			}
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult RemoveParticipant(int pid, string uid, bool edit)
		{
			Project projectToRemoveFrom = context.Projects.Where(p => p.Id == pid).FirstOrDefault();
			User userToRemove = context.Users.Where(u => u.Id == uid).FirstOrDefault();

			projectToRemoveFrom.Participants.Remove(userToRemove);
			context.Update(projectToRemoveFrom);
			context.SaveChanges();
			if(edit)
			{
				return RedirectToAction("Update", new { id = pid });
			}
			else
			{
				return RedirectToAction("Project", new { id = pid });
			}

		}

		public IActionResult Delete(int id)
		{
			Project projectToDelete = context.Projects.Where(p => p.Id == id).FirstOrDefault();
			context.Projects.Remove(projectToDelete);
			context.SaveChanges();
			return RedirectToAction("ShowProjectsView", "Project");
		}
	}
}
