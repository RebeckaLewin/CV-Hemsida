using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class Setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descriptor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPrivate = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ContactInformations_InformationId",
                        column: x => x.InformationId,
                        principalTable: "ContactInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    RecieverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Users_RecieverId",
                        column: x => x.RecieverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVTag",
                columns: table => new
                {
                    CVsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVTag", x => new { x.CVsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_CVTag_CVs_CVsId",
                        column: x => x.CVsId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CVTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CVExperience",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false),
                    CVsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVExperience", x => new { x.ExperienceId, x.CVsId });
                    table.ForeignKey(
                        name: "FK_CVExperience_CVs_CVsId",
                        column: x => x.CVsId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CVExperience_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CVProject",
                columns: table => new
                {
                    CVsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVProject", x => new { x.CVsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_CVProject_CVs_CVsId",
                        column: x => x.CVsId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CVProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ContactInformations",
                columns: new[] { "Id", "Address", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Rullgatan 24A", "alicean12@live.se", "0723892311" },
                    { 2, "Johanneslunden 7", "bobbergstrom@gmail.com", "0724873928" },
                    { 3, "Kolagränd 23", "charliec@live.se", "0809483729" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Descriptor" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Medicin" },
                    { 3, "Omvårdnad" },
                    { 4, "Transport" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "InformationId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isActive", "isPrivate" },
                values: new object[,]
                {
                    { 1, 0, "6ead067d-d776-4e19-a5d9-6ab721cef856", null, false, "Alice", 1, "Andersson", false, null, null, null, "P@ssword123", null, null, false, "71883185-2a3a-4e87-9b46-dfe6965e6041", false, null, true, true },
                    { 2, 0, "654f41cf-7278-4e18-b235-b4c9bd2942a0", null, false, "Bob", 2, "Bergström", false, null, null, null, "P@ssword456", null, null, false, "207064f6-b515-4163-b294-290566c1a627", false, null, true, false },
                    { 3, 0, "9f4a0a84-613c-43a8-8782-1ffa70317778", null, false, "Charlie", 3, "Carlsson", false, null, null, null, "P@ssword789", null, null, false, "a15d4eca-4113-4a31-a375-315ccda89e3c", false, null, false, false }
                });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "Id", "OwnerId", "Skills", "Views" },
                values: new object[,]
                {
                    { 1, 1, "[\"Projektledning\",\"CSS\",\"HTML\"]", 10 },
                    { 2, 3, "[\"Grafisk design\",\"Pedagogik\"]", 11 }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Discriminator", "EndDate", "Location", "StartDate", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, null, "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro kommun", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik", 2 },
                    { 2, "En kurs i drejeri", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kävesta Folkhögskola", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs", 1 },
                    { 3, null, "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Röda korset Örebro", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete", 1 }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Discriminator", "EndDate", "Location", "Role", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 4, "Underhåller ett team i bageri/ungdomsgård", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Café Deed", "Arbetsledare", new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Omvårdnad", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uppsala Sjukhus", "Sjuksköterska", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, "Arbetsuppgifter", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generiskt Företag", "Arbetstitel", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Discriminator", "EndDate", "Level", "Location", "Program", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 7, "", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gymnasial", "Karolinska Gymnasiet", "Vård och omsorg", new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, "", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Uppsala Universitet", "Arkelogi", new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "Date", "RecieverId", "SenderId", "Subject" },
                values: new object[,]
                {
                    { 1, "Hej på dig! Hur är det med dig?", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "En hälsning" },
                    { 2, "Missade att du skrev, förlåt.", new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "Missade" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatorId", "Description", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "En app för att optimera postleveranser.", new DateTime(2011, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tidtabell för postnord" },
                    { 2, 3, "Ett bokningssystem för SJ-resor.", new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SJ Bokningssystem" }
                });

            migrationBuilder.InsertData(
                table: "CVExperience",
                columns: new[] { "CVsId", "ExperienceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "CVProject",
                columns: new[] { "CVsId", "ProjectsId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CVTag",
                columns: new[] { "CVsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CVExperience_CVsId",
                table: "CVExperience",
                column: "CVsId");

            migrationBuilder.CreateIndex(
                name: "IX_CVProject_ProjectsId",
                table: "CVProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_OwnerId",
                table: "CVs",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CVTag_TagsId",
                table: "CVTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_RecieverId",
                table: "Message",
                column: "RecieverId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatorId",
                table: "Projects",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_InformationId",
                table: "Users",
                column: "InformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CVExperience");

            migrationBuilder.DropTable(
                name: "CVProject");

            migrationBuilder.DropTable(
                name: "CVTag");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ContactInformations");
        }
    }
}
