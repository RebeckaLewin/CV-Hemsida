namespace CV_Projekt.Models
{
    public class ProfileProjectViewModel : BaseViewModel
    {
        public User User { get; set; }
        public List<Project> CreatedProjects { get; set; }

        public List<Project> ProjectParticipant { get; set; }

		public ProfileProjectViewModel(CvContext context, string id) : base(context, id) { }
	}
}
