using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public class CV
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "CV måste tillhöra en användare.")]
		public int OwnerId { get; set; }
		public List<string> Skills { get; set; } = new List<string>();
		public virtual List<Tag>? Tags { get; set; } = new List<Tag> ();
		public virtual List<int>? ExperiencesIds { get; set; } = new List<int> ();
		public virtual List<int>? ProjectsIds { get; set; } = new List<int> () { };
		public int Views { get; set; }


		[ForeignKey(nameof(ExperiencesIds))]
		public virtual List<Experience>? Experiences { get; set; } = new List<Experience> ();
		[ForeignKey(nameof(ProjectsIds))]
		public virtual List<Project>? Projects { get; set; } = new List<Project> ();
		[ForeignKey(nameof(OwnerId))]
		public virtual User? Owner { get; set; }
	}
}
