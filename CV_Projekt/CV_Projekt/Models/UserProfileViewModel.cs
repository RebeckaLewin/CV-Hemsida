namespace CV_Projekt.Models
{
    public class UserProfileViewModel : BaseViewModel
    {
        public User User { get; set; }
        public List<Project> Projects { get; set; }

        //public List<string> Skills { get; set; }
        public List<Tag> Tags { get; set; }

        public UserProfileViewModel() : base() { }
		public UserProfileViewModel(CvContext context, string id) : base(context, id) { }
	}
}
