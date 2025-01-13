using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CV_Projekt.Models
{
	public abstract class BaseViewModel
	{
		public int UnreadMessages { get; set; }

		public BaseViewModel()
		{
			UnreadMessages = 0;
		}

		public BaseViewModel(CvContext context, string userId)
		{
			if(userId != null)
			{
				List<Message> unreadMessages = context.Messages.Where(
							   m => m.Receiver.Id.Equals(userId)
							   && m.isRead == false)
							   .ToList();
				UnreadMessages = unreadMessages.Count();
			}
			else
			{
				UnreadMessages = 0;
			}
		}
	}
}
