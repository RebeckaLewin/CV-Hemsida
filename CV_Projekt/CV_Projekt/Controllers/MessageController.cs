using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace CV_Projekt.Controllers
{
    public class MessageController : Controller
    {
        private CvContext _context;

        public MessageController(CvContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ChatList(string id)
        {
            
            var recMes = _context.Messages
                .Where(m => m.RecieverId.Equals(id))
                .Include(m => m.Sender)
                .OrderBy(m => m.Date)
                .ToList();

            var mesRec = recMes.DistinctBy(r => r.SenderId).ToList();
           
            var viewModel = new ChatListViewModel
            {
                _messages = mesRec
            };
            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
