using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class Message
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Den som skickar behöver ha ett namn.")]
		public string SenderName { get; set; }
		[Required(ErrorMessage ="Meddelandet måste ha ett innehåll")]
        [MaxLength(300, ErrorMessage = "Innehållet får inte överstiga 300 tecken")]
		public string Content { get; set; }
		[Required]
		public DateTime Date { get; set; }
		public string? SenderId { get; set; }
		[Required]
		public string? ReceiverId { get; set; }
		[Required]
		public bool isRead { get; set; }
		[ForeignKey(nameof(SenderId))]
		public virtual User? Sender { get; set; }
		[ForeignKey(nameof(ReceiverId))]
		public virtual User? Receiver { get; set; }

		public bool ReceiverDelete { get; set; }
		public bool SenderDelete { get; set; }

	}
}
