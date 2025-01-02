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
		public List<string> Skills { get; set; }
		public virtual List<Tag>? Tags { get; set; } = [];
		public virtual List<int>? ExperiencesIds { get; set; } = [];
		public virtual List<int>? ProjectsIds { get; set; } = [];
		public int Views { get; set; }


		[ForeignKey(nameof(ExperiencesIds))]
		public virtual List<Experience>? Experiences { get; set; }
		[ForeignKey(nameof(ProjectsIds))]
		public virtual List<Project>? Projects { get; set; } = [];
		[ForeignKey(nameof(OwnerId))]
		public virtual User? Owner { get; set; }
	}
}
