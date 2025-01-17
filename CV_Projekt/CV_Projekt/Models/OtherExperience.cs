using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class OtherExperience : Experience
	{
		[Required(ErrorMessage = "Andra erfarenheter måste beskriva vilken typ av erfarenhet den är.")]
		public string Type { get; set; }
	}
}
