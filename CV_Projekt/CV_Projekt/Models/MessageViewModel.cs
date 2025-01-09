using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
    public class MessageViewModel
    {
        [Required]
        public Message Message { get; set; }
        [Required]
        public User Sender { get; set; }
        [Required]
        public User Receiver { get; set; }
    }
}
