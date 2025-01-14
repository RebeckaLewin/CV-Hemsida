using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Messages",
                newName: "SenderName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff67011b-adc2-43e6-8864-822486bd319b", "AQAAAAIAAYagAAAAEP61SuczBr49FKBdNkOGCoEEAk8xiyRmv08NmNfyu3JwB1suMyWHu25TBEcFi+rkAg==", "6060b371-f20e-40b7-b0c0-6bd0e0c6119c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1420fe35-1878-4723-83e6-efb76f43ef4f", "AQAAAAIAAYagAAAAEN6RVJdgKJAP/FX4hzuglr1j3P9Bzsj4ewkvIXz26/XCpeBr2uBl0fJlkEL8ylXM8g==", "c9b6dd21-cae1-4d9d-aee7-37d1d70439f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a53ada6d-f7a3-4dbe-89fb-af84140a6525", "AQAAAAIAAYagAAAAECyHKD6CeMOvTwbtMnYrM7y9WIb5yApFrL0I15Ow4VJ+o3kZkKaRBe557zvM8eZyMA==", "bdc711ef-3f38-4f54-8d5b-5e3c20e0f073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a14fefb8-3527-4598-b267-66cc0a203dfc", "AQAAAAIAAYagAAAAECSEe6CnlL1kl/sww+vSsOgS7nDBqnznN7JpiwdYQKcvIcfVlY1P0CoBVcy6haUtCQ==", "1039f19e-c299-496e-986a-09329375ec62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70f85b99-3bce-4436-8363-cd63c5c32b96", "AQAAAAIAAYagAAAAEEWD2ZgOYnZ6reuvroqE5GYo+cCM5hx61sskAzFkUj5NgzuFpKs0owhTHQ4vXNCYQg==", "52be7f37-b440-4753-ac20-5dd711c3d4df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c5c25ff-3d7f-48ed-b063-2c209124a949", "AQAAAAIAAYagAAAAEBrYuXXx37AU85mo/WYQ8qKew3L5Nk0EY3WWYdgMsOI9Tlj+xe1TwGmzFdGhGBosww==", "e9849ac2-5853-438e-a378-5edd58d18ae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc356b2d-3eea-4b39-af2f-7e5af6be048a", "AQAAAAIAAYagAAAAEJr9VXlmpV98G61yQJrJWACMSre7MH5p+4Mas//QkiPeSLnOXoSfhJtqimX0hBPt4g==", "9358e3ff-a78d-458f-a232-860f59b7f623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586bc7b1-307f-4835-90bf-d71d6000e195", "AQAAAAIAAYagAAAAEKiAnyl/K8MLSWSrdNTYNZYwDOd+P8xCLa3FRqLI8BoJ/QOC6GfzYHWvmWYFedo4Ag==", "f6e1ee12-4ddf-4152-9609-f3fa28e0b212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05474474-7937-4cb8-b44b-4ae103f00141", "AQAAAAIAAYagAAAAEKmz6JUb9tnVhT9wJ7d4QcsiqvMg8ZvCdeQdn3F4iQTjtl9ZRBY2IOtOQMyR3s/Xsg==", "aca4e1bf-96bc-4e5d-870e-2caa3cfeb81c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eef13de-12af-456f-9ba2-2efad76b7080", "AQAAAAIAAYagAAAAEFYGxZKKGjNmVkUiLzkCgwhiGMP/1DLo47oywpqAJukwPwbdiBCqxHpwd3zfzpO7JQ==", "66d20e31-66a4-4aa6-bf98-ba517ebe2b0d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SenderName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SenderName",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderName",
                table: "Messages",
                newName: "Subject");

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

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Subject",
                value: "En hälsning");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Subject",
                value: "Missade");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Subject",
                value: "Lunch?");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Subject",
                value: "Tack!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Subject",
                value: "Fråga");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Subject",
                value: "Feedback");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Subject",
                value: "Möte");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Subject",
                value: "Presentation");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Subject",
                value: "Grattis!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "Subject",
                value: "Trevlig helg");
        }
    }
}
