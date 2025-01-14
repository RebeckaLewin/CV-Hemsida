using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class Message
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Ämne måste anges.")]
		public string Subject { get; set; }
		[Required(ErrorMessage ="Meddelandet måste ha ett innehåll.")]
        [MaxLength(300, ErrorMessage = "Innehållet får inte överstiga 300 tecken")]
		public string Content { get; set; }
		[Required(ErrorMessage = "Meddelandet måste ha ett datum.")]
		public DateTime Date { get; set; }
		public string? SenderId { get; set; }
		[Required]
		public string SenderName { get; set; }
		[Required(ErrorMessage = "Meddelandet måste ha en mottagare.")]
		public string? ReceiverId { get; set; }
		[Required(ErrorMessage = "Meddelandet måste vara läst eller inte.")]
		public bool isRead { get; set; }

		[ForeignKey(nameof(SenderId))]
		public virtual User? Sender { get; set; }
		[ForeignKey(nameof(ReceiverId))]
		public virtual User? Receiver { get; set; }

		[Required(ErrorMessage = "Meddelandet måste vara raderat eller inte.")]
		public bool ReceiverDelete { get; set; }
		[Required(ErrorMessage = "Meddelandet måste vara raderat eller inte.")]
		public bool SenderDelete { get; set; }

		public Message()
		{
			ReceiverDelete = false;
			SenderDelete = false;
			isRead = false;
		}
	}
}
