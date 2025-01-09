namespace CV_Projekt.Models
{
    public class ProfileViewModel
    {
        public User User { get; set; } 

        public List<Project> ProjectParticipant { get; set; }

        public List<Project> ProjectCreator { get; set; }

        public List<Experience> Experience { get; set; }

    }
}
