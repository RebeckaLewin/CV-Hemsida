using Microsoft.Identity.Client;

namespace CV_Projekt.Models
{
    public class InboxViewModel : BaseViewModel
    {
        public List<Message> ReceivedMessages {  get; set; }
        public List<User> UsersInContact { get; set; }
        public string LoggedInId { get; set; }

        public InboxViewModel() : base() { }
		public InboxViewModel(CvContext context, string id) : base(context, id) { }

	}
}
