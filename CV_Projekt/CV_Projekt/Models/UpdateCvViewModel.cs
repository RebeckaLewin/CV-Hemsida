namespace CV_Projekt.Models
{
	public class UpdateCvViewModel : BaseViewModel
	{
		public string CvId { get; set; }
		public string OwnerId { get; set; }
		public List<Experience> Work { get; set; } = new List<Experience>();
		public List<Experience> Educations { get; set; } = new List<Experience>();
		public List<Experience> Other { get; set; } = new List<Experience>();

		public Work? WorkToAdd { get; set; }
		public Education? EducationToAdd { get; set; }
		public OtherExperience? OtherToAdd { get; set; }

		public UpdateCvViewModel() : base() { }
		public UpdateCvViewModel(CvContext context, string id) : base(context, id) { }
	}
}
