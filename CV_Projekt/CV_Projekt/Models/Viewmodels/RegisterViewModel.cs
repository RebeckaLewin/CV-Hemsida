using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models.Viewmodels
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Eposten måste anges.")]
		[RegularExpression("^[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,}$", ErrorMessage = "Eposten är inte giltig.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Du måste ange ett förnamn.")]
		[RegularExpression("^[a-zA-ZÅÄÖåäö_-]+$", ErrorMessage = "Namn får inte innehålla siffror eller specialtecken.")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Du måste ange ett efternamn.")]
		[RegularExpression("^[a-zA-ZÅÄÖåäö_-]+$", ErrorMessage = "Namn får inte innehålla siffror eller specialtecken.")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Du måste ange en epostadress.")]
		public string? Phone { get; set; }
		[Required(ErrorMessage = "Du måste ange en address.")]
		public string Address { get; set; }
		[Required(ErrorMessage = "Du måste ange ett lösenord.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "Då måste bekräfta lösenord.")]
		[DataType(DataType.Password)]
		public string ConfirmedPassword { get; set; }
		[Required]
		public bool IsPrivate { get; set; }
	}
}
