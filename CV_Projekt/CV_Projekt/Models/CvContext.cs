using Microsoft.EntityFrameworkCore;
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
                },
                new ContactInformation
                {
                    Id = 11,
                    Phone = "0739172638",
                    Address = "Hasselvägen 3"
                },
                new ContactInformation
                {
                    Id = 12,
                    Phone = "0708237461",
                    Address = "Björkstigen 7B"
                },
                new ContactInformation
                {
                    Id = 13,
                    Phone = "0763498271",
                    Address = "Lönnvägen 12A"
                },
                new ContactInformation
                {
                    Id = 14,
                    Phone = "0723948576",
                    Address = "Ekliden 9"
                },
                new ContactInformation
                {
                    Id = 15,
                    Phone = "0732847562",
                    Address = "Grönbacken 2"
                },
                new ContactInformation
                {
                    Id = 16,
                    Phone = "0702348967",
                    Address = "Furugatan 6C"
                },
                new ContactInformation
                {
                    Id = 17,
                    Phone = "0761239487",
                    Address = "Granliden 11"
                },
                new ContactInformation
                {
                    Id = 18,
                    Phone = "0739871236",
                    Address = "Tallstigen 5A"
                },
                new ContactInformation
                {
                    Id = 19,
                    Phone = "0709283745",
                    Address = "Aspvägen 18B"
                },
                new ContactInformation
                {
                    Id = 20,
                    Phone = "0768742390",
                    Address = "Rönnvägen 1"
                }
            );

            List<User> newUsers = [new User
                {
                    Id = 1.ToString(),
                    FirstName = "Alice",
                    LastName = "Andersson",
                    Description = "En noggrann och kreativ grafisk designer med ett öga för detaljer.",
                    PictureUrl = "~/images/Alice.jpg",
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
                    Description = "En erfaren systemutvecklare som brinner för innovativa lösningar.",
                    PictureUrl = "~/images/bob.jpg",
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
                    Description = "En entusiastisk frontend-utvecklare som älskar att skapa användarvänliga gränssnitt.",
                    PictureUrl = "~/images/Charlie.jpg",
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
                    Description = "En passionerad IT-projektledare med fokus på samarbete och kvalitet.",
                    PictureUrl = "~/images/Daniel.jpg",
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
                    Description = "En social media-expert med erfarenhet av kampanjer och strategier.",
                    PictureUrl = "~/images/Emily.jpg",
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
                    Description = "En datasäkerhetsspecialist med djup kunskap inom kryptering och skydd.",
                    PictureUrl = "~/images/Frank.jpg",
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
                    Description = "En UI/UX-designer som strävar efter att skapa engagerande upplevelser.",
                    PictureUrl = "~/images/Grace.jpg",
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
                     Description = "En datavetare med specialisering inom artificiell intelligens och maskininlärning.",
                     PictureUrl = "~/images/Hanna.jpg",
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
                    Description = "En engagerad produktägare som fokuserar på att möta kundernas behov.",
                    PictureUrl = "~/images/Ian.jpg",
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
                    Description = "En entreprenör med erfarenhet av e-handel och kundservice.",
                    PictureUrl = "~/images/Julia.jpg",
                    UserName = "julia.jonsson@yahoo.com",
                    Email = "julia.jonsson@yahoo.com",
					InformationId = 10,
                    Password = "JuliasP@ss7",
                    isPrivate = true,
                    isActive = false,
                },
                new User
                {
                    Id = 11.ToString(),
                    FirstName = "Karl",
                    LastName = "Karlsson",
                    Description = "En erfaren utvecklare med passion för backend-programmering.",
                    PictureUrl = "~/images/Karl.jpg",
                    UserName = "karl.karlsson@gmail.com",
                    Email = "karl.karlsson@gmail.com",
                    InformationId = 11,
                    Password = "K@rlsP@ss1",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 12.ToString(),
                    FirstName = "Linda",
                    LastName = "Lindström",
                    Description = "En kreativ designer som älskar att skapa användarvänliga gränssnitt.",
                    PictureUrl = "~/images/Linda.jpg",
                    UserName = "linda.lindstrom@live.se",
                    Email = "linda.lindstrom@live.se",
                    InformationId = 12,
                    Password = "Lind@P@ss2",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 13.ToString(),
                    FirstName = "Martin",
                    LastName = "Magnusson",
                    Description = "En dataanalytiker med erfarenhet av stora datamängder.",
                    PictureUrl = "~/images/Martin.jpg",
                    UserName = "martin.magnusson@outlook.com",
                    Email = "martin.magnusson@outlook.com",
                    InformationId = 13,
                    Password = "M@rtinP@ss3",
                    isPrivate = true,
                    isActive = false,
                },
                new User
                {
                    Id = 14.ToString(),
                    FirstName = "Nina",
                    LastName = "Nilsson",
                    Description = "En driven projektledare med fokus på effektivitet och teamarbete.",
                    PictureUrl = "~/images/Nina.jpg",
                    UserName = "nina.nilsson@hotmail.com",
                    Email = "nina.nilsson@hotmail.com",
                    InformationId = 14,
                    Password = "Nin@P@ss4",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 15.ToString(),
                    FirstName = "Oscar",
                    LastName = "Olsson",
                    Description = "En systemarkitekt med över 10 års erfarenhet i branschen.",
                    PictureUrl = "~/images/Oscar.jpg",
                    UserName = "oscar.olsson@gmail.com",
                    Email = "oscar.olsson@gmail.com",
                    InformationId = 15,
                    Password = "Osc@rsP@ss5",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 16.ToString(),
                    FirstName = "Petra",
                    LastName = "Persson",
                    Description = "En engagerad tester som brinner för att hitta och lösa buggar.",
                    PictureUrl = "~/images/Petra.jpg",
                    UserName = "petra.persson@yahoo.com",
                    Email = "petra.persson@yahoo.com",
                    InformationId = 16,
                    Password = "Petr@sP@ss6",
                    isPrivate = false,
                    isActive = false,
                },
                new User
                {
                    Id = 17.ToString(),
                    FirstName = "Quentin",
                    LastName = "Quist",
                    Description = "En teknisk skribent som gör komplexa idéer lättförståeliga.",
                    PictureUrl = "~/images/Quentin.jpg",
                    UserName = "quentin.quist@live.se",
                    Email = "quentin.quist@live.se",
                    InformationId = 17,
                    Password = "Qu@ntinsP@ss7",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 18.ToString(),
                    FirstName = "Rebecca",
                    LastName = "Rudolfsson",
                    Description = "En marknadsföringsspecialist med fokus på digitala strategier.",
                    PictureUrl = "~/images/Rebecca.jpg",
                    UserName = "rebecca.rudolfsson@outlook.com",
                    Email = "rebecca.rudolfsson@outlook.com",
                    InformationId = 18,
                    Password = "Rebecc@sP@ss8",
                    isPrivate = false,
                    isActive = true,
                },
                new User
                {
                    Id = 19.ToString(),
                    FirstName = "Stefan",
                    LastName = "Sundberg",
                    Description = "En agil coach som hjälper team att nå sin fulla potential.",
                    PictureUrl = "~/images/Stefan.jpg",
                    UserName = "stefan.sundberg@gmail.com",
                    Email = "stefan.sundberg@gmail.com",
                    InformationId = 19,
                    Password = "Stef@nsP@ss9",
                    isPrivate = true,
                    isActive = true,
                },
                new User
                {
                    Id = 20.ToString(),
                    FirstName = "Therese",
                    LastName = "Törnqvist",
                    Description = "En front-end-utvecklare med öga för detaljer och design.",
                    PictureUrl = "~/images/Therese.jpg",
                    UserName = "therese.tornqvist@hotmail.com",
                    Email = "therese.tornqvist@hotmail.com",
                    InformationId = 20,
                    Password = "Theres@sP@ss10",
                    isPrivate = false,
                    isActive = false,
                }];

			var hasher = new PasswordHasher<User>();
			foreach (var user in newUsers)
			{
				user.PasswordHash = hasher.HashPassword(user, user.Password);
                user.NormalizedEmail = user.Email.Normalize();
                user.NormalizedUserName = user.UserName.Normalize();
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
			   newUsers[9],
               newUsers[10],
               newUsers[11],
               newUsers[12],
               newUsers[13],
               newUsers[14],
               newUsers[15],
               newUsers[16],
               newUsers[17],
               newUsers[18],
               newUsers[19]
            );

			modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    Id = 1,
                    Content = "Hej på dig! Hur är det med dig?",
                    SenderName = "",
                    Date = new DateTime(2020, 6, 12),
                    SenderId = 1.ToString(),
                    ReceiverId = 2.ToString()
                },
                new Message
                {
                    Id = 2,
                    Content = "Missade att du skrev, förlåt.",
					SenderName = "",
					Date = new DateTime(2020, 7, 16),
                    SenderId = 2.ToString(),
                    ReceiverId = 1.ToString()
                },
                new Message
                {
                    Id = 3,
                    Content = "Ska vi ta en lunch imorgon?",
					SenderName = "",
					Date = new DateTime(2020, 8, 1),
                    SenderId = 3.ToString(),
                    ReceiverId = 1.ToString()
                },
                new Message
                {
                    Id = 4,
                    Content = "Tack för att du hjälpte mig med projektet.",
					SenderName = "",
					Date = new DateTime(2020, 8, 15),
                    SenderId = 1.ToString(),
                    ReceiverId = 3.ToString()
                },
                new Message
                {
                    Id = 5,
                    Content = "Kan du kika på dokumentet jag skickade?",
					SenderName = "",
					Date = new DateTime(2020, 9, 10),
                    SenderId = 4.ToString(),
                    ReceiverId = 5.ToString()
                },
                new Message
                {
                    Id = 6,
                    Content = "Jag har lagt till några kommentarer i ditt utkast.",
					SenderName = "",
					Date = new DateTime(2020, 9, 15),
                    SenderId = 5.ToString(),
                    ReceiverId = 4.ToString()
                },
                new Message
                {
                    Id = 7,
                    Content = "Glöm inte mötet imorgon kl. 10.",
					SenderName = "",
					Date = new DateTime(2020, 10, 1),
                    SenderId = 6.ToString(),
                    ReceiverId = 7.ToString()
                },
                new Message
                {
                    Id = 8,
                    Content = "Har du hunnit förbereda presentationen?",
					SenderName = "",
					Date = new DateTime(2020, 10, 20),
                    SenderId = 7.ToString(),
                    ReceiverId = 6.ToString()
                },
                new Message
                {
                    Id = 9,
                    Content = "Grattis på födelsedagen!",
					SenderName = "",
					Date = new DateTime(2020, 11, 3),
                    SenderId = 8.ToString(),
                    ReceiverId = 9.ToString()
                },
                new Message
                {
                    Id = 10,
                    Content = "Ha en trevlig helg! Vi hörs på måndag.",
					SenderName = "",
					Date = new DateTime(2020, 11, 6),
                    SenderId = 9.ToString(),
                    ReceiverId = 10.ToString()
                },
                new Message
                {
                    Id = 11,
                    Content = "Hur gick mötet idag?",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 8),
                    SenderId = 10.ToString(),
                    ReceiverId = 1.ToString()
                },
                new Message
                {
                    Id = 12,
                    Content = "Jag har skickat filerna du bad om.",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 12),
                    SenderId = 2.ToString(),
                    ReceiverId = 3.ToString()
                },
                new Message
                {
                    Id = 13,
                    Content = "Kan vi skjuta upp vårt möte till nästa vecka?",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 14),
                    SenderId = 3.ToString(),
                    ReceiverId = 4.ToString()
                },
                new Message
                {
                    Id = 14,
                    Content = "Tack för inbjudan, jag kommer gärna!",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 18),
                    SenderId = 5.ToString(),
                    ReceiverId = 6.ToString()
                },
                new Message
                {
                    Id = 15,
                    Content = "Jag behöver hjälp med en uppgift, kan vi prata senare?",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 20),
                    SenderId = 6.ToString(),
                    ReceiverId = 7.ToString()
                },
                new Message
                {
                    Id = 16,
                    Content = "Glöm inte att skicka in rapporten innan deadline.",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 22),
                    SenderId = 7.ToString(),
                    ReceiverId = 8.ToString()
                },
                new Message
                {
                    Id = 17,
                    Content = "Det låter bra, vi ses på tisdag!",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 25),
                    SenderId = 8.ToString(),
                    ReceiverId = 9.ToString()
                },
                new Message
                {
                    Id = 18,
                    Content = "Kan du dubbelkolla schemat för mig?",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 27),
                    SenderId = 9.ToString(),
                    ReceiverId = 10.ToString()
                },
                new Message
                {
                    Id = 19,
                    Content = "Jag behöver feedback på min idé, kan du hjälpa till?",
                    SenderName = "",
                    Date = new DateTime(2020, 11, 30),
                    SenderId = 10.ToString(),
                    ReceiverId = 1.ToString()
                },
                new Message
                {
                    Id = 20,
                    Content = "Vi måste gå igenom projektplanen snart.",
                    SenderName = "",
                    Date = new DateTime(2020, 12, 2),
                    SenderId = 1.ToString(),
                    ReceiverId = 2.ToString()
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
				},
                new CV
                {
                    Id = 11,
                    OwnerId = 11.ToString(),
                    Skills = new List<string> { "Webbutveckling", "JavaScript", "React" },
                    Views = 17
                },
                new CV
                {
                    Id = 12,
                    OwnerId = 12.ToString(),
                    Skills = new List<string> { "Marknadsföring", "SEO", "Digital strategi" },
                    Views = 13
                },
                new CV
                {
                    Id = 13,
                    OwnerId = 13.ToString(),
                    Skills = new List<string> { "Databashantering", "SQL", "NoSQL" },
                    Views = 22
                },
                new CV
                {
                    Id = 14,
                    OwnerId = 14.ToString(),
                    Skills = new List<string> { "Skrivande", "Teknisk dokumentation" },
                    Views = 10
                },
                new CV
                {
                    Id = 15,
                    OwnerId = 15.ToString(),
                    Skills = new List<string> { "Agil projektledning", "Scrum", "Kanban" },
                    Views = 19
                },
                new CV
                {
                    Id = 16,
                    OwnerId = 16.ToString(),
                    Skills = new List<string> { "Fotografi", "Bildredigering", "Adobe Photoshop" },
                    Views = 16
                },
                new CV
                {
                    Id = 17,
                    OwnerId = 17.ToString(),
                    Skills = new List<string> { "Affärsutveckling", "Försäljning", "Ekonomi" },
                    Views = 21
                },
                new CV
                {
                    Id = 18,
                    OwnerId = 18.ToString(),
                    Skills = new List<string> { "Mjukvarutestning", "Automatisering", "QA" },
                    Views = 14
                },
                new CV
                {
                    Id = 19,
                    OwnerId = 19.ToString(),
                    Skills = new List<string> { "Grafikprogrammering", "C#", "Unity" },
                    Views = 23
                },
                new CV
                {
                    Id = 20,
                    OwnerId = 20.ToString(),
                    Skills = new List<string> { "Dataanalys", "Python", "R" },
                    Views = 26
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
                },
                new OtherExperience
                {
                    Id = 11,
                    StartDate = new DateTime(2017, 4, 1),
                    EndDate = new DateTime(2018, 3, 31),
                    Location = "Stockholm Stad",
                    City = "Stockholm",
                    Description = "Praktik inom stadsplanering",
                    Type = "Praktik",
                    CvId = 10
                },
                new OtherExperience
                {
                    Id = 12,
                    StartDate = new DateTime(2021, 9, 1),
                    Location = "Lunds Universitet",
                    City = "Lund",
                    Description = "Deltog i en kurs om klimatförändringar",
                    Type = "Kurs",
                    CvId = 9
                },
                new OtherExperience
                {
                    Id = 13,
                    StartDate = new DateTime(2019, 6, 1),
                    EndDate = new DateTime(2019, 8, 30),
                    Location = "Volvo Cars",
                    City = "Göteborg",
                    Description = "Sommarjobb inom bilindustrin",
                    Type = "Sommarjobb",
                    CvId = 8
                },
                new OtherExperience
                {
                    Id = 14,
                    StartDate = new DateTime(2022, 1, 15),
                    Location = "KTH Royal Institute of Technology",
                    City = "Stockholm",
                    Description = "Projektarbete inom robotteknik",
                    Type = "Projektarbete",
                    CvId = 7
                },
                new OtherExperience
                {
                    Id = 15,
                    StartDate = new DateTime(2020, 3, 10),
                    EndDate = new DateTime(2020, 5, 30),
                    Location = "SIDA",
                    City = "Uppsala",
                    Description = "Volontärarbete med internationellt bistånd",
                    Type = "Volentärarbete",
                    CvId = 6
                },
                new OtherExperience
                {
                    Id = 16,
                    StartDate = new DateTime(2018, 11, 5),
                    Location = "Göteborgs Universitet",
                    City = "Göteborg",
                    Description = "Workshop om hållbar utveckling",
                    Type = "Workshop",
                    CvId = 5
                },
                new OtherExperience
                {
                    Id = 17,
                    StartDate = new DateTime(2021, 4, 20),
                    Location = "Umeå Universitet",
                    City = "Umeå",
                    Description = "Deltog i en forskningskonferens",
                    Type = "Konferens",
                    CvId = 4
                },
                new OtherExperience
                {
                    Id = 18,
                    StartDate = new DateTime(2023, 6, 10),
                    Location = "Karolinska Institutet",
                    City = "Stockholm",
                    Description = "Kurs i avancerad medicinsk forskning",
                    Type = "Kurs",
                    CvId = 3
                },
                new OtherExperience
                {
                    Id = 19,
                    StartDate = new DateTime(2022, 9, 1),
                    Location = "Chalmers Tekniska Högskola",
                    City = "Göteborg",
                    Description = "Projekt om hållbar energiteknik",
                    Type = "Projektarbete",
                    CvId = 2
                },
                new OtherExperience
                {
                    Id = 20,
                    StartDate = new DateTime(2016, 7, 1),
                    EndDate = new DateTime(2017, 6, 30),
                    Location = "Skanska AB",
                    City = "Malmö",
                    Description = "Praktik inom byggteknik",
                    Type = "Praktik",
                    CvId = 1
                }
            );

            modelBuilder.Entity<Work>().HasData(
                new Work
                {
                    Id = 21,
                    StartDate = new DateTime(2020, 6, 29),
                    Location = "Café Deed",
                    City = "Örebro",
                    Description = "Underhåller ett team i bageri/ungdomsgård",
                    Role = "Arbetsledare",
                    CvId = 1
                },
                new Work
                {
                    Id = 22,
                    StartDate = new DateTime(2019, 8, 30),
                    Location = "Uppsala Sjukhus",
                    City = "Uppsala",
                    Description = "Omvårdnad",
                    Role = "Sjuksköterska",
                    CvId = 2
                },
                new Work
                {
                    Id = 23,
                    StartDate = new DateTime(2021, 8, 30),
                    Location = "Generiskt Företag",
                    City = "Generisk stad",
                    Description = "Arbetsuppgifter",
                    Role = "Arbetstitel",
                    CvId = 3
                },
                new Work
                {
                    Id = 24,
                    StartDate = new DateTime(2018, 4, 15),
                    Location = "Stockholms Stad",
                    City = "Stockholm",
                    Description = "Ansvarig för eventplanering och samordning",
                    Role = "Eventkoordinator",
                    CvId = 4
                },
                new Work
                {
                    Id = 25,
                    StartDate = new DateTime(2022, 1, 10),
                    Location = "Volvo Cars",
                    City = "Arboga",
                    Description = "Utveckling och testning av nya bilmodeller",
                    Role = "Ingenjör",
                    CvId = 5
                },
                new Work
                {
                    Id = 26,
                    StartDate = new DateTime(2020, 9, 1),
                    Location = "Karolinska Institutet",
                    City = "Stockholm",
                    Description = "Forskning inom biomedicin",
                    Role = "Forskningsassistent",
                    CvId = 6
                },
                new Work
                {
                    Id = 27,
                    StartDate = new DateTime(2023, 3, 20),
                    Location = "Skatteverket",
                    City = "Örebro",
                    Description = "Hantering av deklarationer och rådgivning",
                    Role = "Handläggare",
                    CvId = 7
                },
                new Work
                {
                    Id = 28,
                    StartDate = new DateTime(2019, 6, 5),
                    Location = "Länsstyrelsen",
                    City = "Köping",
                    Description = "Administration och projektstöd",
                    Role = "Projektassistent",
                    CvId = 8
                },
                new Work
                {
                    Id = 29,
                    StartDate = new DateTime(2021, 11, 12),
                    Location = "Luleå Tekniska Universitet",
                    City = "Luleå",
                    Description = "Undervisning och kursutveckling",
                    Role = "Universitetslärare",
                    CvId = 9
                },
                new Work
                {
                    Id = 30,
                    StartDate = new DateTime(2020, 7, 1),
                    Location = "Norrlands Universitetssjukhus",
                    City = "Skellefteå",
                    Description = "Patientvård och ledning av vårdteam",
                    Role = "Läkare",
                    CvId = 10
                },
                new Work
                {
                    Id = 31,
                    StartDate = new DateTime(2017, 5, 15),
                    EndDate = new DateTime(2019, 5, 15),
                    Location = "IKEA",
                    City = "Älmhult",
                    Description = "Ansvarig för produktdesign och konceptutveckling",
                    Role = "Designer",
                    CvId = 1
                },
                new Work
                {
                    Id = 32,
                    StartDate = new DateTime(2022, 9, 1),
                    Location = "Vattenfall AB",
                    City = "Luleå",
                    Description = "Övervakning och optimering av energianläggningar",
                    Role = "Ingenjör",
                    CvId = 2
                },
                new Work
                {
                    Id = 33,
                    StartDate = new DateTime(2020, 1, 15),
                    EndDate = new DateTime(2021, 12, 31),
                    Location = "Svenska Spel",
                    City = "Visby",
                    Description = "Utveckling och underhåll av spelplattformar",
                    Role = "Systemutvecklare",
                    CvId = 3
                },
                new Work
                {
                    Id = 34,
                    StartDate = new DateTime(2018, 8, 1),
                    Location = "Ericsson",
                    City = "Kista",
                    Description = "Projektledning och koordinering av globala team",
                    Role = "Projektledare",
                    CvId = 4
                },
                new Work
                {
                    Id = 35,
                    StartDate = new DateTime(2019, 3, 10),
                    Location = "Tetra Pak",
                    City = "Lund",
                    Description = "Utveckling av förpackningslösningar",
                    Role = "Produktutvecklare",
                    CvId = 5
                },
                new Work
                {
                    Id = 36,
                    StartDate = new DateTime(2021, 6, 1),
                    Location = "Sahlgrenska Universitetssjukhuset",
                    City = "Göteborg",
                    Description = "Forskning och kliniska studier inom genetik",
                    Role = "Forskningskoordinator",
                    CvId = 6
                },
                new Work
                {
                    Id = 37,
                    StartDate = new DateTime(2022, 2, 15),
                    Location = "Skanska AB",
                    City = "Malmö",
                    Description = "Hantering av stora byggprojekt och resursallokering",
                    Role = "Byggprojektledare",
                    CvId = 7
                },
                new Work
                {
                    Id = 38,
                    StartDate = new DateTime(2020, 11, 5),
                    Location = "Länsförsäkringar",
                    City = "Umeå",
                    Description = "Kundsupport och administration av försäkringar",
                    Role = "Försäkringsrådgivare",
                    CvId = 8
                },
                new Work
                {
                    Id = 39,
                    StartDate = new DateTime(2023, 1, 1),
                    Location = "Linköpings Universitet",
                    City = "Linköping",
                    Description = "Forskning och utveckling inom maskininlärning",
                    Role = "Forskare",
                    CvId = 9
                },
                new Work
                {
                    Id = 40,
                    StartDate = new DateTime(2021, 4, 20),
                    Location = "Karolinska Universitetssjukhuset",
                    City = "Stockholm",
                    Description = "Ansvar för kirurgiska ingrepp och patientvård",
                    Role = "Kirurg",
                    CvId = 10
                }
            );

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = 41,
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
                    Id = 42,
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
                    Id = 43,
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
                    Id = 44,
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
                    Id = 45,
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
                    Id = 46,
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
                    Id = 47,
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
                    Id = 48,
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
                    Id = 49,
                    StartDate = new DateTime(2023, 1, 5),
                    Location = "Linköping Universitet",
                    City = "Linköping",
                    Level = "Doktorand",
                    Program = "Teknisk fysik",
                    Description = "Forskning inom kvantmekanik",
                    CvId = 10
                },
                new Education
                {
                    Id = 50,
                    StartDate = new DateTime(2013, 9, 1),
                    Location = "Malmö Universitet",
                    City = "Malmö",
                    Level = "Kandidat",
                    Program = "Medieteknik",
                    Description = "Fokus på digitala medier och webbdesign",
                    CvId = 1
                },
                new Education
                {
                    Id = 51,
                    StartDate = new DateTime(2016, 1, 15),
                    Location = "Uppsala Universitet",
                    City = "Uppsala",
                    Level = "Master",
                    Program = "Matematik",
                    Description = "Specialisering inom tillämpad matematik",
                    CvId = 2
                },
                new Education
                {
                    Id = 52,
                    StartDate = new DateTime(2018, 8, 20),
                    Location = "Stockholms Universitet",
                    City = "Stockholm",
                    Level = "Kandidat",
                    Program = "Statsvetenskap",
                    Description = "Med fokus på politiska system och förvaltning",
                    CvId = 3
                },
                new Education
                {
                    Id = 53,
                    StartDate = new DateTime(2020, 9, 1),
                    Location = "Linnéuniversitetet",
                    City = "Växjö",
                    Level = "Kandidat",
                    Program = "Samhällsplanering",
                    Description = "Studier i urban utveckling och planering",
                    CvId = 4
                },
                new Education
                {
                    Id = 54,
                    StartDate = new DateTime(2019, 1, 10),
                    Location = "Chalmers Tekniska Högskola",
                    City = "Göteborg",
                    Level = "Doktorand",
                    Program = "Maskininlärning",
                    Description = "Forskning inom neurala nätverk",
                    CvId = 5
                },
                new Education
                {
                    Id = 55,
                    StartDate = new DateTime(2021, 2, 25),
                    Location = "Lunds Universitet",
                    City = "Lund",
                    Level = "Master",
                    Program = "Kemi",
                    Description = "Specialisering inom organisk kemi",
                    CvId = 6
                },
                new Education
                {
                    Id = 56,
                    StartDate = new DateTime(2022, 8, 15),
                    Location = "KTH Royal Institute of Technology",
                    City = "Stockholm",
                    Level = "Kandidat",
                    Program = "Elektroteknik",
                    Description = "Fokus på förnybar energi",
                    CvId = 7
                },
                new Education
                {
                    Id = 57,
                    StartDate = new DateTime(2020, 1, 15),
                    Location = "Örebro Universitet",
                    City = "Örebro",
                    Level = "Master",
                    Program = "Kriminologi",
                    Description = "Studier inom brottsanalys och rättspsykologi",
                    CvId = 8
                },
                new Education
                {
                    Id = 58,
                    StartDate = new DateTime(2017, 3, 10),
                    Location = "Umeå Universitet",
                    City = "Umeå",
                    Level = "Kandidat",
                    Program = "Juridik",
                    Description = "Med fokus på affärsjuridik",
                    CvId = 9
                },
                new Education
                {
                    Id = 59,
                    StartDate = new DateTime(2015, 9, 1),
                    Location = "Högskolan i Skövde",
                    City = "Skövde",
                    Level = "Kandidat",
                    Program = "Datavetenskap",
                    Description = "Inriktning på systemutveckling och databashantering",
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
                },
                new Project
                {
                    Id = 11,
                    StartDate = new DateTime(2017, 3, 1),
                    EndDate = new DateTime(2018, 2, 28),
                    Title = "Digitala läromedel",
                    Description = "En plattform för att tillhandahålla digitala läromedel för skolor.",
                    CreatorId = 1.ToString()
                },
                new Project
                {
                    Id = 12,
                    StartDate = new DateTime(2019, 6, 15),
                    EndDate = new DateTime(2020, 3, 1),
                    Title = "CRM-system för småföretag",
                    Description = "Ett användarvänligt CRM-system för små och medelstora företag.",
                    CreatorId = 2.ToString()
                },
                new Project
                {
                    Id = 13,
                    StartDate = new DateTime(2020, 8, 1),
                    EndDate = new DateTime(2021, 7, 31),
                    Title = "Matleveransapp",
                    Description = "En mobilapp för att beställa matleveranser från lokala restauranger.",
                    CreatorId = 3.ToString()
                },
                new Project
                {
                    Id = 14,
                    StartDate = new DateTime(2021, 4, 15),
                    EndDate = new DateTime(2022, 6, 30),
                    Title = "Hälsotracker",
                    Description = "En app som hjälper användare att hålla koll på sin hälsa och träning.",
                    CreatorId = 4.ToString()
                },
                new Project
                {
                    Id = 15,
                    StartDate = new DateTime(2018, 11, 5),
                    EndDate = new DateTime(2020, 1, 20),
                    Title = "Molnbaserad filhantering",
                    Description = "Ett system för säker och effektiv filhantering i molnet.",
                    CreatorId = 5.ToString()
                },
                new Project
                {
                    Id = 16,
                    StartDate = new DateTime(2022, 2, 1),
                    EndDate = new DateTime(2023, 3, 15),
                    Title = "Rekryteringsplattform",
                    Description = "En plattform som förenklar rekryteringsprocessen för företag.",
                    CreatorId = 6.ToString()
                },
                new Project
                {
                    Id = 17,
                    StartDate = new DateTime(2016, 5, 10),
                    EndDate = new DateTime(2017, 4, 15),
                    Title = "Spelutveckling",
                    Description = "Ett indieprojekt för att utveckla ett mobilspel.",
                    CreatorId = 7.ToString()
                },
                new Project
                {
                    Id = 18,
                    StartDate = new DateTime(2023, 5, 20),
                    EndDate = new DateTime(2024, 4, 25),
                    Title = "Utbildningsplattform för fjärrinlärning",
                    Description = "En plattform för onlinekurser och fjärrundervisning.",
                    CreatorId = 8.ToString()
                },
                new Project
                {
                    Id = 19,
                    StartDate = new DateTime(2021, 7, 10),
                    EndDate = new DateTime(2022, 9, 30),
                    Title = "Logistikoptimering",
                    Description = "Ett system för att optimera leveranskedjor och logistik.",
                    CreatorId = 9.ToString()
                },
                new Project
                {
                    Id = 20,
                    StartDate = new DateTime(2019, 10, 1),
                    EndDate = new DateTime(2020, 8, 31),
                    Title = "Automatiserat lagerhanteringssystem",
                    Description = "Ett system för att automatisera lagerhantering och spårning.",
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
