using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public class User : IdentityUser
	{
		[Required(ErrorMessage = "Förnamn är obligatoriskt.")]
		[RegularExpression("^[a-zA-ZÅÄÖåäö_-]+$", ErrorMessage = "Förnamnet får endast innehålla bokstäver och bindestreck.")]
		public string FirstName { get; set; }
		/*
		[Required(ErrorMessage = "Eposten måste anges.")]
		[RegularExpression("^[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,}$", ErrorMessage = "Eposten är inte giltig.")]
		public string Email { get; set; }*/
		[Required(ErrorMessage = "Efternamn är obligatoriskt.")]
		[RegularExpression("^[A-Za-zÅÄÖåäö_-]+$", ErrorMessage = "Efternamnet får endast innehålla bokstäver och bindestreck.")]
		public string LastName { get; set; }
		public string? Description { get; set; }
		[Required]
		public int InformationId { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Length(6, 20, ErrorMessage = "Lösenordet får endast vara mellan 6 till 20 tecken.")]
		public string Password { get; set; }
		[Required]

		public bool isPrivate { get; set; }
		[Required]
		public bool isActive { get; set; }

		public string? PictureUrl { get; set; }

		public virtual List<Message>? RecievedMessages { get; set; } = new List<Message>();
		public virtual List<Message>? SentMessages { get; set; } = new List<Message>();

		public virtual List<Project>? CreatedProjects { get; set; } = new List<Project>();
		public virtual List<Project>? JoinedProjects { get; set; } = new List<Project>();

		public virtual List<Tag>? Tags { get; set; } = new List<Tag>();


		[ForeignKey(nameof(InformationId))]
		public virtual ContactInformation? ContactInformation { get; set; }
	}
}
