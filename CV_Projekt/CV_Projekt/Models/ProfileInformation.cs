namespace CV_Projekt.Models
{
	public class ProfileInformation
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Address {  get; set; }
		public string Phone { get; set; }
		public List<string> Tags { get; set; }
		public List<Project> CreatedProjects { get; set; } = new List<Project>();
		public List<Project> JoinedProjects { get; set; } = new List<Project>();
		public CV Cv { get; set; }
		public List<Work> Work { get; set; } = new List<Work>();
		public List<Education> Education { get; set; } = new List<Education>();
		public List<OtherExperience> OtherExperience { get; set; } = new List<OtherExperience>();
	}
}
