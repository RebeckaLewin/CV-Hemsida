using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Projects_ProjectId",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_AspNetUsers_UserId",
                table: "TagUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_AspNetUsers_UsersId",
                table: "TagUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_Tags_TagId",
                table: "TagUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_Tags_TagsId",
                table: "TagUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagUser",
                table: "TagUser");

            migrationBuilder.DropIndex(
                name: "IX_TagUser_TagsId",
                table: "TagUser");

            migrationBuilder.DropIndex(
                name: "IX_TagUser_UserId",
                table: "TagUser");

            migrationBuilder.DropIndex(
                name: "IX_CVs_ProjectId",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "TagUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TagUser");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "CVs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagUser",
                table: "TagUser",
                columns: new[] { "TagsId", "UsersId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8178061-71a7-43ab-b7cf-51a65bbb766e", "AQAAAAIAAYagAAAAEPumK7vjTwad6DhsA2B4cSb978W3vza37Gh7CFRM5Yx9+RJHXCVin2PnZ/TX70/OaQ==", "3aa14ba1-5667-4669-9a36-33dc13681efc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1e98df7-5ed2-4eba-b2a6-8bd36d3193fa", "AQAAAAIAAYagAAAAEFbCIn7u93ej9fz1O7fg4BDhUxvk/W9MePdM5/Hi0Ee2b6M+Hsm2UOFijiCslVm6KA==", "72afd099-e6c7-4a66-b1df-3524dbc63769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b63d2d85-db3e-42dc-ba27-3e692e68c337", "AQAAAAIAAYagAAAAEPnx1t72kEvQ01m1fFicZKy81G16CoTiW6TVNOP1cAAoqYYZVMmJ/AdzjwVE8ZIs3Q==", "6fc7ca2d-2ad4-452b-9310-5ffa9582757a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de20d251-0ec7-4e80-be33-62af21211e2d", "AQAAAAIAAYagAAAAEOtlWHi2vDFEA/jgsbIDYkhZVRtQtnn/KpQgTckx/DdTmLOJU1pKTsUXc37kypecaw==", "12672de4-2599-4e0c-9808-a0a2bcb50123" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de785abc-6b96-49f3-b83a-d3981b035266", "AQAAAAIAAYagAAAAENtGp082n63GEbSPoIY5ebPa6mLd+7/MWaRR8ABOL/gWnNvoPHCkWG/m5zDj6Zu3Dg==", "2305bf77-609e-482f-8904-a5a6fbada357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55fa7ff-28b7-4d7c-9bbe-8c1069a23e24", "AQAAAAIAAYagAAAAEPd5jXWxPE+rqNDNOx/kXaP0Gi0loOg4FPQhxE7eWOYSn8MaYi49pReOwhVEyhFGYQ==", "57c4546d-f06c-46f8-bb79-06e89d71d42b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5306a8-0513-4a16-b28a-0b5c0e34af38", "AQAAAAIAAYagAAAAEPa2HxvJ0GQLvXXnmqgaz9ccezIhgsNbarMMyhl06n2NSjEUjeRjlMaQBHLwRiUHwA==", "d596deac-b387-4481-bc73-bd22823dfa64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0f16617-a5f4-4720-a7c1-078cbc19b4c7", "AQAAAAIAAYagAAAAEBjBxFhQfpMPt1RKx4B+/JhXP1nR7A9tvQ1qeSxDHcPbsS9YH8UFod2DKsHH50ejUA==", "389f4bd0-ae19-43e8-a43f-c4a1bccdc34d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5da8833-42bc-46ab-9545-cb1ae29c2c54", "AQAAAAIAAYagAAAAEJwphVv9cSjfC/PJ6EokM2o/SYrId4iBKISpvRnHxTUSZWyj64+w+l09bZZy1AR/Vw==", "117e0397-5c54-40f7-b2e9-6d95c8dbe74a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ecf22a3-d59b-4483-8030-a0d00cb4c7a0", "AQAAAAIAAYagAAAAEHyXrMVIE72j4qMF84G7Q8V4OIIVke9o/8FVbTq+7yy9A54ht08EL6JkhhqdflucpQ==", "020ab224-b075-4ab5-a90e-8113c5891a54" });

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_AspNetUsers_UsersId",
                table: "TagUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_Tags_TagsId",
                table: "TagUser",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_AspNetUsers_UsersId",
                table: "TagUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_Tags_TagsId",
                table: "TagUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagUser",
                table: "TagUser");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "TagUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TagUser",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "CVs",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagUser",
                table: "TagUser",
                columns: new[] { "TagId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "597cd8de-2a6a-4640-9993-ff953adbba20", "AQAAAAIAAYagAAAAEHnCErEz8cVYJv30s8VkWA4o7jaUuRK85SiBpWRd64G4yqJDTyFZ7UnC1CUAWmJSSg==", "b4a4ffaf-003f-4c86-8443-45a6cd39a948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3879b47d-7d68-4163-a143-d38d3d3e183f", "AQAAAAIAAYagAAAAEPt3Eu3r7j/m1Rig7Jlhq3flimE8O2cxqQmu0RXJowOD5QZEuH60priB2DCTAwZ7pw==", "e4199611-fc8c-415e-8232-24eff624ef56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d28be6a-149d-42f6-938b-05b75aaa90ac", "AQAAAAIAAYagAAAAEALp1ckCuzQH3IQonG2Z+m13SN1ML5ZX0BiN6+VYYs21PIT1C4c40iFVYF0zMcV/wQ==", "be9283df-3a54-42eb-a21f-67692ec2a4b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa8f815-eddd-4e1b-86bd-69a93539efa8", "AQAAAAIAAYagAAAAEBX5tBeSVnL5RLKXrIl64VJfi5y7NQeGmo4qBX5Exkg7uy61TWkxkricB5OupjSvFw==", "241a9e7b-73ea-42d1-8577-36e66ea5301b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fc94d01-627f-4aaf-9436-36cedcd968d8", "AQAAAAIAAYagAAAAEJr1b7vYVIwLuqvHNRzpMnyo+4XcbeecoUqBzOx8kpso52S99Q503cf4n7/zHCH3Tw==", "a136e73c-f2b0-4813-8c10-867a76439e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "326dbf48-3290-40d1-afb8-f3d37d12c5c0", "AQAAAAIAAYagAAAAEM8d7yhr9loayPAx9kE14Z/SlRF529j+uMAwU7GZ/VqFmnlHEuETCKvdq116+qy0eg==", "66f20704-aca4-4c19-853a-305a4ad06fe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4070949b-37bf-4241-b119-728056c846ec", "AQAAAAIAAYagAAAAELB1lLIW7HSD9Y0KDLtykInU5nXUHz9R47ZaM2kWKIll4LWK5XzO2I/Y755sB7YDBQ==", "f606f40b-2eac-4960-be22-753077112bc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7271dcf-465c-44a0-ba6d-4ade8cb8e577", "AQAAAAIAAYagAAAAEPjdyy/Ge2nSnJGJ4MdLJe0uCM2JOMcHkxviFzopgCommW5cRcsAO+sC5NFqhbnmdg==", "ef56c537-0e6c-4030-b8a1-1383952692aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e772d4a4-423c-44ef-9ed0-7e122e62a42c", "AQAAAAIAAYagAAAAENdZpF+SpUYN8LCEmDFMjxPT2wmz6rQ739bL6uJ19YtaDggSs3MCGooq2aFhUZl0Uw==", "b0fdf0a5-0f57-4a0a-a3e7-596fd2280b7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "162eac35-e51b-4153-90a6-7f4b97de8ee4", "AQAAAAIAAYagAAAAEAX682T46+G9RgtjfFX25+rF0/xcXXWEtCFJ+durJIo6gBhomOXRqQDX6dMSGNdhcA==", "dc2600aa-526e-412a-997d-8ca9a4363c28" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProjectId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_TagUser_TagsId",
                table: "TagUser",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_TagUser_UserId",
                table: "TagUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_ProjectId",
                table: "CVs",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Projects_ProjectId",
                table: "CVs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_AspNetUsers_UserId",
                table: "TagUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_AspNetUsers_UsersId",
                table: "TagUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_Tags_TagId",
                table: "TagUser",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_Tags_TagsId",
                table: "TagUser",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
