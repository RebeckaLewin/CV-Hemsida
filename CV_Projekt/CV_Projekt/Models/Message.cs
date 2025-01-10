using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class Message
	{
		public int Id { get; set; }
		[Required]
		public string Subject { get; set; }
		[Required]
		[MaxLength(300)]
		public string Content { get; set; }
		[Required]
		public DateTime Date { get; set; }
		[Required]
		public string? SenderId { get; set; }
		[Required]
		public string? ReceiverId { get; set; }
		[Required]
		public bool ReceiverHasDeleted { get; set; }
		[Required]
		public bool SenderHasDeleted { get; set; }

		[Required]
		bool isRead { get; set; }
		[ForeignKey(nameof(SenderId))]
		public virtual User? Sender { get; set; }
		[ForeignKey(nameof(ReceiverId))]
		public virtual User? Receiver { get; set; }

		public Message()
		{
			ReceiverHasDeleted = false;
			SenderHasDeleted = false;
		}
	}
}
