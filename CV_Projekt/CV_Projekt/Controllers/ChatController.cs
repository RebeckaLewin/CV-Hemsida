using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class ChatController : Controller
    {
        private CvContext _context
        private ILogger _logger

        public ChatController(CvContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Chat11(string senderId, string receiverId)
        {
            //var messages = _context.Messages
            //    .Where(m => (m.SenderId.Equals(senderId) && m.RecieverId.Equals(receiverId)) ||
            //                (m.SenderId.Equals(receiverId) && m.RecieverId.Equals(senderId)))
            //                .OrderBy(m => m.Date)
            //                .Take(5)
            //                .ToList();

            var message = _context.Messages
                .Where(m => m.RecieverId.Equals(receiverId) && m.SenderId.Equals(senderId))
                .OrderBy(m => m.Date)
                .FirstOrDefault();

            ViewBag.SenderId = senderId;
            ViewBag.ReceiverId = receiverId;

            return View(message);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
