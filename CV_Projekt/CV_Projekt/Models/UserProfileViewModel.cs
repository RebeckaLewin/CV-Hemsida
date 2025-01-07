﻿namespace CV_Projekt.Models
{
    public class UserProfileViewModel
    {
        public List<CV> Cvs { get; set; }
        public User User { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public List<Project> ProjectsCreated { get; set; }
        public List<Project> ProjectCollaborator { get; set; }

        public List<Experience> Experiences { get; set; }

        public List<string> Skills { get; set; }
        public List<Tag> Tags { get; set; }
    }
}