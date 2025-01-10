namespace CV_Projekt.Models
{
	public class ProjectViewModel
	{
		public List<User>? Users { get; set; }
		public List<Project>? Projects { get; set; }
		public Project ProjectToSave { get; set; }
		public User Creator { get; set; }
		public bool IsUpdating { get; set; }
	}
}
