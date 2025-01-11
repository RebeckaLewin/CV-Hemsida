using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models.Viewmodels
{
	public class LogInViewModel
	{
		[Required(ErrorMessage = "Du måste ange ett användarnamn.")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Du måste ange ett lösenord.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
