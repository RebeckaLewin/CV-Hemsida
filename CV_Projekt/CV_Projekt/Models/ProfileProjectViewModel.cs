namespace CV_Projekt.Models
{
    public class ProfileProjectViewModel
    {
        public User User { get; set; }
        public List<Project> CreatedProjects { get; set; }

        public List<Project> ProjectParticipant { get; set; }
    }
}
