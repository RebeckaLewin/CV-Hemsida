using Microsoft.Identity.Client;

namespace CV_Projekt.Models
{
    public class ChatListViewModel : BaseViewModel
    {
        public List<Message> ReceivedMessages {  get; set; }
        public List<User> AllPartners { get; set; }
        public Message Message { get; set; }

        public ChatListViewModel() : base() { }
		public ChatListViewModel(CvContext context, string id) : base(context, id) { }

	}
}
