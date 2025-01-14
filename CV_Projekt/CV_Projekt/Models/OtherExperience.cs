using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class OtherExperience : Experience
	{
		[Required]
		public string Type { get; set; }
	}
}
