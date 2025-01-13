using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public abstract class Experience
	{
		public int Id { get; set; }
		[Required]
		public int CvId { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Location { get; set; }
		public string City { get; set; }
		public string? Description { get; set; }


		[ForeignKey(nameof(CvId))]
		public CV? Cv { get; set; }
	}
}
