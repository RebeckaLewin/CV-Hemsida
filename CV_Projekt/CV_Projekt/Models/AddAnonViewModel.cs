using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
    public class AddAnonViewModel : BaseViewModel
    {
            [Required]
            public Message Message { get; set; }
            public User? Sender { get; set; }
            public User? Receiver { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public AddAnonViewModel() : base() { }
            public AddAnonViewModel(CvContext context, string id) : base(context, id) { }
    }
}

