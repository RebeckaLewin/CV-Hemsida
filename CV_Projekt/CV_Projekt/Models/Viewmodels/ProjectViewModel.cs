namespace CV_Projekt.Models.Viewmodels
{
	public class ProjectViewModel
	{
		public List<User>? Users { get; set; } = new List<User>();
		public Project ProjectToSave { get; set; }
	}
}
