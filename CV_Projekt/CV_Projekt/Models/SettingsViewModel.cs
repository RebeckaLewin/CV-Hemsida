﻿using Microsoft.AspNetCore.Identity;

namespace CV_Projekt.Models
{
	public class SettingsViewModel : BaseViewModel
	{
		public User User { get; set; }
		public string ConfirmedPassword { get; set; } = string.Empty;

		public List<Tag>? Tags { get; set; } = new List<Tag>();
		public string? TagId { get; set; }

		public IFormFile? ImageFile { get; set; }

		public SettingsViewModel() : base() { }
		public SettingsViewModel(CvContext context, string id) : base(context, id) { }
	}
}
