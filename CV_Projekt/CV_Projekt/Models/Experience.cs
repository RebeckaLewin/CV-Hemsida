using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public abstract class Experience
	{
		public int Id { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string? Location { get; set; }
		public string? Description { get; set; }
		public int UserId { get; set; }
		public List<int> CVsIds { get; set; } = new List<int>();

		[ForeignKey(nameof(CVsIds))]
		public virtual List<CV>? CVs { get; set; } = new List<CV>();

		[ForeignKey(nameof(UserId))]
		public User? User { get; set; }
	}
}
