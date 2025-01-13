namespace CV_Projekt.Models
{
    public class SearchViewModel : BaseViewModel
    {
        public List<User> Users { get; set; } = new List<User>();

        public List<CV> CVs { get; set; }

		public SearchViewModel(CvContext context, string id) : base(context, id) { }
	}
}
