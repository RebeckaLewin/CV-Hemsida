using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

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
			return View();
		}
		public IActionResult ProjectView()
		{
			ProjectViewModel pvm = new ProjectViewModel { Users = context.Users.ToList(), Projects = context.Projects.ToList() };
			return View(pvm);
		}

		[HttpPost]
		public IActionResult ProjectView(ProjectViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				if(viewModel.IsUpdating)
				{
					context.Projects.Update(viewModel.ProjectToSave);
				}
				else
				{
					context.Add(viewModel.ProjectToSave);
				}
				context.SaveChanges();
			}
			ProjectViewModel pvm = new ProjectViewModel { Users = context.Users.ToList(), Projects = context.Projects.ToList() };
			return View(pvm);
		}
	}
}
