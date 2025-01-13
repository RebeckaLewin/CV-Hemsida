using Microsoft.Identity.Client;

namespace CV_Projekt.Models
{
    public class ChatListViewModel
    {
        public List<Message> ReceivedMessages {  get; set; }
        public List<Message> SentMessages { get; set; }
        public User Receiver {  get; set; }
        public User Sender { get; set; }
        public Message Message { get; set; }
        
    }
}
