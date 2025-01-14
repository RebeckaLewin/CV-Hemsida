using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public class Project
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Ett projekt måste ha ett startdatum.")]
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		[Required(ErrorMessage = "Ett projekt måste ha en titel.")]
		public string Title { get; set; }
		public string? Description { get; set; }
		[Required(ErrorMessage = "Ett projekt måste ha en ägare.")]
		public string CreatorId { get; set; }
		public virtual List<User>? Participants { get; set; } = new List<User>();


		[ForeignKey(nameof(CreatorId))]
		public virtual User? Creator { get; set; }

	}
}
