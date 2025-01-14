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
        public IActionResult Chat11(string otherId)
        {
            string loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var allMessages = _context.Messages
                .Where(m => (m.ReceiverId.Equals(loggedInId) && m.SenderId.Equals(otherId) ||
				             m.ReceiverId.Equals(otherId) && m.SenderId.Equals(loggedInId)))
                .OrderBy(m => m.Date)
                .ToList();

            foreach (var message in allMessages)
            {
                if(message.ReceiverId.Equals(loggedInId))
                {
                    TurnRead(message);
                }
            }

            allMessages = allMessages.Where(m => (m.ReceiverId.Equals(loggedInId) && m.ReceiverDelete == false) ||
                                                 (m.SenderId.Equals(loggedInId) && m.SenderDelete == false)
                                            ).ToList();

            var loggedInUser = _context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();
            var otherUser = _context.Users.Where(u => u.Id.Equals(otherId)).FirstOrDefault();

            var viewModel = new Chat11ViewModel(_context, loggedInId)
            {
                AllMessages = allMessages,
                LoggedInUser = loggedInUser,
                OtherUser = otherUser
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult RemoveMessage(int mid, string oid)
        {
            Message message = _context.Messages.Where(m => m.Id.Equals(mid)).FirstOrDefault();
            if (message.SenderId.Equals(User.FindFirstValue(ClaimTypes.NameIdentifier)))
            {
                message.SenderDelete = true;
            }
            else
            {
                message.ReceiverDelete = true;
            }
            _context.Messages.Update(message);
            _context.SaveChanges();
            return RedirectToAction("Chat11", new { otherId = oid });
        }

        public void TurnRead(Message aMessage)
        {
			if (!aMessage.isRead)
			{
				aMessage.isRead = true;
				_context.Messages.Update(aMessage);
				_context.SaveChanges();
			}
		}

        public IActionResult Index()
        {
            return View();
        }
    }
}
