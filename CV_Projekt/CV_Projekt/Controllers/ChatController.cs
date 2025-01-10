using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projekt.Controllers
{
    public class ChatController : Controller
    {
        private CvContext _context;

        public ChatController(CvContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Chat11(string senderId, string receiverId)
        {

            var recMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(receiverId) && m.SenderId.Equals(senderId))
                .OrderBy(m => m.Date)
                .ToList();
            var sentMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(receiverId) && m.SenderId.Equals(senderId))
                .OrderBy(m => m.Date)
                .ToList();
            var firstName = _context.Users.Where(u => u.Id.Equals(senderId)).Select(u => u.FirstName).FirstOrDefault();
            var lastName = _context.Users.Where(u => u.Id.Equals(senderId)).Select(u => u.LastName).FirstOrDefault();
            var fullName = firstName + lastName;

            ViewBag.FullName = fullName;
            ViewBag.SenderId = senderId;
            ViewBag.ReceiverId = receiverId;

            var viewModel = new ChatListViewModel
            {
                ReceivedMessages = recMes,
                SentMessages = sentMes
            };

            return View(viewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
