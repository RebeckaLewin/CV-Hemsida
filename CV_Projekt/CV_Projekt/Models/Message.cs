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
		public int? SenderId { get; set; }
		[Required]
		public int? RecieverId { get; set; }

		[ForeignKey(nameof(SenderId))]
		public virtual User? Sender { get; set; }
		[ForeignKey(nameof(RecieverId))]
		public virtual User? Reciever { get; set; }
	}
}
