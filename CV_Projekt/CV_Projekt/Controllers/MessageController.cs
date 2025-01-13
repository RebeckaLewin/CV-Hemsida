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
        public IActionResult ChatList()
        {

            var identity = _context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();
            var id = identity.Id;
            ViewBag.Id = id;

            var recMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(id))
                .Where(m => m.isRead.Equals(false))
                .OrderByDescending(m => m.Date)
                .ToList();
           
            var viewModel = new ChatListViewModel
            {
                ReceivedMessages = recMes
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChatList(ChatListViewModel viewModel)
        {
            var mess = _context.Messages.Where(m => m.Id.Equals(viewModel.Message.Id)).FirstOrDefault();
            
            if (ModelState.IsValid)
            {
                mess.isRead = viewModel.Message.isRead;
                _context.Update(mess);
                _context.SaveChanges();
                return RedirectToAction("Chat11", "Chat", new { senderId = viewModel.Message.ReceiverId, receiverId = viewModel.Message.SenderId });
            }
            else
            {
                Console.WriteLine(ModelState.ErrorCount.ToString());
                return RedirectToAction("ChatList", new { senderId = viewModel.Message.SenderId, recieverId = viewModel.Message.ReceiverId });
            }
        }


        [HttpGet]
        public IActionResult Add(string senderId, string receiverId)
        {
            var sender = _context.Users.Where(u => u.Id.Equals(senderId)).FirstOrDefault();
            var receiver = _context.Users.Where(u => u.Id.Equals(receiverId)).FirstOrDefault();
            Message message = new Message();



            MessageViewModel viewModel = new MessageViewModel { Message = message, Receiver = receiver, Sender = sender };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(MessageViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewModel.Message);
                _context.SaveChanges();
                return RedirectToAction("Chat11", "Chat", new { senderId = viewModel.Message.ReceiverId, receiverId = viewModel.Message.SenderId } );
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

            var identity = _context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault();
            var id = identity.Id;
            ViewBag.Id = id;


            List<User> notAllUsers = new List<User> { identity };
            var allUsers = _context.Users.ToList();
            var notMeUsers = allUsers.Except(notAllUsers).ToList();

            var viewModel = new UserViewModel
            {
                _users = notMeUsers
            };

            

            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
