namespace CV_Projekt.Models.Viewmodels
{
	public class UserProfileViewModel
	{
		public User User { get; set; }
		public List<Project> Projects { get; set; }

		//public List<string> Skills { get; set; }
		public List<Tag> Tags { get; set; }
	}
}
