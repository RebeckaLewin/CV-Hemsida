namespace CV_Projekt.Models
{
    public class Chat11ViewModel : BaseViewModel
    {
        public List<Message> ReceivedMessages { get; set; }
        public List<Message> SentMessages { get; set; }
        public User Receiver { get; set; }
        public User Sender { get; set; }
        public Message Message { get; set; }

        public Chat11ViewModel() : base() { }
        public Chat11ViewModel(CvContext context, string id) : base(context, id) { }

    }
}
