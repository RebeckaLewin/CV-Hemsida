namespace CV_Projekt.Models
{
    public class CVViewModel
    {
        public List<CV> Cvs { get; set; }
        public List<User> Users { get; set; }

        public List<Project> Projects { get; set; }

        public List<Experience> Experiences { get; set; }

        public List<Tag> Tags { get; set; }
        public List<string> Skills {  get; set; } 
    }
}
