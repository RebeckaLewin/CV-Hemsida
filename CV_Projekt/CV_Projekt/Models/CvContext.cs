﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace CV_Projekt.Models
{
    public class CvContext : IdentityDbContext<User>
    {
        public CvContext(DbContextOptions<CvContext> options) : base(options) { }

        public override DbSet<User> Users { get; set; }
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
                    Phone = "0723892311",
                    Address = "Rullgatan 24A"
                },
                new ContactInformation
                {
                    Id = 2,
                    Phone = "0724873928",
                    Address = "Johanneslunden 7"
                },
                new ContactInformation
                {
                    Id = 3,
                    Phone = "0809483729",
                    Address = "Kolagränd 23"
                },

                new ContactInformation
                {
                    Id = 4,
                    Phone = "0738452390",
                    Address = "Mossvägen 15"
                },
                new ContactInformation
                {
                    Id = 5,
                    Phone = "0709847328",
                    Address = "Bäckstigen 12B"
                },
                new ContactInformation
                {
                    Id = 6,
                    Phone = "0762938475",
                    Address = "Kullavägen 8"
                },
                new ContactInformation
                {
                    Id = 7,
                    Phone = "0701938476",
                    Address = "Tallbacken 4"
                },
                new ContactInformation
                {
                    Id = 8,
                    Phone = "0739487261",
                    Address = "Lärkträdsvägen 10"
                },
                new ContactInformation
                {
                    Id = 9,
                    Phone = "0723847569",
                    Address = "Allegatan 14C"
                },
                new ContactInformation
                {
                    Id = 10,
                    Phone = "0768273945",
                    Address = "Stenvägen 5A"
                }
            );

            List<User> newUsers = [new User
                {
                    Id = 1.ToString(),
                    FirstName = "Alice",
                    LastName = "Andersson",
                    UserName = "alicean12@live.se",
                    Email = "alicean12@live.se",
					InformationId = 1,
                    Password = "P@ssword123",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 2.ToString(),
                    FirstName = "Bob",
                    LastName = "Bergström",
                    UserName = "bobbergstrom@gmail.com",
                    Email = "bobbergstrom@gmail.com",
					InformationId = 2,
                    Password = "P@ssword456",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 3.ToString(),
                    FirstName = "Charlie",
                    LastName = "Carlsson",
                    UserName = "charliec@live.se",
                    Email = "charliec@live.se",
					InformationId = 3,
                    Password = "P@ssword789",
                    isPrivate = false,
                    isActive = false,
                },
                new User
                {
                    Id = 4.ToString(),
                    FirstName = "Daniel",
                    LastName = "Davidsson",
                    UserName = "danield@outlook.com",
                    Email = "danield@outlook.com",
					InformationId = 4,
                    Password = "SecureP@ss1",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 5.ToString(),
                    FirstName = "Emily",
                    LastName = "Evans",
                    UserName = "emily.evans@hotmail.com",
                    Email = "emily.evans@hotmail.com",
					InformationId = 5,
                    Password = "MyP@ssword2",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 6.ToString(),
                    FirstName = "Frank",
                    LastName = "Fischer",
                    UserName = "frankfischer@gmail.com",
                    Email = "frankfischer@gmail.com",
					InformationId = 6,
                    Password = "StrongP@ss3",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 7.ToString(),
                    FirstName = "Grace",
                    LastName = "Gustafsson",
                    UserName = "grace.gustafsson@live.se",
                    Email = "grace.gustafsson@live.se",
					InformationId = 7,
                    Password = "GracefulP@ss4",
                    isPrivate = false,
                    isActive = false,
                },
                new User
                {
                    Id = 8.ToString(),
                    FirstName = "Hanna",
                    LastName = "Holm",
                    UserName = "hanna.holm@gmail.com",
                    Email = "hanna.holm@gmail.com",
					InformationId = 8,
                    Password = "H@nnasP@ss5",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 9.ToString(),
                    FirstName = "Ian",
                    LastName = "Ingemarsson",
                    UserName = "ian.ingemarsson@outlook.com",
                    Email = "ian.ingemarsson@outlook.com",
					InformationId = 9,
                    Password = "I@nsSecure6",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 10.ToString(),
                    FirstName = "Julia",
                    LastName = "Jonsson",
                    UserName = "julia.jonsson@yahoo.com",
                    Email = "julia.jonsson@yahoo.com",
					InformationId = 10,
                    Password = "JuliasP@ss7",
                    isPrivate = true,
                    isActive = false,
                }];

			var hasher = new PasswordHasher<User>();
			foreach (var user in newUsers)
			{
				user.PasswordHash = hasher.HashPassword(user, user.Password);
                user.NormalizedEmail = user.Email.Normalize();
                user.NormalizedUserName = user.UserName.Normalize();
                user.PictureUrl = "~/images/profilepic_default.jpg";
			}

			modelBuilder.Entity<User>().HasData(
               newUsers[0],
               newUsers[1],
			   newUsers[2],
			   newUsers[3],
			   newUsers[4],
			   newUsers[5],
			   newUsers[6],
			   newUsers[7],
			   newUsers[8],
			   newUsers[9]
			);

			modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    Id = 1,
                    Subject = "En hälsning",
                    Content = "Hej på dig! Hur är det med dig?",
                    Date = new DateTime(2020, 6, 12),
                    SenderId = 1.ToString(),
                    ReceiverId = 2.ToString()
                },
                new Message
                {
                    Id = 2,
                    Subject = "Missade",
                    Content = "Missade att du skrev, förlåt.",
                    Date = new DateTime(2020, 7, 16),
                    SenderId = 2.ToString(),
                    ReceiverId = 1.ToString()
                },
                new Message
                {
                    Id = 3,
                    Subject = "Lunch?",
                    Content = "Ska vi ta en lunch imorgon?",
                    Date = new DateTime(2020, 8, 1),
                    SenderId = 3.ToString(),
                    ReceiverId = 1.ToString()
                },
                new Message
                {
                    Id = 4,
                    Subject = "Tack!",
                    Content = "Tack för att du hjälpte mig med projektet.",
                    Date = new DateTime(2020, 8, 15),
                    SenderId = 1.ToString(),
                    ReceiverId = 3.ToString()
                },
                new Message
                {
                    Id = 5,
                    Subject = "Fråga",
                    Content = "Kan du kika på dokumentet jag skickade?",
                    Date = new DateTime(2020, 9, 10),
                    SenderId = 4.ToString(),
                    ReceiverId = 5.ToString()
                },
                new Message
                {
                    Id = 6,
                    Subject = "Feedback",
                    Content = "Jag har lagt till några kommentarer i ditt utkast.",
                    Date = new DateTime(2020, 9, 15),
                    SenderId = 5.ToString(),
                    ReceiverId = 4.ToString()
                },
                new Message
                {
                    Id = 7,
                    Subject = "Möte",
                    Content = "Glöm inte mötet imorgon kl. 10.",
                    Date = new DateTime(2020, 10, 1),
                    SenderId = 6.ToString(),
                    ReceiverId = 7.ToString()
                },
                new Message
                {
                    Id = 8,
                    Subject = "Presentation",
                    Content = "Har du hunnit förbereda presentationen?",
                    Date = new DateTime(2020, 10, 20),
                    SenderId = 7.ToString(),
                    ReceiverId = 6.ToString()
                },
                new Message
                {
                    Id = 9,
                    Subject = "Grattis!",
                    Content = "Grattis på födelsedagen!",
                    Date = new DateTime(2020, 11, 3),
                    SenderId = 8.ToString(),
                    ReceiverId = 9.ToString()
                },
                new Message
                {
                    Id = 10,
                    Subject = "Trevlig helg",
                    Content = "Ha en trevlig helg! Vi hörs på måndag.",
                    Date = new DateTime(2020, 11, 6),
                    SenderId = 9.ToString(),
                    ReceiverId = 10.ToString()
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
                },
                new Tag
                {
                    Id = 5,
                    Descriptor = "Utbildning"
                },
                new Tag
                {
                    Id = 6,
                    Descriptor = "Forskning"
                },
                new Tag
                {
                    Id = 7,
                    Descriptor = "Miljö"
                },
                new Tag
                {
                    Id = 8,
                    Descriptor = "Kultur"
                },
                new Tag
                {
                    Id = 9,
                    Descriptor = "Sport"
                },
                new Tag
                {
                    Id = 10,
                    Descriptor = "Ekonomi"
                },
                new Tag
                {
                    Id = 11,
                    Descriptor = "Teknik"
                }
            );


			modelBuilder.Entity<CV>().HasData(
				new CV
				{
					Id = 1,
					OwnerId = 1.ToString(),
					Skills = new List<string> { "Projektledning", "CSS", "HTML" },
					Views = 10
				},
				new CV
				{
					Id = 2,
					OwnerId = 3.ToString(),
					Skills = new List<string> { "Grafisk design", "Pedagogik" },
					Views = 11
				},
				new CV
				{
					Id = 3,
					OwnerId = 2.ToString(),
					Skills = new List<string> { "Omvårdnad", "Kommunikation" },
					Views = 15
				},
				new CV
				{
					Id = 4,
					OwnerId = 4.ToString(),
					Skills = new List<string> { "Eventplanering", "Samordning" },
					Views = 8
				},
				new CV
				{
					Id = 5,
					OwnerId = 5.ToString(),
					Skills = new List<string> { "Ingenjörskonst", "Produktutveckling" },
					Views = 12
				},
				new CV
				{
					Id = 6,
					OwnerId = 6.ToString(),
					Skills = new List<string> { "Forskning", "Biomedicin" },
					Views = 9
				},
				new CV
				{
					Id = 7,
					OwnerId = 7.ToString(),
					Skills = new List<string> { "AI-utveckling", "Python", "Machine Learning" },
					Views = 20
				},
				new CV
				{
					Id = 8,
					OwnerId = 8.ToString(),
					Skills = new List<string> { "Miljöskydd", "Administration" },
					Views = 14
				},
				new CV
				{
					Id = 9,
					OwnerId = 9.ToString(),
					Skills = new List<string> { "Undervisning", "Kursutveckling" },
					Views = 18
				},
				new CV
				{
					Id = 10,
					OwnerId = 10.ToString(),
					Skills = new List<string> { "Patientvård", "Ledarskap" },
					Views = 25
				}
			);

            modelBuilder.Entity<OtherExperience>().HasData(
                new OtherExperience
                {
                    Id = 1,
                    StartDate = new DateTime(2016, 8, 30),
                    EndDate = new DateTime(2017, 8, 21),
                    Location = "Örebro kommun",
                    City = "Örebro",
                    Type = "Praktik",
                    CvId = 1
                },
                new OtherExperience
                {
                    Id = 2,
                    StartDate = new DateTime(2021, 8, 30),
                    Location = "Kävesta Folkhögskola",
                    City = "Sköllersta",
                    Description = "En kurs i drejeri",
                    Type = "Kurs",
                    CvId = 1
                },
                new OtherExperience
                {
                    Id = 3,
                    StartDate = new DateTime(2022, 8, 30),
                    Location = "Röda korset Örebro",
                    City = "Örebro",
                    Type = "Volentärarbete",
                    CvId = 2
                },
                new OtherExperience
                {
                    Id = 4,
                    StartDate = new DateTime(2018, 6, 15),
                    Location = "Linköping universitet",
                    City = "Linköping",
                    Description = "Sommarjobb som forskningsassistent",
                    Type = "Sommarjobb",
                    CvId = 2
                },
                new OtherExperience
                {
                    Id = 5,
                    StartDate = new DateTime(2020, 1, 10),
                    Location = "Karolinska Institutet",
                    Description = "Praktik inom medicinsk forskning",
                    City = "Stockholm",
                    Type = "Praktik",
                    CvId = 4
                },
                new OtherExperience
                {
                    Id = 6,
                    StartDate = new DateTime(2022, 11, 1),
                    Location = "Svenska Röda Korset",
                    Description = "Deltog i hjälparbete för flyktingar",
                    City = "Malmö",
                    Type = "Volentärarbete",
                    CvId = 5
                },
                new OtherExperience
                {
                    Id = 7,
                    StartDate = new DateTime(2019, 9, 5),
                    Location = "Chalmers Tekniska Högskola",
                    City = "Göteborg",
                    Description = "Kurs i hållbart byggande",
                    Type = "Kurs",
                    CvId = 6
                },
                new OtherExperience
                {
                    Id = 8,
                    StartDate = new DateTime(2023, 2, 20),
                    Location = "Örebro Universitet",
                    City = "Örebro",
                    Description = "Projektarbete inom AI-utveckling",
                    Type = "Projektarbete",
                    CvId = 7
                },
                new OtherExperience
                {
                    Id = 9,
                    StartDate = new DateTime(2020, 5, 15),
                    Location = "Naturskyddsföreningen",
                    City = "Kiruna",
                    Description = "Volontärarbete inom miljöskydd",
                    Type = "Volentärarbete",
                    CvId = 8
                },
                new OtherExperience
                {
                    Id = 10,
                    StartDate = new DateTime(2021, 10, 12),
                    Location = "Uppsala Universitet",
                    City = "Uppsala",
                    Description = "Deltog i en workshop om ledarskap",
                    Type = "Workshop",
                    CvId = 9
                }
            );

            modelBuilder.Entity<Work>().HasData(
                new Work
                {
                    Id = 11,
                    StartDate = new DateTime(2020, 6, 29),
                    Location = "Café Deed",
                    City = "Örebro",
                    Description = "Underhåller ett team i bageri/ungdomsgård",
                    Role = "Arbetsledare",
                    CvId = 1
                },
                new Work
                {
                    Id = 12,
                    StartDate = new DateTime(2019, 8, 30),
                    Location = "Uppsala Sjukhus",
                    City = "Uppsala",
                    Description = "Omvårdnad",
                    Role = "Sjuksköterska",
                    CvId = 2
                },
                new Work
                {
                    Id = 13,
                    StartDate = new DateTime(2021, 8, 30),
                    Location = "Generiskt Företag",
                    City = "Generisk stad",
                    Description = "Arbetsuppgifter",
                    Role = "Arbetstitel",
                    CvId = 3
                },
                new Work
                {
                    Id = 14,
                    StartDate = new DateTime(2018, 4, 15),
                    Location = "Stockholms Stad",
                    City = "Stockholm",
                    Description = "Ansvarig för eventplanering och samordning",
                    Role = "Eventkoordinator",
                    CvId = 4
                },
                new Work
                {
                    Id = 15,
                    StartDate = new DateTime(2022, 1, 10),
                    Location = "Volvo Cars",
                    City = "Arboga",
                    Description = "Utveckling och testning av nya bilmodeller",
                    Role = "Ingenjör",
                    CvId = 5
                },
                new Work
                {
                    Id = 16,
                    StartDate = new DateTime(2020, 9, 1),
                    Location = "Karolinska Institutet",
                    City = "Stockholm",
                    Description = "Forskning inom biomedicin",
                    Role = "Forskningsassistent",
                    CvId = 6
                },
                new Work
                {
                    Id = 17,
                    StartDate = new DateTime(2023, 3, 20),
                    Location = "Skatteverket",
                    City = "Örebro",
                    Description = "Hantering av deklarationer och rådgivning",
                    Role = "Handläggare",
                    CvId = 7
                },
                new Work
                {
                    Id = 18,
                    StartDate = new DateTime(2019, 6, 5),
                    Location = "Länsstyrelsen",
                    City = "Köping",
                    Description = "Administration och projektstöd",
                    Role = "Projektassistent",
                    CvId = 8
                },
                new Work
                {
                    Id = 19,
                    StartDate = new DateTime(2021, 11, 12),
                    Location = "Luleå Tekniska Universitet",
                    City = "Luleå",
                    Description = "Undervisning och kursutveckling",
                    Role = "Universitetslärare",
                    CvId = 9
                },
                new Work
                {
                    Id = 20,
                    StartDate = new DateTime(2020, 7, 1),
                    Location = "Norrlands Universitetssjukhus",
                    City = "Skellefteå",
                    Description = "Patientvård och ledning av vårdteam",
                    Role = "Läkare",
                    CvId = 10
                }
            );

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = 21,
                    StartDate = new DateTime(2016, 4, 12),
                    Location = "Karolinska Gymnasiet",
                    City = "Örebro",
                    Level = "Gymnasial",
                    Program = "Vård och omsorg",
                    Description = "",
                    CvId = 2
                },
                new Education
                {
                    Id = 22,
                    StartDate = new DateTime(2010, 2, 02),
                    Location = "Uppsala Universitet",
                    City = "Uppsala",
                    Level = "Kandidat",
                    Program = "Arkelogi",
                    Description = "",
                    CvId = 3
                },
                new Education
                {
                    Id = 23,
                    StartDate = new DateTime(2018, 9, 15),
                    Location = "Lund Universitet",
                    City = "Lund",
                    Level = "Master",
                    Program = "Miljövetenskap",
                    Description = "Specialisering inom hållbar utveckling",
                    CvId = 4
                },
                new Education
                {
                    Id = 24,
                    StartDate = new DateTime(2021, 1, 10),
                    Location = "Chalmers Tekniska Högskola",
                    City = "Göteborg",
                    Level = "Master",
                    Program = "Maskinteknik",
                    Description = "Fokus på produktutveckling",
                    CvId = 5
                },
                new Education
                {
                    Id = 25,
                    StartDate = new DateTime(2015, 8, 25),
                    Location = "Göteborg Universitet",
                    City = "Göteborg",
                    Level = "Kandidat",
                    Program = "Kulturvetenskap",
                    Description = "Med inriktning på etnologi",
                    CvId = 6
                },
                new Education
                {
                    Id = 26,
                    StartDate = new DateTime(2020, 3, 1),
                    Location = "KTH Royal Institute of Technology",
                    City = "Stockholm",
                    Level = "Master",
                    Program = "Datavetenskap",
                    Description = "Med fokus på artificiell intelligens",
                    CvId = 7
                },
                new Education
                {
                    Id = 27,
                    StartDate = new DateTime(2017, 5, 20),
                    Location = "Stockholms Universitet",
                    City = "Stockholm",
                    Level = "Kandidat",
                    Program = "Ekonomi",
                    Description = "Specialisering inom internationell handel",
                    CvId = 8
                },
                new Education
                {
                    Id = 28,
                    StartDate = new DateTime(2019, 8, 15),
                    Location = "Umeå Universitet",
                    City = "Umeå",
                    Level = "Kandidat",
                    Program = "Biologi",
                    Description = "Studier inom ekologi och naturvård",
                    CvId = 9
                },
                new Education
                {
                    Id = 29,
                    StartDate = new DateTime(2023, 1, 5),
                    Location = "Linköping Universitet",
                    City = "Linköping",
                    Level = "Doktorand",
                    Program = "Teknisk fysik",
                    Description = "Forskning inom kvantmekanik",
                    CvId = 10
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
                    CreatorId = 1.ToString()
                },
                new Project
                {
                    Id = 2,
                    StartDate = new DateTime(2012, 1, 15),
                    EndDate = new DateTime(2015, 3, 10),
                    Title = "SJ Bokningssystem",
                    Description = "Ett bokningssystem för SJ-resor.",
                    CreatorId = 3.ToString()
                },
                new Project
                {
                    Id = 3,
                    StartDate = new DateTime(2015, 6, 1),
                    EndDate = new DateTime(2016, 6, 1),
                    Title = "Miljödatabas",
                    Description = "En databas för miljöövervakning och analys.",
                    CreatorId = 2.ToString()
                },
                new Project
                {
                    Id = 4,
                    StartDate = new DateTime(2018, 4, 20),
                    EndDate = new DateTime(2019, 12, 15),
                    Title = "Eventplaneringssystem",
                    Description = "Ett verktyg för att planera och hantera evenemang.",
                    CreatorId = 4.ToString()
                },
                new Project
                {
                    Id = 5,
                    StartDate = new DateTime(2020, 2, 10),
                    EndDate = new DateTime(2021, 8, 30),
                    Title = "AI-driven chatbot",
                    Description = "En AI-baserad chatbot för kundsupport.",
                    CreatorId = 7.ToString()
                },
                new Project
                {
                    Id = 6,
                    StartDate = new DateTime(2019, 9, 5),
                    EndDate = new DateTime(2020, 12, 31),
                    Title = "Virtuell assistent",
                    Description = "En app för att organisera och schemalägga uppgifter.",
                    CreatorId = 5.ToString()
                },
                new Project
                {
                    Id = 7,
                    StartDate = new DateTime(2021, 3, 15),
                    EndDate = new DateTime(2022, 1, 10),
                    Title = "Biomedicinsk analys",
                    Description = "Ett system för analys av biomedicinska data.",
                    CreatorId = 6.ToString()
                },
                new Project
                {
                    Id = 8,
                    StartDate = new DateTime(2022, 5, 10),
                    EndDate = new DateTime(2023, 4, 20),
                    Title = "E-handelsplattform",
                    Description = "En plattform för att hantera och driva e-handel.",
                    CreatorId = 8.ToString()
                },
                new Project
                {
                    Id = 9,
                    StartDate = new DateTime(2023, 2, 1),
                    EndDate = new DateTime(2024, 1, 15),
                    Title = "Avancerat skattesystem",
                    Description = "Ett skattesystem med automatiserad rapportering.",
                    CreatorId = 9.ToString()
                },
                new Project
                {
                    Id = 10,
                    StartDate = new DateTime(2020, 6, 15),
                    EndDate = new DateTime(2021, 5, 10),
                    Title = "Telemedicinplattform",
                    Description = "En lösning för fjärrmedicinska konsultationer.",
                    CreatorId = 10.ToString()
                }
            );

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Creator)
                .WithMany(u => u.CreatedProjects)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Participants)
                .WithMany(u => u.JoinedProjects)
                .UsingEntity(
                    "ProjectUser",
                    l => l.HasOne(typeof(Project)).WithMany().HasForeignKey("JoinedProjectsId").HasPrincipalKey(nameof(Project.Id)).OnDelete(DeleteBehavior.ClientSetNull),
                    r => r.HasOne(typeof(User)).WithMany().HasForeignKey("ParticipantsId").HasPrincipalKey(nameof(User.Id)).OnDelete(DeleteBehavior.ClientSetNull),
                    j => j.HasKey("JoinedProjectsId", "ParticipantsId")
                );

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(s => s.SentMessages)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(r => r.RecievedMessages)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.Owner)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientNoAction);

            /*
            modelBuilder.Entity<CV>()
              .HasMany(cv => cv.Experiences)
              .WithMany(exp => exp.CVs)
              .UsingEntity(
                  "CVExperience",
                  l => l.HasOne(typeof(Experience)).WithMany().HasForeignKey("ExperienceId").HasPrincipalKey(nameof(Experience.Id)).OnDelete(DeleteBehavior.Restrict),
                  r => r.HasOne(typeof(CV)).WithMany().HasForeignKey("CVsId").HasPrincipalKey(nameof(CV.Id)).OnDelete(DeleteBehavior.Restrict),
                  j => j.HasKey("ExperienceId", "CVsId")
              );*/

            modelBuilder.Entity<Experience>()
                .HasOne(ex => ex.Cv)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<Tag>()
                .HasMany(t => t.Users)
                .WithMany(u => u.Tags)
                .UsingEntity(
                    "TagUser",
                    l => l.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagsId").HasPrincipalKey(nameof(Tag.Id)).OnDelete(DeleteBehavior.ClientSetNull),
                    r => r.HasOne(typeof(User)).WithMany().HasForeignKey("UsersId").HasPrincipalKey(nameof(User.Id)).OnDelete(DeleteBehavior.ClientSetNull),
                    j => j.HasKey("TagsId", "UsersId")
                );
        }
    }
}
