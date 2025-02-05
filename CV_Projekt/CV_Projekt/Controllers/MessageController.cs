﻿using CV_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Diagnostics;
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
        //hämtar och visar inbox för den inloggade usern
        public IActionResult Inbox()
        {
            string loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInUser = _context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();

            ViewBag.Id = loggedInId;
            //hämtar unika users som har skickat/tagit emot meddelanden till/från inloggad user
            List<string> userIds = _context.Messages.Where(m => m.ReceiverId.Equals(loggedInId)).Select(m => m.SenderId).ToList();
            userIds.AddRange(_context.Messages.Where(m => m.SenderId.Equals(loggedInId)).Select(m => m.ReceiverId).ToList());
            userIds = userIds.DistinctBy(id => id).ToList();
            List<User> usersInContact = new List<User>();

            foreach(string id in userIds)
            {
                if(id == null)
                {
                    continue;
                }
                User newUser = _context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
                usersInContact.Add(newUser);
            }
            //hämtar olästa meddelanden
			var receivedMes = _context.Messages
                .Where(m => m.ReceiverId.Equals(loggedInId))
                .Where(m => m.isRead.Equals(false))
                .OrderByDescending(m => m.Date)
                .ToList();
            //separerar anonyma meddelanden från andra meddelanden
            var anonMes = receivedMes.Where(m => m.SenderId == null).ToList();
            receivedMes = receivedMes.Except(anonMes).ToList();

            var viewModel = new InboxViewModel(_context, loggedInId)
            {
                ReceivedMessages = receivedMes,
                AnonMessages = anonMes,
                UsersInContact = usersInContact,
                LoggedInId = loggedInId
            };

            return View(viewModel);
        }


        [HttpGet]
        public IActionResult Add(string oid)
        {
			var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			User loggedInUser = _context.Users.Where(u => u.Id.Equals(loggedInUserId)).FirstOrDefault();
            User otherUser = _context.Users.Where(u => u.Id.Equals(oid)).FirstOrDefault();
            Message message = new Message();

            MessageViewModel viewModel = new MessageViewModel(_context, loggedInUserId) { Message = message, Receiver = otherUser, Sender = loggedInUser };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(MessageViewModel viewModel)
        {
            viewModel.Message.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var mess = viewModel.Message;
                _context.Messages.Add(mess);
                _context.SaveChanges();
                return RedirectToAction("Profile", "Profile", new { id = viewModel.Message.ReceiverId } );
            }
            else
            {
                Debug.WriteLine(ModelState.ErrorCount.ToString());
                if (viewModel.Sender == null)
                {
                    return RedirectToAction("AddAnon", new { oid = viewModel.Message.ReceiverId });
                }
                else
                {
					return RedirectToAction("Add", new { oid = viewModel.Message.ReceiverId });
				}
            }
        }

        [HttpPost]
        public IActionResult SetToRead(int mid)
        {
            Message mess = _context.Messages.Where(m => m.Id == mid).FirstOrDefault();
            mess.isRead = true;
            _context.Messages.Update(mess);
            _context.SaveChanges();
            return RedirectToAction("Inbox");
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
        public IActionResult AddAnon(string oid)
        {
			User otherUser = _context.Users.Where(u => u.Id.Equals(oid)).FirstOrDefault();
			Message message = new Message();

			MessageViewModel viewModel = new MessageViewModel() { Message = message, Receiver = otherUser };
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult AddAnon(AddAnonViewModel viewModel)
		{
			if (ModelState.IsValid)
			{               
                var message = viewModel.Message;
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
