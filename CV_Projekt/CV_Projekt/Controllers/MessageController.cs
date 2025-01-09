using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CV_Projekt.Controllers
{
    public class MessageController : Controller
    {
        private CvContext _context;
        private ILogger _logger;

        public MessageController(CvContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ChatList(string id)
        {
            
            var recMes = _context.Messages
                .Where(m => m.RecieverId.Equals(id))
                .Include(m => m.Sender)
                .OrderBy(m => m.Date)
                .ToList();
           
            var viewModel = new ChatListViewModel
            {
                _messages = recMes
            };
            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
