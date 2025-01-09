namespace CV_Projekt.Models
{
    public class MessageViewModel
    {
        public Message Message { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
