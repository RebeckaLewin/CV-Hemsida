using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public class User : IdentityUser
	{
		[Required]
		[RegularExpression("^[a-zA-ZÅÄÖåäö_-]+$")]
		public string FirstName { get; set; }
		/*
		[Required(ErrorMessage = "Eposten måste anges.")]
		[RegularExpression("^[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,}$", ErrorMessage = "Eposten är inte giltig.")]
		public string Email { get; set; }*/
		[Required]
		[RegularExpression("^[A-Za-zÅÄÖåäö_-]+$")]
		public string LastName { get; set; }
		public string Description { get; set; }
		[Required]
		public int InformationId { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Range(6, 20, ErrorMessage = "Lösenordet får endast vara mellan 6 till 20 tecken.")]
		public string Password { get; set; }
		[Required]

		public bool isPrivate { get; set; }
		[Required]
		public bool isActive { get; set; }

		public virtual List<Tag>? Tags { get; set; } = new List<Tag>();

		public byte[]? Picture { get; set; }
		public string? PictureFormat { get; set; }

		public virtual List<Message>? RecievedMessages { get; set; } = new List<Message>();
		public virtual List<Message>? SentMessages { get; set; } = new List<Message>();

		public virtual List<Project>? CreatedProjects { get; set; } = new List<Project>();
		public virtual List<Project>? JoinedProjects { get; set; } = new List<Project>();

		//Picture


		[ForeignKey(nameof(InformationId))]
		public virtual ContactInformation? ContactInformation { get; set; }
	}
}
