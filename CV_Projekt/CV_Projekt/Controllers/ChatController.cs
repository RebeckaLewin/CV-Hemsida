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

            var sentMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(senderId) && m.SenderId.Equals(receiverId))
                .OrderBy(m => m.Date)
                .ToList();
            var recMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(receiverId) && m.SenderId.Equals(senderId))
                .OrderBy(m => m.Date)
                .ToList();

            var firstName = _context.Users.Where(u => u.Id.Equals(senderId)).Select(u => u.FirstName).FirstOrDefault();
            var lastName = _context.Users.Where(u => u.Id.Equals(senderId)).Select(u => u.LastName).FirstOrDefault();
            var fullName = firstName + " " + lastName;

            var sentUser = _context.Users.Where(u => u.Id.Equals(senderId)).FirstOrDefault();
            var recUser = _context.Users.Where(u => u.Id.Equals(receiverId)).FirstOrDefault();

            ViewBag.FullName = fullName;

            var viewModel = new ChatListViewModel
            {
                ReceivedMessages = recMes,
                SentMessages = sentMes,
                Sender = sentUser,
                Receiver = recUser
            };

            return View(viewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
