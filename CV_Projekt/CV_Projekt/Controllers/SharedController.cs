using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
	public class SharedController : Controller
	{
		[HttpGet]
		public IActionResult _Layout()
		{
			return View();
		}
	}
}
