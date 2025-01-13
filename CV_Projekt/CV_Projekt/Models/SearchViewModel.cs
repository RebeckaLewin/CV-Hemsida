namespace CV_Projekt.Models
{
    public class SearchViewModel
    {
        public List<User> Users { get; set; } = new List<User>();

        public List<(User user, List<string> Skills)> UsersWithSkills { get; set; } = new List<(User user, List<string> Skills)>();
        public List<string> Skills { get; set; } = new List<string>();
    }
}
