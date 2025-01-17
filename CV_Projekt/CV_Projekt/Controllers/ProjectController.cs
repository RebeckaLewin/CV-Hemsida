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
		//hämtar specifikt projekt
        public IActionResult Project(int id)
        {
            var project = context.Projects
				.Where(p => p.Id == id)
                .Include(p => p.Participants)
                .FirstOrDefault();
			//filtrerar bort inaktiva users och privata users om man är utloggad
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
		//hämtar alla projekt
        public IActionResult ShowProjectsView() 
		{
			var projects = context.Projects
				.Include(p => p.Participants)
				.ToList();

            if (projects != null)
            {
				foreach (var project in projects)
                {//filtrerar bort inaktiva users och privata users om man är utloggad
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
			//hämtar den inloggade usern
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User loggedInUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			//skapar ny viewmodel med nytt projekt och data hämtad från den inloggade usern
			ProjectViewModel viewModel = new ProjectViewModel(context, loggedInId) { Users = context.Users.ToList(), ProjectToSave = newProject, Creator = loggedInUser }; 
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Add(ProjectViewModel viewModel)
		{ //spara projekt i db om alla fält är godkända 
			if (ModelState.IsValid)
			{
				context.Add(viewModel.ProjectToSave);
				context.SaveChanges();
				return RedirectToAction("ShowProjectsView");
			}
			//återgå till formuläret med aktuell data vid valideringsfel
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			User loggedInUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
			Project newProject = new Project();
			newProject.Creator = loggedInUser;
			ProjectViewModel newViewModel = new ProjectViewModel(context, loggedInId) { Users = context.Users.ToList(), ProjectToSave = newProject, Creator = loggedInUser };
			return View(newViewModel);
		}

		[HttpPost]
		//lägg till sig själv som medarbetare i ett projekt 
		public IActionResult AddParticipant(int pid) 
		{
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var currentUser = context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();

            var project = context.Projects.
				Where(p => p.Id == pid)
				.FirstOrDefault();
			if (!project.Participants.Any(u => u.Id == currentUser.Id) && !project.CreatorId.Equals(currentUser.Id))
			{ //lägger till som medarbetare om man inte redan är det, eller om man står som projekt-skapare
				project.Participants.Add(currentUser);
				context.Projects.Update(project);
				context.SaveChanges();
			}

			return RedirectToAction("Project", new { id = pid } );
		}

		[HttpGet]
		//visar formulär för att editera ett projekt
		public IActionResult Update(int id)
		{
			Project projectToEdit = context.Projects.Where(p => p.Id == id).FirstOrDefault();
			//kollar vem som är inloggad
			string loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			UpdateProjectViewModel viewModel = new UpdateProjectViewModel(context, loggedInId) { Project = projectToEdit };
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Update(UpdateProjectViewModel viewModel)
		{//uppdaterar ett projekt med nya värden
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
		//tar bort en medarbetare från ett projekt
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
		{ //tar bort ett prjekt från databasen
			Project projectToDelete = context.Projects.Where(p => p.Id == id).FirstOrDefault();
			context.Projects.Remove(projectToDelete);
			context.SaveChanges();
			return RedirectToAction("ShowProjectsView", "Project");
		}
	}
}
