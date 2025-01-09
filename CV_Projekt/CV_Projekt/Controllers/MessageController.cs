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
            var receivedMessages = _context.Messages
                .Where(m => m.ReceiverId.Equals(id))
                .OrderByDescending(m => m.Date)
                .ToList();
            var sentMessages = _context.Messages
                .Where(m => m.SenderId.Equals(id))
                .OrderByDescending(m => m.Date)
                .ToList();

            //var mesRec = recMes.DistinctBy(r => r.SenderId).ToList();
           
            var viewModel = new ChatListViewModel
            {
                RecievedMessages = receivedMessages,   
                SentMessages = sentMessages,
            };
            return View(viewModel);
        }


        [HttpGet]
        public IActionResult Add(string senderId, string recieverId)
        {
            Console.WriteLine(recieverId);
            Message message = new Message();
            var sender = _context.Users.Where(u => u.Id.Equals(senderId)).FirstOrDefault();
            var reciever = _context.Users.Where(u => u.Id.Equals(recieverId)).FirstOrDefault();


            MessageViewModel viewModel = new MessageViewModel { Message = message, Sender = sender, Receiver = reciever };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(MessageViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewModel.Message);
                _context.SaveChanges();
                return RedirectToAction("Chat11", "Chat", new { senderId = viewModel.Message.SenderId, receiverId = viewModel.Message.ReceiverId } );
            }
            else
            {
                Console.WriteLine(ModelState.ErrorCount.ToString());
                return RedirectToAction("Add", new { senderId = viewModel.Message.SenderId, recieverId = viewModel.Message.ReceiverId });
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
