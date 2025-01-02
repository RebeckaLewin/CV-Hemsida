using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class Education : Experience
	{
		[Required(ErrorMessage = "En utbildning måste specifiera sin nivå.")]
		public string? Level { get; set; }
		[Required(ErrorMessage = "En utbildning måste specificera sin inriktning.")]
		public string? Program { get; set; }
	}
}
