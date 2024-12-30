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
		public List<Tag> Tags { get; set; }
		public List<Experience> Experiences { get; set; }
		public List<Project> Projects { get; set; }
		public int Views { get; set; }

		[ForeignKey("OwnerId")]
		public User Owner { get; set; }
	}
}
