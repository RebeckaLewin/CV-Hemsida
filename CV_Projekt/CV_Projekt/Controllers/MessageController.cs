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
                .Where(m => m.RecieverId.Equals(id))
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
            Message message = new Message();
            var sender = _context.Users.Where(u => u.Id.Equals(senderId)).FirstOrDefault();
            var reciever = _context.Users.Where(u => u.Id.Equals(recieverId)).FirstOrDefault();
            var firstName = reciever.FirstName;
            var lastName = reciever.LastName;
            var fullName = firstName + " " + lastName;
            ViewBag.fullName = fullName;
            ViewBag.senderId = senderId;
            ViewBag.recieverId = recieverId;
            return View(message);
        }

        [HttpPost]
        public IActionResult Add(Message message, string senderId, string recieverId)
        {
            if (ModelState.IsValid)
            {
                _context.Add(message);
                _context.SaveChanges();
                return RedirectToAction("Chat11", "Chat");
            }
            else
            {
                var sender = _context.Users.Where(u => u.Id.Equals(senderId)).FirstOrDefault();
                var reciever = _context.Users.Where(u => u.Id.Equals(recieverId)).FirstOrDefault();
                var firstName = reciever.FirstName;
                var lastName = reciever.LastName;
                var fullName = firstName + " " + lastName;
                ViewBag.fullName = fullName;
                ViewBag.senderId = senderId;
                ViewBag.recieverId = recieverId;
                return View(message);
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
