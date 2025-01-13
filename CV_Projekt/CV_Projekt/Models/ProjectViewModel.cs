namespace CV_Projekt.Models
{
	public class ProjectViewModel : BaseViewModel
	{
		public List<User> Creators { get; set; } = new List<User>();
		public List<Project> Projects { get; set; }
		public List<User>? Users { get; set; } = new List<User>();
		public Project ProjectToSave { get; set; }

		public Project Project {  get; set; }

		public User Creator { get; set; }

		public ProjectViewModel() : base() { }
		public ProjectViewModel(CvContext context, string id) : base(context, id) { }
	}
}
