﻿namespace CV_Projekt.Models
{
    public class HomeViewModel : BaseViewModel
    {
        public List<CV> Cvs { get; set; }
        public List<User> Users { get; set; }
        public User? LoggedInUser { get; set; }
        public Project LatestProject { get; set; }

        public List<Experience> Experiences { get; set; }

		public HomeViewModel() : base() { }
		public HomeViewModel(CvContext context, string id) : base(context, id) { }
    }
}
