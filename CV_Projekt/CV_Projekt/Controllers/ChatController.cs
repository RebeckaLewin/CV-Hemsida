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
        //borde ha hetat chatOneOnOne
        public IActionResult Chat11(string otherId) 
        { 
            string loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //hämtar och visar alla meddelanden som har skickats mellan inloggad user och en annan user
            var allMessages = _context.Messages
                .Where(m => (m.ReceiverId.Equals(loggedInId) && m.SenderId.Equals(otherId) ||
				             m.ReceiverId.Equals(otherId) && m.SenderId.Equals(loggedInId)))
                .OrderBy(m => m.Date)
                .ToList();
            // markerar mottagna meddelanden som lästa om mottagaren är den inloggade usern
            foreach (var message in allMessages)
            {
                if(message.ReceiverId.Equals(loggedInId))
                {
                    TurnRead(message);
                }
            }
            // filtrerar bort meddelanden som har markerats som borttagna av antingen mottagaren eller avsändaren
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
            // kontrollerar om den inloggade usern är avsändare eller mottagare.
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

        public void TurnRead(Message aMessage) //markerar ett meddelande som läst
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
