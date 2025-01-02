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
		public int CreatorId { get; set; }
		public List<CV>? CVs { get; set; } = new List<CV>(); //ändrade dessa från int CVid


		[ForeignKey(nameof(CV.Id))] //ändrade denna från int cvid
		public virtual List<CV> Cvs { get; set; } = new List<CV>();

		[ForeignKey(nameof(CreatorId))]
		public virtual User Creator { get; set; }

	}
}
