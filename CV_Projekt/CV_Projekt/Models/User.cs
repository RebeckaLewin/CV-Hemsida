using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public class User : IdentityUser
	{
		public int Id { get; set; }
		[Required]
		[RegularExpression("^[a-zA-ZÅÄÖåäö_-]+$")]
		public string FirstName { get; set; }
		[Required]
		[RegularExpression("^[A-Za-zÅÄÖåäö_-]+$")]
		public string LastName { get; set; }
		[Required]
		public int InformationId { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Range(6, 20)]
		public string Password { get; set; }
		[Required]
		public bool isPrivate { get; set; }
		[Required]
		public bool isActive { get; set; }
		public List<CV> CVs { get; set; }
		//Picture


		[ForeignKey("InformationId")]
		public ContactInformation ContactInformation { get; set; }
	}
}
