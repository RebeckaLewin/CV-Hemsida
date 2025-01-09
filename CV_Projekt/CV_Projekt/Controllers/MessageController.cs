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
                .Where(m => m.ReceiverId.Equals(id))
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
                return RedirectToAction("Chat11", "Chat");
            }
            else
            {
                return RedirectToAction("Add", new { senderId = viewModel.Sender.Id, recieverId = viewModel.Receiver.Id });
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
