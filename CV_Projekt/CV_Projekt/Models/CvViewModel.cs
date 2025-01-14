namespace CV_Projekt.Models
{
    public class CvViewModel : BaseViewModel
    {
        public CV CV { get; set; }

        public User Owner { get; set; }

        public List<Experience> Work { get; set; }
        public List<Experience> Educations { get; set; }
        public List<Experience> OtherExperiences { get; set; }

        public List<Project> Projects { get; set; }

        public ContactInformation Info { get; set; }

        public List<string> Skills { get; set; }

        private int Views { get; set; }


        public CvViewModel() : base() { }
		public CvViewModel(CvContext context, string id) : base(context, id) { }

	}
}
