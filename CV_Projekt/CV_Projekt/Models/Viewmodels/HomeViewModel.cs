namespace CV_Projekt.Models.Viewmodels
{
	public class HomeViewModel
	{
		public List<CV> Cvs { get; set; }
		public List<User> Users { get; set; }
		public User? LoggedInUser { get; set; }
		public List<Project> Projects { get; set; }

		public List<Experience> Experiences { get; set; }

	}
}
