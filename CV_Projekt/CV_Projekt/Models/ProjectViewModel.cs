namespace CV_Projekt.Models
{
	public class ProjectViewModel
	{
		public List<User>? Users { get; set; } = new List<User>();
		public Project ProjectToSave { get; set; }
	}
}
