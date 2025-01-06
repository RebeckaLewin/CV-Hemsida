﻿// <auto-generated />
using System;
using CV_Projekt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CV_Projekt.Migrations
{
    [DbContext(typeof(CvContext))]
    partial class CvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CVExperience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("CVsId")
                        .HasColumnType("int");

                    b.HasKey("ExperienceId", "CVsId");

                    b.HasIndex("CVsId");

                    b.ToTable("CVExperience");

                    b.HasData(
                        new
                        {
                            ExperienceId = 1,
                            CVsId = 1
                        },
                        new
                        {
                            ExperienceId = 2,
                            CVsId = 1
                        },
                        new
                        {
                            ExperienceId = 3,
                            CVsId = 2
                        });
                });

            modelBuilder.Entity("CVProject", b =>
                {
                    b.Property<int>("CVsId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("CVsId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("CVProject");

                    b.HasData(
                        new
                        {
                            CVsId = 2,
                            ProjectsId = 1
                        },
                        new
                        {
                            CVsId = 2,
                            ProjectsId = 2
                        });
                });

            modelBuilder.Entity("CVTag", b =>
                {
                    b.Property<int>("CVsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("CVsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("CVTag");

                    b.HasData(
                        new
                        {
                            CVsId = 1,
                            TagsId = 2
                        },
                        new
                        {
                            CVsId = 1,
                            TagsId = 3
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.CV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("CVs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OwnerId = 1,
                            Skills = "[\"Projektledning\",\"CSS\",\"HTML\"]",
                            Views = 10
                        },
                        new
                        {
                            Id = 2,
                            OwnerId = 3,
                            Skills = "[\"Grafisk design\",\"Pedagogik\"]",
                            Views = 11
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.ContactInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactInformations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rullgatan 24A",
                            Email = "alicean12@live.se",
                            Phone = "0723892311"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Johanneslunden 7",
                            Email = "bobbergstrom@gmail.com",
                            Phone = "0724873928"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kolagränd 23",
                            Email = "charliec@live.se",
                            Phone = "0809483729"
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Experiences");

                    b.HasDiscriminator().HasValue("Experience");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CV_Projekt.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecieverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecieverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Hej på dig! Hur är det med dig?",
                            Date = new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecieverId = 2,
                            SenderId = 1,
                            Subject = "En hälsning"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Missade att du skrev, förlåt.",
                            Date = new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecieverId = 1,
                            SenderId = 2,
                            Subject = "Missade"
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorId = 1,
                            Description = "En app för att optimera postleveranser.",
                            EndDate = new DateTime(2011, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2010, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tidtabell för postnord"
                        },
                        new
                        {
                            Id = 2,
                            CreatorId = 3,
                            Description = "Ett bokningssystem för SJ-resor.",
                            EndDate = new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2012, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "SJ Bokningssystem"
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descriptor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descriptor = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Descriptor = "Medicin"
                        },
                        new
                        {
                            Id = 3,
                            Descriptor = "Omvårdnad"
                        },
                        new
                        {
                            Id = 4,
                            Descriptor = "Transport"
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InformationId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("InformationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c35b3a3b-798d-4ab0-a8b2-04a4e2a17668",
                            EmailConfirmed = false,
                            FirstName = "Alice",
                            InformationId = 1,
                            LastName = "Andersson",
                            LockoutEnabled = false,
                            Password = "P@ssword123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "853a6e54-d925-474f-bfef-826cdea220eb",
                            TwoFactorEnabled = false,
                            isActive = true,
                            isPrivate = true
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aaf4d9dd-f8c9-47cd-aaa4-ef166fe50445",
                            EmailConfirmed = false,
                            FirstName = "Bob",
                            InformationId = 2,
                            LastName = "Bergström",
                            LockoutEnabled = false,
                            Password = "P@ssword456",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8560ae85-afa1-405d-be4e-a8920432fda8",
                            TwoFactorEnabled = false,
                            isActive = true,
                            isPrivate = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b5ecf82-c0ac-40c8-9827-b3b22071ba42",
                            EmailConfirmed = false,
                            FirstName = "Charlie",
                            InformationId = 3,
                            LastName = "Carlsson",
                            LockoutEnabled = false,
                            Password = "P@ssword789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3eee5977-1960-41b5-8f6a-d0b78c13e600",
                            TwoFactorEnabled = false,
                            isActive = false,
                            isPrivate = false
                        });
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("JoinedProjectsId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantsId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("JoinedProjectsId");

                    b.HasIndex("ParticipantsId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("CV_Projekt.Models.Education", b =>
                {
                    b.HasBaseType("CV_Projekt.Models.Experience");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Education");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            Description = "",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Karolinska Gymnasiet",
                            StartDate = new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2,
                            Level = "Gymnasial",
                            Program = "Vård och omsorg"
                        },
                        new
                        {
                            Id = 8,
                            Description = "",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Uppsala Universitet",
                            StartDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3,
                            Level = "Kandidat",
                            Program = "Arkelogi"
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.OtherExperience", b =>
                {
                    b.HasBaseType("CV_Projekt.Models.Experience");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("OtherExperience");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Örebro kommun",
                            StartDate = new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2,
                            Type = "Praktik"
                        },
                        new
                        {
                            Id = 2,
                            Description = "En kurs i drejeri",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Kävesta Folkhögskola",
                            StartDate = new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Type = "Kurs"
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Röda korset Örebro",
                            StartDate = new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Type = "Volentärarbete"
                        });
                });

            modelBuilder.Entity("CV_Projekt.Models.Work", b =>
                {
                    b.HasBaseType("CV_Projekt.Models.Experience");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Work");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Description = "Underhåller ett team i bageri/ungdomsgård",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Café Deed",
                            StartDate = new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Role = "Arbetsledare"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Omvårdnad",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Uppsala Sjukhus",
                            StartDate = new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2,
                            Role = "Sjuksköterska"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Arbetsuppgifter",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Generiskt Företag",
                            StartDate = new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3,
                            Role = "Arbetstitel"
                        });
                });

            modelBuilder.Entity("CVExperience", b =>
                {
                    b.HasOne("CV_Projekt.Models.CV", null)
                        .WithMany()
                        .HasForeignKey("CVsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.Experience", null)
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CVProject", b =>
                {
                    b.HasOne("CV_Projekt.Models.CV", null)
                        .WithMany()
                        .HasForeignKey("CVsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CVTag", b =>
                {
                    b.HasOne("CV_Projekt.Models.CV", null)
                        .WithMany()
                        .HasForeignKey("CVsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_Projekt.Models.CV", b =>
                {
                    b.HasOne("CV_Projekt.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CV_Projekt.Models.Experience", b =>
                {
                    b.HasOne("CV_Projekt.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CV_Projekt.Models.Message", b =>
                {
                    b.HasOne("CV_Projekt.Models.User", "Reciever")
                        .WithMany("RecievedMessages")
                        .HasForeignKey("RecieverId")
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.User", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .IsRequired();

                    b.Navigation("Reciever");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("CV_Projekt.Models.Project", b =>
                {
                    b.HasOne("CV_Projekt.Models.User", "Creator")
                        .WithMany("CreatedProjects")
                        .HasForeignKey("CreatorId")
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("CV_Projekt.Models.User", b =>
                {
                    b.HasOne("CV_Projekt.Models.ContactInformation", "ContactInformation")
                        .WithMany()
                        .HasForeignKey("InformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContactInformation");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("CV_Projekt.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("JoinedProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("ParticipantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .IsRequired();

                    b.HasOne("CV_Projekt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired();
                });

            modelBuilder.Entity("CV_Projekt.Models.User", b =>
                {
                    b.Navigation("CreatedProjects");

                    b.Navigation("RecievedMessages");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
