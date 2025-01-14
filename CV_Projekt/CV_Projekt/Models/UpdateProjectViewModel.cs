namespace CV_Projekt.Models
{
	public class UpdateProjectViewModel : BaseViewModel
	{
		public Project Project { get; set; }

		public UpdateProjectViewModel() : base() { } 
		public UpdateProjectViewModel(CvContext context, string id) : base(context, id) { }
	}
}
