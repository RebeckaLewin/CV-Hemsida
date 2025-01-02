using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CV_Projekt.Models
{
	public class CvContext : DbContext
	{
		public CvContext(DbContextOptions<CvContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<ContactInformation> ContactInformations { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<CV> CVs { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Tag> Tags { get; set; }
		//public DbSet<Message> Messages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			List<Project> projects = [
				new Project
				{
					Id = 1,
					StartDate = new DateTime(2010, 8, 30),
                    Title = "Tidstabell för Postnord",
					CreatorId = 1,
				},
				new Project
				{
					Id = 2,
					StartDate = new DateTime(2010, 8, 30),
                    EndDate = new DateTime(2020, 8, 30),
                    Title = "SJ Bokningssystem",
					Description = "Skapade ett bokningssystem för SJ.",
					CreatorId = 3
				}
			];

			List<CV> cvs = [
				new CV
				{
					Id = 1,
					OwnerId = 1,
					Skills = new List<string> { "Projektledning", "CSS", "HTML" },
					ProjectsIds = new List<int> { projects[0].Id }
				},
				new CV
				{
					Id = 2,
					OwnerId = 2,
					Skills = new List<string> { "Grafisk design", "Pedagogik" },
					ProjectsIds = new List<int> { projects[0].Id, projects[1].Id }
				}
			];

			projects[0].CVs.Add(cvs[0]);
            projects[0].CVs.Add(cvs[0]);
            projects[1].CVs.Add(cvs[1]);

            //projects[0].CVsId.Add(cvs[0].Id);
            //projects[0].CVsId.Add(cvs[0].Id);
            //projects[1].CVsId.Add(cvs[1].Id);

            modelBuilder.Entity<ContactInformation>().HasData(
				new ContactInformation
				{ 
					Id = 1,
					Email = "alicean12@live.se",
					Phone = "0723892311",
					Address = "Rullgatan 24A"
				},
				new ContactInformation
				{
					Id = 2,
					Email = "bobbergstrom@gmail.com",
					Phone = "0724873928",
					Address = "Johanneslunden 7"
				},
				new ContactInformation
				{
					Id = 3,
					Email = "charliec@live.se",
					Phone = "0809483729",
					Address = "Kolagränd 23"
				}
			);

			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = 1,
					FirstName = "Alice",
					LastName = "Andersson",
					InformationId = 1,
					Password = "P@ssword123",
					isPrivate = true,
					isActive = true,
				},
                new User
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Bergström",
                    InformationId = 2,
                    Password = "P@ssword456",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 3,
                    FirstName = "Charlie",
                    LastName = "Carlsson",
                    InformationId = 3,
                    Password = "P@ssword789",
                    isPrivate = false,
                    isActive = false,
                }
            );

			modelBuilder.Entity<Project>().HasData(
				projects[0],
				projects[1]
			);

			modelBuilder.Entity<Tag>().HasData(
				new Tag
				{
					Id = 1,
					Descriptor = "IT"
				},
                new Tag
                {
                    Id = 2,
                    Descriptor = "Medicin"
                },
                new Tag
                {
                    Id = 3,
                    Descriptor = "Omvårdnad"
                },
                new Tag
                {
                    Id = 4,
                    Descriptor = "Transport"
                }
            );

			modelBuilder.Entity<OtherExperience>().HasData(
				new OtherExperience
				{
					Id = 1,
					StartDate = new DateTime(2016, 8, 30),
                    Location = "Örebro kommun",
					Type = "Praktik",
					UserId = 2
				},
                new OtherExperience
                {
					Id = 2,
					StartDate = new DateTime(2021, 8, 30),
                    Location = "Kävesta Folkhögskola",
					Description = "En kurs i drejeri",
                    Type = "Kurs",
					UserId = 1
                },
                new OtherExperience
                {
					Id = 3,
					StartDate = new DateTime(2022, 8, 30),
                    Location = "Röda korset Örebro",
                    Type = "Volentärarbete",
					UserId = 1
                }
            );

			modelBuilder.Entity<Work>().HasData(		
				new Work
				{
                    Id = 4,
                    StartDate = new DateTime(2020, 6, 29),
                    Location = "Café Deed",
                    Description = "Underhåller ett team i bageri/ungdomsgård",
                    Role = "Arbetsledare",
					UserId = 1
				},
                new Work
                {
                    Id = 5,
                    StartDate = new DateTime(2019, 8, 30),
                    Location = "Uppsala Sjukhus",
                    Description = "Omvårdnad",
                    Role = "Sjuksköterska",
                    UserId = 2
                },
                new Work
                {
                    Id = 6,
                    StartDate = new DateTime(2021, 8, 30),
                    Location = "Generiskt Företag",
                    Description = "Arbetsuppgifter",
                    Role = "Arbetstitel",
                    UserId = 3
                }
            );

			modelBuilder.Entity<Education>().HasData(
				new Education
				{
					Id = 7,
					StartDate = new DateTime(2016, 4, 12),
                    Location = "Karolinska Gymnasiet",
					Level = "Gymnasial",
					Program = "Vård och omsorg",
					Description = "",
					UserId = 2
				},
				new Education
				{
					Id = 8,
					StartDate = new DateTime(2010, 2, 02),
                    Location = "Uppsala Universitet",
					Level = "Kandidat",
					Program = "Arkelogi",
					Description = "",
					UserId = 3
				}

			);

			modelBuilder.Entity<CV>().HasData(
				cvs[0],
				cvs[1]		
			);
            modelBuilder.Entity<CV>()
              .HasMany(cv => cv.Experiences)
              .WithMany(exp => exp.CVs)
              .UsingEntity(
                  "CVExperience",
                  l => l.HasOne(typeof(Experience)).WithMany().HasForeignKey("ExperienceId").HasPrincipalKey(nameof(Experience.Id)).OnDelete(DeleteBehavior.Restrict),
                  r => r.HasOne(typeof(CV)).WithMany().HasForeignKey("CVId").HasPrincipalKey(nameof(CV.Id)).OnDelete(DeleteBehavior.Restrict),
                  j => j.HasKey("ExperienceId", "CVId"));


			modelBuilder.Entity<CV>()
				.HasMany(cv => cv.Projects)
				.WithMany(p => p.CVs)
				.UsingEntity(
					"CVPRoject",
					l => l.HasOne(typeof(Project)).WithMany().HasForeignKey("ProjectId").HasPrincipalKey(nameof(Project.Id)).OnDelete(DeleteBehavior.Restrict),
					r => r.HasOne(typeof(CV)).WithMany().HasForeignKey("CVId").HasPrincipalKey(nameof(CV.Id)).OnDelete(DeleteBehavior.Restrict),
					j => j.HasKey("ProjectId", "CVId"));


        }
    }
}
