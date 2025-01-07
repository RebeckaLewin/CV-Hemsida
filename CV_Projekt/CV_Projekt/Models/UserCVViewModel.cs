namespace CV_Projekt.Models
{
    public class UserCVViewModel
    {
        public CV CV { get; set; }
        public User Owner { get; set; }
        public List<string> Skills { get; set; }
        public List<Project> Projects { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
