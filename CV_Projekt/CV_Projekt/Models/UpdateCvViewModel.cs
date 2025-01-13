namespace CV_Projekt.Models
{
	public class UpdateCvViewModel : BaseViewModel
	{
		public CV Cv { get; set; }
		public Work? WorkToAdd { get; set; }
		public Education? EducationToAdd { get; set; }
		public OtherExperience? OtherToAdd { get; set; }

		public UpdateCvViewModel() : base() { }
		public UpdateCvViewModel(CvContext context, string id) : base(context, id) { }
	}
}
