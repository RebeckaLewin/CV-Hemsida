using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public abstract class Experience
	{
		public int Id { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Location { get; set; }
		public string Description { get; set; }
	}
}
