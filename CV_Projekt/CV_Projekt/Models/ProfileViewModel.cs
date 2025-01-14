namespace CV_Projekt.Models
{
    public class ProfileViewModel : BaseViewModel
    {
        public User User { get; set; } 
        public List<Project> Projects { get; set; }
        public List<Tag> Tags { get; set; }

        public ProfileViewModel() : base() { }
		public ProfileViewModel(CvContext context, string id) : base(context, id) { }
	}
}
