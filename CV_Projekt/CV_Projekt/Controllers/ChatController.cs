using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
