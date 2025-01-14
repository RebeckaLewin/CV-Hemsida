using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

            var allRecMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(receiverId) && m.SenderId.Equals(senderId))
                .OrderBy(m => m.Date)
                .ToList();
            var allSentMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(receiverId) && m.SenderId.Equals(senderId))
                .OrderBy(m => m.Date)
                .ToList();
            var delRecMes = allRecMes.Where(r => r.ReceiverDelete.Equals(true)).ToList();
            var delSentMes = allSentMes.Where(s => s.SenderDelete.Equals(true)).ToList();
            var recMes = allRecMes.Except(delRecMes).ToList();
            var sentMes = allSentMes.Except(delSentMes).ToList();

            foreach (var message in recMes)
            {
                message.isRead = true;
                _context.Messages.Update(message);
                _context.SaveChanges();
            }

            var firstName = _context.Users.Where(u => u.Id.Equals(senderId)).Select(u => u.FirstName).FirstOrDefault();
            var lastName = _context.Users.Where(u => u.Id.Equals(senderId)).Select(u => u.LastName).FirstOrDefault();
            var fullName = firstName + " " + lastName;

            var sentUser = _context.Users.Where(u => u.Id.Equals(senderId)).FirstOrDefault();
            var recUser = _context.Users.Where(u => u.Id.Equals(receiverId)).FirstOrDefault();

            ViewBag.FullName = fullName;

            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var viewModel = new ChatListViewModel(_context, id)
            {
                ReceivedMessages = recMes,
                SentMessages = sentMes,
                Sender = sentUser,
                Receiver = recUser
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult RemoveMessage(int messageId, ChatListViewModel viewModel)
        {
            var message = _context.Messages.Where(m => m.Id.Equals(messageId)).FirstOrDefault();
            if (message.SenderId.Equals(User.FindFirstValue(ClaimTypes.NameIdentifier)))
            {
                message.SenderDelete = true;
            }
            if (message.ReceiverId.Equals(User.FindFirstValue(ClaimTypes.NameIdentifier)))
            {
                message.ReceiverDelete = true;
            }
            _context.Messages.Update(message);
            _context.SaveChanges();
            return RedirectToAction("Chat11", viewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
