using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformationId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPrivate = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isRead = table.Column<bool>(type: "bit", nullable: false),
                    ReceiverDelete = table.Column<bool>(type: "bit", nullable: false),
                    SenderDelete = table.Column<bool>(type: "bit", nullable: false)
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
                name: "TagUser",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagUser", x => new { x.TagsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TagUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TagUser_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_Experiences_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    JoinedProjectsId = table.Column<int>(type: "int", nullable: false),
                    ParticipantsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.JoinedProjectsId, x.ParticipantsId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_AspNetUsers_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_JoinedProjectsId",
                        column: x => x.JoinedProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ContactInformations",
                columns: new[] { "Id", "Address", "Phone" },
                values: new object[,]
                {
                    { 1, "Rullgatan 24A", "0723892311" },
                    { 2, "Johanneslunden 7", "0724873928" },
                    { 3, "Kolagränd 23", "0809483729" },
                    { 4, "Mossvägen 15", "0738452390" },
                    { 5, "Bäckstigen 12B", "0709847328" },
                    { 6, "Kullavägen 8", "0762938475" },
                    { 7, "Tallbacken 4", "0701938476" },
                    { 8, "Lärkträdsvägen 10", "0739487261" },
                    { 9, "Allegatan 14C", "0723847569" },
                    { 10, "Stenvägen 5A", "0768273945" },
                    { 11, "Hasselvägen 3", "0739172638" },
                    { 12, "Björkstigen 7B", "0708237461" },
                    { 13, "Lönnvägen 12A", "0763498271" },
                    { 14, "Ekliden 9", "0723948576" },
                    { 15, "Grönbacken 2", "0732847562" },
                    { 16, "Furugatan 6C", "0702348967" },
                    { 17, "Granliden 11", "0761239487" },
                    { 18, "Tallstigen 5A", "0739871236" },
                    { 19, "Aspvägen 18B", "0709283745" },
                    { 20, "Rönnvägen 1", "0768742390" }
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "InformationId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName", "isActive", "isPrivate" },
                values: new object[,]
                {
                    { "1", 0, "72f5813a-6a18-492b-937c-77c3621a5efc", "En noggrann och kreativ grafisk designer med ett öga för detaljer.", "alicean12@live.se", false, "Alice", 1, "Andersson", false, null, "alicean12@live.se", "alicean12@live.se", "P@ssword123", "AQAAAAIAAYagAAAAEBFJ4cMoPjEK7QJdzBTX7mB5ckRgaYrVGCI/wflsDjO465GLABU81p2jZXXHpxAbGw==", null, false, "~/images/profilepic_default.jpg", "0fa00bbd-786e-4575-a858-d424b6783489", false, "alicean12@live.se", true, true },
                    { "10", 0, "f6b22963-7787-41f1-b465-72b121102e1b", "En entreprenör med erfarenhet av e-handel och kundservice.", "julia.jonsson@yahoo.com", false, "Julia", 10, "Jonsson", false, null, "julia.jonsson@yahoo.com", "julia.jonsson@yahoo.com", "JuliasP@ss7", "AQAAAAIAAYagAAAAENkt0CeDcs1EPcmh7kKoOihb+l0iE+6JlUaxm9wHND+4etEpO0ByBb+ZtHIbbyvlnw==", null, false, "~/images/profilepic_default.jpg", "33a7746f-986c-4927-bec8-4958e3f9d6c4", false, "julia.jonsson@yahoo.com", false, true },
                    { "11", 0, "e49e7361-0724-47d1-bc25-43a2e37de093", "En erfaren utvecklare med passion för backend-programmering.", "karl.karlsson@gmail.com", false, "Karl", 11, "Karlsson", false, null, "karl.karlsson@gmail.com", "karl.karlsson@gmail.com", "K@rlsP@ss1", "AQAAAAIAAYagAAAAEM7fV9HXNIoDp4Y6ndnaMipt993I2L+m82dYIswpLpdNg9eGxy9Bt3eWrJHN4BHn+Q==", null, false, "~/images/profilepic_default.jpg", "a3c686f3-1bf2-4625-85a2-046c03cd76a9", false, "karl.karlsson@gmail.com", true, true },
                    { "12", 0, "0b4f002e-00d1-4de3-9fca-04e4e5bf69c7", "En kreativ designer som älskar att skapa användarvänliga gränssnitt.", "linda.lindstrom@live.se", false, "Linda", 12, "Lindström", false, null, "linda.lindstrom@live.se", "linda.lindstrom@live.se", "Lind@P@ss2", "AQAAAAIAAYagAAAAEHM/mn0pLYjowLPJwbF5pod9Ipoiz+nz9d4QLncYP5164Ar0YtljW/5yOgbopKFs2g==", null, false, "~/images/profilepic_default.jpg", "3ff5dd6f-c22a-4f46-9bfd-449bb339a6ed", false, "linda.lindstrom@live.se", true, false },
                    { "13", 0, "e160dbf5-3e32-4b5b-b852-d6a5a9baa8be", "En dataanalytiker med erfarenhet av stora datamängder.", "martin.magnusson@outlook.com", false, "Martin", 13, "Magnusson", false, null, "martin.magnusson@outlook.com", "martin.magnusson@outlook.com", "M@rtinP@ss3", "AQAAAAIAAYagAAAAEJLXFJW2E04BS6zdpLF2dEZSSS3M2dnlnX8NnWLIG5DG7XmCyRlvGMMshX4hPuaH9Q==", null, false, "~/images/profilepic_default.jpg", "dd670731-5dc9-4a26-8c05-8709535f3c4f", false, "martin.magnusson@outlook.com", false, true },
                    { "14", 0, "1051442d-122b-43c2-ae56-28674f8640b4", "En driven projektledare med fokus på effektivitet och teamarbete.", "nina.nilsson@hotmail.com", false, "Nina", 14, "Nilsson", false, null, "nina.nilsson@hotmail.com", "nina.nilsson@hotmail.com", "Nin@P@ss4", "AQAAAAIAAYagAAAAENwbVdI6vehpkFnrjjCyXY28LcE/Dt4ujB6sBZ7BwBUWOhg6iU6LKk94j+vHvpdiKg==", null, false, "~/images/profilepic_default.jpg", "b044069e-fbe5-4daa-a84f-9e3abc28754e", false, "nina.nilsson@hotmail.com", true, false },
                    { "15", 0, "d00d9837-7e2f-4576-b93e-685eee4da0dd", "En systemarkitekt med över 10 års erfarenhet i branschen.", "oscar.olsson@gmail.com", false, "Oscar", 15, "Olsson", false, null, "oscar.olsson@gmail.com", "oscar.olsson@gmail.com", "Osc@rsP@ss5", "AQAAAAIAAYagAAAAECZLRUXmrxr32CjYUtk+PUI4XPOa23T3D3XYRZS4IxlN2chUyBGGSpqVdi7ln2LXsg==", null, false, "~/images/profilepic_default.jpg", "c4e0557a-d97f-4949-9b7a-96ced1f15804", false, "oscar.olsson@gmail.com", true, true },
                    { "16", 0, "414c1b91-e31b-482f-a03c-9b87d5b754e6", "En engagerad tester som brinner för att hitta och lösa buggar.", "petra.persson@yahoo.com", false, "Petra", 16, "Persson", false, null, "petra.persson@yahoo.com", "petra.persson@yahoo.com", "Petr@sP@ss6", "AQAAAAIAAYagAAAAEHACYXUt3gtb+gu/WrJbcILFP/njDhp62r95tnCPSifDHc3eg3/kUdWJPZTT/8bJ0g==", null, false, "~/images/profilepic_default.jpg", "17da43bc-9f13-4311-9fc8-c18d62ea0c14", false, "petra.persson@yahoo.com", false, false },
                    { "17", 0, "33518f93-cd42-4171-bb67-c0f8949a22c7", "En teknisk skribent som gör komplexa idéer lättförståeliga.", "quentin.quist@live.se", false, "Quentin", 17, "Quist", false, null, "quentin.quist@live.se", "quentin.quist@live.se", "Qu@ntinsP@ss7", "AQAAAAIAAYagAAAAEAexdjm+8lCGnpdi65BD3tudEtV2XV3XgoX4E/XLQSz9HpiLRjmrh3M8azRVlP8KwA==", null, false, "~/images/profilepic_default.jpg", "297f9997-37e4-4c65-8c86-0d63b69729b2", false, "quentin.quist@live.se", true, true },
                    { "18", 0, "06770b33-c518-4359-9f4f-a3178e15d7a7", "En marknadsföringsspecialist med fokus på digitala strategier.", "rebecca.rudolfsson@outlook.com", false, "Rebecca", 18, "Rudolfsson", false, null, "rebecca.rudolfsson@outlook.com", "rebecca.rudolfsson@outlook.com", "Rebecc@sP@ss8", "AQAAAAIAAYagAAAAEJ+Cy2uECVGhUPZY7tYI3GK2A4nE8vCAQQyhopha7vfMAnt/5TIq79CmhkMoZ9fI1A==", null, false, "~/images/profilepic_default.jpg", "0e0a5d36-183d-46a5-8795-935cd59a797a", false, "rebecca.rudolfsson@outlook.com", true, false },
                    { "19", 0, "8f52da92-6191-4eec-af78-47e5f1e2fa86", "En agil coach som hjälper team att nå sin fulla potential.", "stefan.sundberg@gmail.com", false, "Stefan", 19, "Sundberg", false, null, "stefan.sundberg@gmail.com", "stefan.sundberg@gmail.com", "Stef@nsP@ss9", "AQAAAAIAAYagAAAAENdKcuAZhdPbBylZ3ewlmlZf2bUw+v1aHMdliWN6EWCC0DNLVOmMv0mXkImWvCc5zA==", null, false, "~/images/profilepic_default.jpg", "b7397bc4-22da-4e4c-b3b3-3e830cf19345", false, "stefan.sundberg@gmail.com", true, true },
                    { "2", 0, "471b3abf-e127-4752-a0d0-0bc35af438bd", "En erfaren systemutvecklare som brinner för innovativa lösningar.", "bobbergstrom@gmail.com", false, "Bob", 2, "Bergström", false, null, "bobbergstrom@gmail.com", "bobbergstrom@gmail.com", "P@ssword456", "AQAAAAIAAYagAAAAEOaPsIREE13E4sYNYfq8niSuZ3PrqKbgtW2ZGTl4jpyo/KT80og+ckjBsW886TJfXw==", null, false, "~/images/profilepic_default.jpg", "3f5f3f08-6c3a-4401-b675-017d74b3d7a2", false, "bobbergstrom@gmail.com", true, false },
                    { "20", 0, "9c43699c-c159-4929-bffa-59513066087f", "En front-end-utvecklare med öga för detaljer och design.", "therese.tornqvist@hotmail.com", false, "Therese", 20, "Törnqvist", false, null, "therese.tornqvist@hotmail.com", "therese.tornqvist@hotmail.com", "Theres@sP@ss10", "AQAAAAIAAYagAAAAENenNJpCwcX2pGYOu09xxD/v2felO7sxNJFA7YGajQzIBuG7fgGykrwwv1cVrA9kkA==", null, false, "~/images/profilepic_default.jpg", "7d34f415-ce19-4084-81a8-5a05df29f026", false, "therese.tornqvist@hotmail.com", false, false },
                    { "3", 0, "13d631d8-a587-4af9-9f41-e7d0231c29b8", "En entusiastisk frontend-utvecklare som älskar att skapa användarvänliga gränssnitt.", "charliec@live.se", false, "Charlie", 3, "Carlsson", false, null, "charliec@live.se", "charliec@live.se", "P@ssword789", "AQAAAAIAAYagAAAAEA6wfJYDDWNul3QshFFVFtBFLxLgV3ljQBC+jZQJ7hxz0dGXTY7tlamB3iyHlcUk8A==", null, false, "~/images/profilepic_default.jpg", "be70df09-b4d1-4b2e-9a9c-8bd805ae4973", false, "charliec@live.se", false, false },
                    { "4", 0, "543f07fa-daae-4a56-9858-89b3950f1085", "En passionerad IT-projektledare med fokus på samarbete och kvalitet.", "danield@outlook.com", false, "Daniel", 4, "Davidsson", false, null, "danield@outlook.com", "danield@outlook.com", "SecureP@ss1", "AQAAAAIAAYagAAAAEBASg+3yX7L+HwR4i12Vj9v95ukJ6Sn7RqYBkNUUyeK1Xpd4VdpOeL1Y5TEGAmlOqA==", null, false, "~/images/profilepic_default.jpg", "17151996-35d0-4688-88da-281ec4f0ad64", false, "danield@outlook.com", true, true },
                    { "5", 0, "91215ed7-928f-4ff9-8a93-cae79b53cd10", "En social media-expert med erfarenhet av kampanjer och strategier.", "emily.evans@hotmail.com", false, "Emily", 5, "Evans", false, null, "emily.evans@hotmail.com", "emily.evans@hotmail.com", "MyP@ssword2", "AQAAAAIAAYagAAAAEDJtgmPUSTPc2Cp0lwd5/JDtpOjSePolEcNfdoMpZ+95XnTjyvx9fePx+EOSc+DU6w==", null, false, "~/images/profilepic_default.jpg", "b5be4055-7254-4f4b-b753-73849bcb61af", false, "emily.evans@hotmail.com", true, false },
                    { "6", 0, "06525e91-3d8c-499f-af1e-3dad044051bc", "En datasäkerhetsspecialist med djup kunskap inom kryptering och skydd.", "frankfischer@gmail.com", false, "Frank", 6, "Fischer", false, null, "frankfischer@gmail.com", "frankfischer@gmail.com", "StrongP@ss3", "AQAAAAIAAYagAAAAELiTDSN9AGf/DqFnXyDZjRLpSEj6bh4iimBvpIEKiIEkUb0TwFjpH7Fgt2iDe09Sqg==", null, false, "~/images/profilepic_default.jpg", "19a0af09-91b7-4c19-9332-5e2fca41d60e", false, "frankfischer@gmail.com", true, true },
                    { "7", 0, "d8d7de44-92bd-42e5-867d-81a57b6c382c", "En UI/UX-designer som strävar efter att skapa engagerande upplevelser.", "grace.gustafsson@live.se", false, "Grace", 7, "Gustafsson", false, null, "grace.gustafsson@live.se", "grace.gustafsson@live.se", "GracefulP@ss4", "AQAAAAIAAYagAAAAEOrGsI2mHfixII+AzJC/YaiXJ/MtCSZHbW6VSdTdZbWdGnjpbbJTL6G5kTDxaGZ3jw==", null, false, "~/images/profilepic_default.jpg", "62c5199c-e9a0-4b2a-92a0-f49905fbfd7d", false, "grace.gustafsson@live.se", false, false },
                    { "8", 0, "aecfb640-ed1f-4ba9-b0ef-d789d20c53d2", "En datavetare med specialisering inom artificiell intelligens och maskininlärning.", "hanna.holm@gmail.com", false, "Hanna", 8, "Holm", false, null, "hanna.holm@gmail.com", "hanna.holm@gmail.com", "H@nnasP@ss5", "AQAAAAIAAYagAAAAEIgMPmt2blnSivYzThNaJWT1am563cWemSWzw6zknxKb5zTnkozG1QIiT+MqQt+0ug==", null, false, "~/images/profilepic_default.jpg", "92feda14-b642-4a92-ad49-c9b6c6c43239", false, "hanna.holm@gmail.com", true, true },
                    { "9", 0, "daebd929-004f-467f-8c6e-30c7d3618084", "En engagerad produktägare som fokuserar på att möta kundernas behov.", "ian.ingemarsson@outlook.com", false, "Ian", 9, "Ingemarsson", false, null, "ian.ingemarsson@outlook.com", "ian.ingemarsson@outlook.com", "I@nsSecure6", "AQAAAAIAAYagAAAAEOpP0ovfAVXm+Pr0ZOvzlrvBp+G4zguSutLe96xP6nipXPtXR1jKptcAZ3j6AnLEPQ==", null, false, "~/images/profilepic_default.jpg", "ac7a70db-827a-4328-a661-b3aecc2fbd84", false, "ian.ingemarsson@outlook.com", true, false }
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
                    { 10, "10", "[\"Patientv\\u00E5rd\",\"Ledarskap\"]", 25 },
                    { 11, "11", "[\"Webbutveckling\",\"JavaScript\",\"React\"]", 17 },
                    { 12, "12", "[\"Marknadsf\\u00F6ring\",\"SEO\",\"Digital strategi\"]", 13 },
                    { 13, "13", "[\"Databashantering\",\"SQL\",\"NoSQL\"]", 22 },
                    { 14, "14", "[\"Skrivande\",\"Teknisk dokumentation\"]", 10 },
                    { 15, "15", "[\"Agil projektledning\",\"Scrum\",\"Kanban\"]", 19 },
                    { 16, "16", "[\"Fotografi\",\"Bildredigering\",\"Adobe Photoshop\"]", 16 },
                    { 17, "17", "[\"Aff\\u00E4rsutveckling\",\"F\\u00F6rs\\u00E4ljning\",\"Ekonomi\"]", 21 },
                    { 18, "18", "[\"Mjukvarutestning\",\"Automatisering\",\"QA\"]", 14 },
                    { 19, "19", "[\"Grafikprogrammering\",\"C#\",\"Unity\"]", 23 },
                    { 20, "20", "[\"Dataanalys\",\"Python\",\"R\"]", 26 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Date", "ReceiverDelete", "ReceiverId", "SenderDelete", "SenderId", "SenderName", "isRead" },
                values: new object[,]
                {
                    { 1, "Hej på dig! Hur är det med dig?", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2", false, "1", "", false },
                    { 2, "Missade att du skrev, förlåt.", new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", false, "2", "", false },
                    { 3, "Ska vi ta en lunch imorgon?", new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", false, "3", "", false },
                    { 4, "Tack för att du hjälpte mig med projektet.", new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "3", false, "1", "", false },
                    { 5, "Kan du kika på dokumentet jag skickade?", new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "5", false, "4", "", false },
                    { 6, "Jag har lagt till några kommentarer i ditt utkast.", new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", false, "5", "", false },
                    { 7, "Glöm inte mötet imorgon kl. 10.", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "7", false, "6", "", false },
                    { 8, "Har du hunnit förbereda presentationen?", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "6", false, "7", "", false },
                    { 9, "Grattis på födelsedagen!", new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "9", false, "8", "", false },
                    { 10, "Ha en trevlig helg! Vi hörs på måndag.", new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "10", false, "9", "", false },
                    { 11, "Hur gick mötet idag?", new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", false, "10", "", false },
                    { 12, "Jag har skickat filerna du bad om.", new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "3", false, "2", "", false },
                    { 13, "Kan vi skjuta upp vårt möte till nästa vecka?", new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", false, "3", "", false },
                    { 14, "Tack för inbjudan, jag kommer gärna!", new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "6", false, "5", "", false },
                    { 15, "Jag behöver hjälp med en uppgift, kan vi prata senare?", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "7", false, "6", "", false },
                    { 16, "Glöm inte att skicka in rapporten innan deadline.", new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8", false, "7", "", false },
                    { 17, "Det låter bra, vi ses på tisdag!", new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "9", false, "8", "", false },
                    { 18, "Kan du dubbelkolla schemat för mig?", new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "10", false, "9", "", false },
                    { 19, "Jag behöver feedback på min idé, kan du hjälpa till?", new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", false, "10", "", false },
                    { 20, "Vi måste gå igenom projektplanen snart.", new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2", false, "1", "", false }
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
                    { 10, "10", "En lösning för fjärrmedicinska konsultationer.", new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telemedicinplattform" },
                    { 11, "1", "En plattform för att tillhandahålla digitala läromedel för skolor.", new DateTime(2018, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digitala läromedel" },
                    { 12, "2", "Ett användarvänligt CRM-system för små och medelstora företag.", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRM-system för småföretag" },
                    { 13, "3", "En mobilapp för att beställa matleveranser från lokala restauranger.", new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matleveransapp" },
                    { 14, "4", "En app som hjälper användare att hålla koll på sin hälsa och träning.", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hälsotracker" },
                    { 15, "5", "Ett system för säker och effektiv filhantering i molnet.", new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molnbaserad filhantering" },
                    { 16, "6", "En plattform som förenklar rekryteringsprocessen för företag.", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rekryteringsplattform" },
                    { 17, "7", "Ett indieprojekt för att utveckla ett mobilspel.", new DateTime(2017, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spelutveckling" },
                    { 18, "8", "En plattform för onlinekurser och fjärrundervisning.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Utbildningsplattform för fjärrinlärning" },
                    { 19, "9", "Ett system för att optimera leveranskedjor och logistik.", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logistikoptimering" },
                    { 20, "10", "Ett system för att automatisera lagerhantering och spårning.", new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automatiserat lagerhanteringssystem" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "City", "CvId", "Description", "Discriminator", "EndDate", "Location", "StartDate", "Type" },
                values: new object[,]
                {
                    { 1, "Örebro", 1, null, "OtherExperience", new DateTime(2017, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro kommun", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik" },
                    { 2, "Sköllersta", 1, "En kurs i drejeri", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kävesta Folkhögskola", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs" },
                    { 3, "Örebro", 2, null, "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Röda korset Örebro", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete" },
                    { 4, "Linköping", 2, "Sommarjobb som forskningsassistent", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linköping universitet", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sommarjobb" },
                    { 5, "Stockholm", 4, "Praktik inom medicinsk forskning", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolinska Institutet", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik" },
                    { 6, "Malmö", 5, "Deltog i hjälparbete för flyktingar", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Svenska Röda Korset", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete" },
                    { 7, "Göteborg", 6, "Kurs i hållbart byggande", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chalmers Tekniska Högskola", new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs" },
                    { 8, "Örebro", 7, "Projektarbete inom AI-utveckling", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro Universitet", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektarbete" },
                    { 9, "Kiruna", 8, "Volontärarbete inom miljöskydd", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naturskyddsföreningen", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete" },
                    { 10, "Uppsala", 9, "Deltog i en workshop om ledarskap", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uppsala Universitet", new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Workshop" },
                    { 11, "Stockholm", 10, "Praktik inom stadsplanering", "OtherExperience", new DateTime(2018, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stockholm Stad", new DateTime(2017, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik" },
                    { 12, "Lund", 9, "Deltog i en kurs om klimatförändringar", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lunds Universitet", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs" },
                    { 13, "Göteborg", 8, "Sommarjobb inom bilindustrin", "OtherExperience", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volvo Cars", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sommarjobb" },
                    { 14, "Stockholm", 7, "Projektarbete inom robotteknik", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KTH Royal Institute of Technology", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektarbete" },
                    { 15, "Uppsala", 6, "Volontärarbete med internationellt bistånd", "OtherExperience", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "SIDA", new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volentärarbete" },
                    { 16, "Göteborg", 5, "Workshop om hållbar utveckling", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Göteborgs Universitet", new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Workshop" },
                    { 17, "Umeå", 4, "Deltog i en forskningskonferens", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Umeå Universitet", new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Konferens" },
                    { 18, "Stockholm", 3, "Kurs i avancerad medicinsk forskning", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolinska Institutet", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurs" },
                    { 19, "Göteborg", 2, "Projekt om hållbar energiteknik", "OtherExperience", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chalmers Tekniska Högskola", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektarbete" },
                    { 20, "Malmö", 1, "Praktik inom byggteknik", "OtherExperience", new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skanska AB", new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktik" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "City", "CvId", "Description", "Discriminator", "EndDate", "Location", "Role", "StartDate" },
                values: new object[,]
                {
                    { 21, "Örebro", 1, "Underhåller ett team i bageri/ungdomsgård", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Café Deed", "Arbetsledare", new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Uppsala", 2, "Omvårdnad", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uppsala Sjukhus", "Sjuksköterska", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Generisk stad", 3, "Arbetsuppgifter", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generiskt Företag", "Arbetstitel", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Stockholm", 4, "Ansvarig för eventplanering och samordning", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stockholms Stad", "Eventkoordinator", new DateTime(2018, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Arboga", 5, "Utveckling och testning av nya bilmodeller", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volvo Cars", "Ingenjör", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Stockholm", 6, "Forskning inom biomedicin", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolinska Institutet", "Forskningsassistent", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Örebro", 7, "Hantering av deklarationer och rådgivning", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skatteverket", "Handläggare", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Köping", 8, "Administration och projektstöd", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Länsstyrelsen", "Projektassistent", new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Luleå", 9, "Undervisning och kursutveckling", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luleå Tekniska Universitet", "Universitetslärare", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Skellefteå", 10, "Patientvård och ledning av vårdteam", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norrlands Universitetssjukhus", "Läkare", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Älmhult", 1, "Ansvarig för produktdesign och konceptutveckling", "Work", new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IKEA", "Designer", new DateTime(2017, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Luleå", 2, "Övervakning och optimering av energianläggningar", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vattenfall AB", "Ingenjör", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Visby", 3, "Utveckling och underhåll av spelplattformar", "Work", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Svenska Spel", "Systemutvecklare", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Kista", 4, "Projektledning och koordinering av globala team", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ericsson", "Projektledare", new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Lund", 5, "Utveckling av förpackningslösningar", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tetra Pak", "Produktutvecklare", new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Göteborg", 6, "Forskning och kliniska studier inom genetik", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sahlgrenska Universitetssjukhuset", "Forskningskoordinator", new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Malmö", 7, "Hantering av stora byggprojekt och resursallokering", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skanska AB", "Byggprojektledare", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Umeå", 8, "Kundsupport och administration av försäkringar", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Länsförsäkringar", "Försäkringsrådgivare", new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Linköping", 9, "Forskning och utveckling inom maskininlärning", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linköpings Universitet", "Forskare", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Stockholm", 10, "Ansvar för kirurgiska ingrepp och patientvård", "Work", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolinska Universitetssjukhuset", "Kirurg", new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "City", "CvId", "Description", "Discriminator", "EndDate", "Level", "Location", "Program", "StartDate" },
                values: new object[,]
                {
                    { 41, "Örebro", 2, "", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gymnasial", "Karolinska Gymnasiet", "Vård och omsorg", new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Uppsala", 3, "", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Uppsala Universitet", "Arkelogi", new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Lund", 4, "Specialisering inom hållbar utveckling", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Lund Universitet", "Miljövetenskap", new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Göteborg", 5, "Fokus på produktutveckling", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Chalmers Tekniska Högskola", "Maskinteknik", new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Göteborg", 6, "Med inriktning på etnologi", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Göteborg Universitet", "Kulturvetenskap", new DateTime(2015, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Stockholm", 7, "Med fokus på artificiell intelligens", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "KTH Royal Institute of Technology", "Datavetenskap", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Stockholm", 8, "Specialisering inom internationell handel", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Stockholms Universitet", "Ekonomi", new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Umeå", 9, "Studier inom ekologi och naturvård", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Umeå Universitet", "Biologi", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Linköping", 10, "Forskning inom kvantmekanik", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doktorand", "Linköping Universitet", "Teknisk fysik", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Malmö", 1, "Fokus på digitala medier och webbdesign", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Malmö Universitet", "Medieteknik", new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, "Uppsala", 2, "Specialisering inom tillämpad matematik", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Uppsala Universitet", "Matematik", new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "Stockholm", 3, "Med fokus på politiska system och förvaltning", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Stockholms Universitet", "Statsvetenskap", new DateTime(2018, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, "Växjö", 4, "Studier i urban utveckling och planering", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Linnéuniversitetet", "Samhällsplanering", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, "Göteborg", 5, "Forskning inom neurala nätverk", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doktorand", "Chalmers Tekniska Högskola", "Maskininlärning", new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "Lund", 6, "Specialisering inom organisk kemi", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Lunds Universitet", "Kemi", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, "Stockholm", 7, "Fokus på förnybar energi", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "KTH Royal Institute of Technology", "Elektroteknik", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, "Örebro", 8, "Studier inom brottsanalys och rättspsykologi", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master", "Örebro Universitet", "Kriminologi", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, "Umeå", 9, "Med fokus på affärsjuridik", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Umeå Universitet", "Juridik", new DateTime(2017, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, "Skövde", 10, "Inriktning på systemutveckling och databashantering", "Education", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandidat", "Högskolan i Skövde", "Datavetenskap", new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_CVs_OwnerId",
                table: "CVs",
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CvId",
                table: "Experiences",
                column: "CvId");

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
                name: "IX_ProjectUser_ParticipantsId",
                table: "ProjectUser",
                column: "ParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_TagUser_UsersId",
                table: "TagUser",
                column: "UsersId");
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
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "TagUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ContactInformations");
        }
    }
}
