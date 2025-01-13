namespace CV_Projekt.Models
{
    public class ProfileViewModel
    {
        public User User { get; set; } 
        public List<Project> Projects { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
