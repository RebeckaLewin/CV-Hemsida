using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
    public class MessageViewModel
    {
        [Required]
        public Message Message { get; set; }
        public User? Sender { get; set; }
        public User? Receiver { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
