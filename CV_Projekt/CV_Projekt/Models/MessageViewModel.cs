using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
    public class MessageViewModel : BaseViewModel
    {
        [Required]
        public Message Message { get; set; }
        public User? Sender { get; set; }
        public User? Receiver { get; set; }

		public MessageViewModel(CvContext context, string id) : base(context, id) { }
	}
}
