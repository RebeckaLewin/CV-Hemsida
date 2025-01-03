﻿using Microsoft.EntityFrameworkCore;
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
		public DbSet<Message> Messages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

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

			modelBuilder.Entity<Message>().HasData(
				new Message
				{ 
					Id = 1,
					Subject = "En hälsning",
					Content = "Hej på dig! Hur är det med dig?",
					Date = new DateTime(2020, 6, 12),
					SenderId = 1,
					RecieverId = 2
				},
				new Message
				{
					Id = 2,
					Subject = "Missade",
					Content = "Missade att du skrev, förlåt.",
					Date = new DateTime(2020, 7, 16),
					SenderId = 2,
					RecieverId = 1
				}
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
				new CV
				{
					Id = 1,
					OwnerId = 1,
					Skills = new List<string> { "Projektledning", "CSS", "HTML" },
					Views = 10
				},
                new CV
                {
                    Id = 2,
                    OwnerId = 3,
                    Skills = new List<string> { "Grafisk design", "Pedagogik" },
                    Views = 11
                }
            );

			modelBuilder.Entity<Project>().HasData(
				new Project
				{
					Id = 1,
					StartDate = new DateTime(2010, 8, 30),
					EndDate = new DateTime(2011, 8, 30),
					Title = "Tidtabell för postnord",
                    Description = "En app för att optimera postleveranser.",
                    CreatorId = 1
                },
                new Project
                {
                    Id = 2,
                    StartDate = new DateTime(2012, 1, 15),
                    EndDate = new DateTime(2015, 3, 10),
                    Title = "SJ Bokningssystem",
                    Description = "Ett bokningssystem för SJ-resor.",
                    CreatorId = 3
                }
            );

			modelBuilder.Entity<Message>()
				.HasOne(m => m.Sender)
				.WithMany(s => s.SentMessages)
				.OnDelete(DeleteBehavior.ClientSetNull);

			modelBuilder.Entity<Message>()
				.HasOne(m => m.Reciever)
				.WithMany(r => r.RecievedMessages)
				.OnDelete(DeleteBehavior.ClientSetNull);

			modelBuilder.Entity<CV>()
			  .HasMany(cv => cv.Experiences)
			  .WithMany(exp => exp.CVs)
			  .UsingEntity(
				  "CVExperience",
				  l => l.HasOne(typeof(Experience)).WithMany().HasForeignKey("ExperienceId").HasPrincipalKey(nameof(Experience.Id)).OnDelete(DeleteBehavior.Restrict),
				  r => r.HasOne(typeof(CV)).WithMany().HasForeignKey("CVsId").HasPrincipalKey(nameof(CV.Id)).OnDelete(DeleteBehavior.Restrict),
				  j => j.HasKey("ExperienceId", "CVsId")
			  );

			modelBuilder.Entity<CV>()
				.HasMany(cv => cv.Projects)
				.WithMany(proj => proj.CVs)
				.UsingEntity(
					"CVProject",
					l => l.HasOne(typeof(CV)).WithMany().HasForeignKey("CVsId").HasPrincipalKey(nameof(CV.Id)).OnDelete(DeleteBehavior.Restrict),
					r => r.HasOne(typeof(Project)).WithMany().HasForeignKey("ProjectsId").HasPrincipalKey(nameof(Project.Id)).OnDelete(DeleteBehavior.Restrict),
					j => j.HasKey("CVsId", "ProjectsId")
				);

			modelBuilder.Entity<CV>()
				.HasMany(cv => cv.Tags)
				.WithMany(t => t.CVs)
				.UsingEntity(
					"CVTag",
					l => l.HasOne(typeof(CV)).WithMany().HasForeignKey("CVsId").HasPrincipalKey(nameof(CV.Id)).OnDelete(DeleteBehavior.Restrict),
					r => r.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagsId").HasPrincipalKey(nameof(Tag.Id)).OnDelete(DeleteBehavior.Restrict),
					j => j.HasKey("CVsId", "TagsId")
				);

			modelBuilder.Entity("CVProject").HasData(
				new { CVsId = 2, ProjectsId = 1 },
			    new { CVsId = 2, ProjectsId = 2 }
			);

			modelBuilder.Entity("CVExperience").HasData(
				new { CVsId = 1, ExperienceId = 1 },
				new { CVsId = 1, ExperienceId = 2 },
				new { CVsId = 2, ExperienceId = 3 }
			);

			modelBuilder.Entity("CVTag").HasData(
				new { CVsId = 1, TagsId = 2 },
				new { CVsId = 1, TagsId = 3 }
			);
        }
    }
}
