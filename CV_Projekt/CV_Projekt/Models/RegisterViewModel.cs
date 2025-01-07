using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class RegisterViewModel
	{
		[Required]
		public string UserName { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		public string? Phone { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string ConfirmedPassword { get; set; }
		[Required]
		public bool IsPrivate { get; set; }
	}
}
