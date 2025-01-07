namespace CV_Projekt.Models
{
    public class ProfileViewModel
    {
        public List<CV> Cvs { get; set; }
        public User User { get; set; }

        public List<Project> ProjectsCreated { get; set; }
        public List<Project> ProjectCollaborator { get; set; }

        public List<Experience> Experiences { get; set; }

        public List<string> Skills { get; set; }
        public List<Tag> Tags { get; set; }

        public ContactInformation Info {  get; set; }
        
    }
}
