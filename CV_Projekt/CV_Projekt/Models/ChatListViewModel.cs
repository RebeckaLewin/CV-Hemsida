using Microsoft.Identity.Client;

namespace CV_Projekt.Models
{
    public class ChatListViewModel
    {
        public List<Message> RecievedMessages {  get; set; }
        public List<Message> SentMessages { get; set; }
    }
}
