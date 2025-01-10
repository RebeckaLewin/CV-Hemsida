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
                .Where(m => !m.isRead)
                .OrderByDescending(m => m.Date)
                .ToList();
           
            var viewModel = new ChatListViewModel
            {
                ReceivedMessages = recMes
            };

            ViewBag.Id = id;

            return View(viewModel);
        }


        [HttpGet]
        public IActionResult Add(string senderId, string recieverId)
        {
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

        [HttpGet]
        public IActionResult AllUserList()
        {
            var allUsers = _context.Users.ToList();

            var viewModel = new UserViewModel
            {
                _users = allUsers
            };



            return View(viewModel);
        }

        //[HttpGet]
        //public IActionResult SentChatList(string id)
        //{
        //    var sentMes = _context.Messages
        //        .Where(m => m.SenderId.Equals(id))
        //        .OrderByDescending(m => m.Date)
        //        .ToList();

        //    var mesSent = sentMes.DistinctBy(r => r.ReceiverId).ToList();

        //    var viewModel = new ChatListViewModel
        //    {
        //        RecievedMessages = mesSent
        //    };
        //    return View(viewModel);
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
