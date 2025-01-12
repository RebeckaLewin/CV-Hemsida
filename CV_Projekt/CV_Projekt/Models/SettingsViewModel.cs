using Microsoft.AspNetCore.Identity;
using System.Web.Helpers;

namespace CV_Projekt.Models
{
	public class SettingsViewModel
	{
		public User User { get; set; }
		public string ConfirmedPassword { get; set; } = string.Empty;

		public IFormFile? ImageFile { get; set; }
	}
}
