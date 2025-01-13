namespace CV_Projekt.Models
{
    public class UserViewModel : BaseViewModel
    {
        public List<User> _users {  get; set; }

		public UserViewModel(CvContext context, string id) : base(context, id) { }
	}
}
