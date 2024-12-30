using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class Work : Experience
	{
		[Required(ErrorMessage = "Arbetserfarenhet måste specificera roll.")]
		public string Role { get; set; }
	}
}
