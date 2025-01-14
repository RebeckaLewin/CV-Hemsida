﻿using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Security.Claims;
using System.Security.Cryptography;

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

            var recMes1 = recMes.DistinctBy(r => r.SenderId).ToList();

            var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var viewModel = new ChatListViewModel(_context, loggedInId)
            {
                ReceivedMessages = recMes1,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChatList(ChatListViewModel viewModel)
        {
            var mess = _context.Messages.Where(m => m.Id.Equals(viewModel.Message.Id)).FirstOrDefault();
            viewModel.Message = mess;

            if (ModelState.IsValid)
            {
                mess.isRead = true;
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

            var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            MessageViewModel viewModel = new MessageViewModel(_context, loggedInUserId) { Message = message, Receiver = receiver, Sender = sender };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(MessageViewModel viewModel)
        {
            viewModel.Sender = _context.Users.Where(u => u.Id.Equals(viewModel.Message.SenderId)).FirstOrDefault();
            viewModel.Receiver = _context.Users.Where(u => u.Id.Equals(viewModel.Message.ReceiverId)).FirstOrDefault();
            

            if (ModelState.IsValid)
            {
                var mess = viewModel.Message;
                _context.Messages.Add(mess);
                _context.SaveChanges();
                return RedirectToAction("Chat11", "Chat", new { senderId = viewModel.Message.ReceiverId, receiverId = viewModel.Message.SenderId } );
            }
            else
            {
                Console.WriteLine(ModelState.ErrorCount.ToString());
                return RedirectToAction("Add", new { senderId = viewModel.Message.SenderId, receiverId = viewModel.Message.ReceiverId });
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

			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			var viewModel = new UserViewModel(_context, loggedInId)
            {
                _users = notMeUsers
            };

            

            return View(viewModel);
        }
        
        [HttpGet]
        public IActionResult AddAnon(string id)
        {
			var receiver = _context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
			Message message = new Message();

			AddAnonViewModel viewModel = new AddAnonViewModel(_context, null) { Message = message, Receiver = receiver, Sender = null };
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult AddAnon(AddAnonViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
                var subject = Subject(viewModel.Message.Subject, viewModel.Name, viewModel.Email);
                var message = viewModel.Message;
                message.Subject = subject;
				_context.Add(message);
				_context.SaveChanges();
				return RedirectToAction("SentAnon", viewModel);
			}
			else
			{
				Console.WriteLine(ModelState.ErrorCount.ToString());
				return RedirectToAction("AddAnon", new {id = viewModel.Message.ReceiverId });
			}
		}

		public string Subject(string subject, string name, string email)
        {
            var firstLine = "<h3> Från: " + name + "</h3>";
            var secondLine = "<h4> Email: " + email + "</h4>";
            var thirdLine = "<h4> Ämne: " + subject + "</h4>";
            var subjectWhole = firstLine + Environment.NewLine + secondLine + Environment.NewLine + thirdLine;
            return (subjectWhole);
        }

        [HttpGet]
        public IActionResult SentAnon(MessageViewModel viewModel)
        {
            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
