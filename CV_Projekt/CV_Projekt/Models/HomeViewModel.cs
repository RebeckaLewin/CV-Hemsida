namespace CV_Projekt.Models
{
    public class HomeViewModel
    {
        public List<CV> Cvs { get; set; }
        public List<User> Users { get; set; }
        public User? LoggedInUser { get; set; }
        public Project LatestProject { get; set; }

        public List<Experience> Experiences { get; set; }

    }
}
