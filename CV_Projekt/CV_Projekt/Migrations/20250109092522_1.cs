using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPrivate = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_ContactInformations_InformationId",
                        column: x => x.InformationId,
                        principalTable: "ContactInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        name: "FK_Experiences_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
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
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JoinedProjectsId = table.Column<int>(type: "int", nullable: false),
                    ParticipantsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_AspNetUsers_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_JoinedProjectsId",
                        column: x => x.JoinedProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ContactInformations",
                columns: new[] { "Id", "Address", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Rullgatan 24A", "alicean12@live.se", "0723892311" },
                    { 2, "Johanneslunden 7", "bobbergstrom@gmail.com", "0724873928" },
                    { 3, "Kolagränd 23", "charliec@live.se", "0809483729" },
                    { 4, "Mossvägen 15", "danield@outlook.com", "0738452390" },
                    { 5, "Bäckstigen 12B", "emily.evans@hotmail.com", "0709847328" },
                    { 6, "Kullavägen 8", "frankfischer@gmail.com", "0762938475" },
                    { 7, "Tallbacken 4", "grace.gustafsson@live.se", "0701938476" },
                    { 8, "Lärkträdsvägen 10", "hanna.holm@gmail.com", "0739487261" },
                    { 9, "Allegatan 14C", "ian.ingemarsson@outlook.com", "0723847569" },
                    { 10, "Stenvägen 5A", "julia.jonsson@yahoo.com", "0768273945" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Descriptor" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Medicin" },
                    { 3, "Omvårdnad" },
                    { 4, "Transport" },
                    { 5, "Utbildning" },
                    { 6, "Forskning" },
                    { 7, "Miljö" },
                    { 8, "Kultur" },
                    { 9, "Sport" },
                    { 10, "Ekonomi" },
                    { 11, "Teknik" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "InformationId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isActive", "isPrivate" },
                values: new object[,]
                {
                    { "1", 0, "f71e7537-3e13-44c1-8afe-830c11616afe", null, false, "Alice", 1, "Andersson", false, null, null, null, "P@ssword123", null, null, false, "47437cf8-ebd3-4fdd-9ad8-42af4fc580b3", false, "aliA", true, true },
                    { "10", 0, "0ae0c131-005f-4364-b72d-d04ca0e0e2b9", null, false, "Julia", 10, "Jonsson", false, null, null, null, "JuliasP@ss7", null, null, false, "47e05ad2-d9ef-4885-b69f-4e0307d078dc", false, "JulesJ", false, true },
                    { "2", 0, "af63064f-efde-4c06-8b0b-080468006cfc", null, false, "Bob", 2, "Bergström", false, null, null, null, "P@ssword456", null, null, false, "ee3f2d7d-fe70-40cb-a69a-8cae7d62fc50", false, "BobbieB", true, false },
                    { "3", 0, "07a9f802-2d95-4ca6-89de-9feebfe265d3", null, false, "Charlie", 3, "Carlsson", false, null, null, null, "P@ssword789", null, null, false, "b6d77379-d1ea-498e-a1b6-c184a84fb0c1", false, "Charlie", false, false },
                    { "4", 0, "82eb0301-a4ff-4cf7-8ce9-57222c46aa64", null, false, "Daniel", 4, "Davidsson", false, null, null, null, "SecureP@ss1", null, null, false, "2009d46e-306d-481d-81e6-e76a7ae808b2", false, "DanD", true, true },
                    { "5", 0, "dea02ae1-1bfc-40e6-9760-793d357b9322", null, false, "Emily", 5, "Evans", false, null, null, null, "MyP@ssword2", null, null, false, "6d38033d-3e13-4dcf-a819-8efa8239bcae", false, "EmEv", true, false },
                    { "6", 0, "a1284e51-8374-42a8-8e69-53b4b7bbe551", null, false, "Frank", 6, "Fischer", false, null, null, null, "StrongP@ss3", null, null, false, "2d8bd4db-2bf6-4a4d-af2c-e65101fb9ff7", false, "Frankie", true, true },
                    { "7", 0, "30a6be8c-de6a-4a4e-a632-b85ef444f162", null, false, "Grace", 7, "Gustafsson", false, null, null, null, "GracefulP@ss4", null, null, false, "0f8136e5-55bf-4263-b993-68f1cde9249f", false, "GracieG", false, false },
                    { "8", 0, "4d930554-9745-42fe-a0fd-e519e4702cb2", null, false, "Hanna", 8, "Holm", false, null, null, null, "H@nnasP@ss5", null, null, false, "13062cde-62db-4476-8735-6cc7ccd01b7b", false, "HannaH", true, true },
                    { "9", 0, "9539a8b7-0e6b-49ae-9c90-1d40b4689832", null, false, "Ian", 9, "Ingemarsson", false, null, null, null, "I@nsSecure6", null, null, false, "f1d6c581-7625-460d-bafa-8ac03d335b52", false, "IanI", true, false }
                });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "Id", "OwnerId", "Skills", "Views" },
                values: new object[,]
                {
                    { 1, "1", "[\"Projektledning\",\"CSS\",\"HTML\"]", 10 },
                    { 2, "3", "[\"Grafisk design\",\"Pedagogik\"]", 11 },
                    { 3, "2", "[\"Omv\\u00E5rdnad\",\"Kommunikation\"]", 15 },
                    { 4, "4", "[\"Eventplanering\",\"Samordning\"]", 8 },
                    { 5, "5", "[\"Ingenj\\u00F6rskonst\",\"Produktutveckling\"]", 12 },
                    { 6, "6", "[\"Forskning\",\"Biomedicin\"]", 9 },
                    { 7, "7", "[\"AI-utveckling\",\"Python\",\"Machine Learning\"]", 20 },
                    { 8, "8", "[\"Milj\\u00F6skydd\",\"Administration\"]", 14 },
                    { 9, "9", "[\"Undervisning\",\"Kursutveckling\"]", 18 },
                    { 10, "10", "[\"Patientv\\u00E5rd\",\"Ledarskap\"]", 25 }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Discriminator", "EndDate", "Location", "StartDate", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, null, "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro kommun", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik", "2" },
                    { 2, "En kurs i drejeri", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kävesta Folkhögskola", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs", "1" },
                    { 3, null, "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Röda korset Örebro", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete", "1" },
                    { 4, "Sommarjobb som forskningsassistent", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linköping universitet", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sommarjobb", "3" },
                    { 5, "Praktik inom medicinsk forskning", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolinska Institutet", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik", "4" },
                    { 6, "Deltog i hjälparbete för flyktingar", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Svenska Röda Korset", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete", "5" },
                    { 7, "Kurs i hållbart byggande", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chalmers Tekniska Högskola", new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs", "6" },
                    { 8, "Projektarbete inom AI-utveckling", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro Universitet", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektarbete", "7" },
                    { 9, "Volontärarbete inom miljöskydd", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naturskyddsföreningen", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete", "8" },
                    { 10, "Deltog i en workshop om ledarskap", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uppsala Universitet", new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Workshop", "9" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Discriminator", "EndDate", "Location", "Role", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 11, "Underhåller ett team i bageri/ungdomsgård", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Café Deed", "Arbetsledare", new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 12, "Omvårdnad", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uppsala Sjukhus", "Sjuksköterska", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 13, "Arbetsuppgifter", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generiskt Företag", "Arbetstitel", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 14, "Ansvarig för eventplanering och samordning", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stockholms Stad", "Eventkoordinator", new DateTime(2018, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 15, "Utveckling och testning av nya bilmodeller", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volvo Cars", "Ingenjör", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" },
                    { 16, "Forskning inom biomedicin", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolinska Institutet", "Forskningsassistent", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6" },
                    { 17, "Hantering av deklarationer och rådgivning", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skatteverket", "Handläggare", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "7" },
                    { 18, "Administration och projektstöd", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Länsstyrelsen", "Projektassistent", new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "8" },
                    { 19, "Undervisning och kursutveckling", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luleå Tekniska Universitet", "Universitetslärare", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "9" },
                    { 20, "Patientvård och ledning av vårdteam", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norrlands Universitetssjukhus", "Läkare", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Description", "Discriminator", "EndDate", "Level", "Location", "Program", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 21, "", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gymnasial", "Karolinska Gymnasiet", "Vård och omsorg", new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 22, "", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Uppsala Universitet", "Arkelogi", new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 23, "Specialisering inom hållbar utveckling", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Lund Universitet", "Miljövetenskap", new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 24, "Fokus på produktutveckling", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Chalmers Tekniska Högskola", "Maskinteknik", new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" },
                    { 25, "Med inriktning på etnologi", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Göteborg Universitet", "Kulturvetenskap", new DateTime(2015, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6" },
                    { 26, "Med fokus på artificiell intelligens", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "KTH Royal Institute of Technology", "Datavetenskap", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7" },
                    { 27, "Specialisering inom internationell handel", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Stockholms Universitet", "Ekonomi", new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "8" },
                    { 28, "Studier inom ekologi och naturvård", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Umeå Universitet", "Biologi", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "9" },
                    { 29, "Forskning inom kvantmekanik", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doktorand", "Linköping Universitet", "Teknisk fysik", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "10" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Date", "ReceiverId", "SenderId", "Subject" },
                values: new object[,]
                {
                    { 1, "Hej på dig! Hur är det med dig?", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", "1", "En hälsning" },
                    { 2, "Missade att du skrev, förlåt.", new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", "2", "Missade" },
                    { 3, "Ska vi ta en lunch imorgon?", new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", "3", "Lunch?" },
                    { 4, "Tack för att du hjälpte mig med projektet.", new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", "1", "Tack!" },
                    { 5, "Kan du kika på dokumentet jag skickade?", new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", "4", "Fråga" },
                    { 6, "Jag har lagt till några kommentarer i ditt utkast.", new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", "5", "Feedback" },
                    { 7, "Glöm inte mötet imorgon kl. 10.", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", "6", "Möte" },
                    { 8, "Har du hunnit förbereda presentationen?", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", "7", "Presentation" },
                    { 9, "Grattis på födelsedagen!", new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", "8", "Grattis!" },
                    { 10, "Ha en trevlig helg! Vi hörs på måndag.", new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "10", "9", "Trevlig helg" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatorId", "Description", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "1", "En app för att optimera postleveranser.", new DateTime(2011, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tidtabell för postnord" },
                    { 2, "3", "Ett bokningssystem för SJ-resor.", new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SJ Bokningssystem" },
                    { 3, "2", "En databas för miljöövervakning och analys.", new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miljödatabas" },
                    { 4, "4", "Ett verktyg för att planera och hantera evenemang.", new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eventplaneringssystem" },
                    { 5, "7", "En AI-baserad chatbot för kundsupport.", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI-driven chatbot" },
                    { 6, "5", "En app för att organisera och schemalägga uppgifter.", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virtuell assistent" },
                    { 7, "6", "Ett system för analys av biomedicinska data.", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biomedicinsk analys" },
                    { 8, "8", "En plattform för att hantera och driva e-handel.", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-handelsplattform" },
                    { 9, "9", "Ett skattesystem med automatiserad rapportering.", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avancerat skattesystem" },
                    { 10, "10", "En lösning för fjärrmedicinska konsultationer.", new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telemedicinplattform" }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InformationId",
                table: "AspNetUsers",
                column: "InformationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CVTag_TagsId",
                table: "CVTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatorId",
                table: "Projects",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_JoinedProjectsId",
                table: "ProjectUser",
                column: "JoinedProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ParticipantsId",
                table: "ProjectUser",
                column: "ParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserId",
                table: "ProjectUser",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CVExperience");

            migrationBuilder.DropTable(
                name: "CVProject");

            migrationBuilder.DropTable(
                name: "CVTag");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ContactInformations");
        }
    }
}
