using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedMessageagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8886bc9a-e2ef-4398-ac6a-038bd953f4bc", "AQAAAAIAAYagAAAAEGZB8lllr/YIoTCjvp1MbPhrV0e7wzNu24vWtsDUclgQdXrNSJqHILxi0Iay7SCZ+Q==", "f7ef7fdd-196a-41e2-97e2-7a43e37ea298" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b61d988-ed59-4a7e-91b8-3706070696eb", "AQAAAAIAAYagAAAAEKbLWDOxXa79q6zMHyGtVdjSabH83heYWCJ9LcsIATg5M7uZN+uXyoIhp8/x/KDBmg==", "7485bb0c-1827-465f-aba7-92c9286620fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "602d5f47-41b5-4bf2-af68-d2879fdec002", "AQAAAAIAAYagAAAAEEHwy0jj/Vc+8C2EqyBN2gpFl8I2LvmZt2GNmYXKbqvuFhHFVEbP1ZqWHa/58gYusw==", "04b0d31f-dead-4a65-ad7a-1f80353fb852" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac3bdff5-4ca0-4956-8236-e5750e8923ef", "AQAAAAIAAYagAAAAEAgCFdxEA+HSUVILqoNatlRn3sLZDDjhLZcNY27t+K1yf9wYILFzzt/FIASUipwdiQ==", "80212422-62fd-43c2-b1a3-93287a9ca87c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8d24cb1-81ab-4614-9240-70616b761a51", "AQAAAAIAAYagAAAAEFESP6yPTD+xgTtnZiUgShF97IwryUlDTiaMLjEYER3cIk9uPTiCQEob6LAOqnfECQ==", "1cada4f4-1327-4b06-b59f-015b99082840" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e9799b8-ba6c-4c1a-b9f7-6ae885719ebc", "AQAAAAIAAYagAAAAENk2biDOsbSqbjNJp8xqGSGPI56Jk3QaOx94ZbjyCTWtsHsI61vTQzJQ4EfUMVU0ig==", "6d815733-1310-44ff-b505-8ad761c0208c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16a22a22-9a2d-450c-a4dc-2cb8cb137fee", "AQAAAAIAAYagAAAAEAppDoRrlc82IzwuYwIJ0iBifouGPc5MmDHOsb099Bnq2GguVVOXkdq7Sh3ypD0TFg==", "8360636c-3a06-4ba0-82db-01065262ef1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1afdef5d-5aad-42bc-9f3d-66e060cd06a3", "AQAAAAIAAYagAAAAEAgohlkpl4XV+QC3kZEZdTfFjhuo3yLBoeQ+fekBXDJa1r/nVMc474J/kxyYlcQRJw==", "ba14288b-18c2-42f5-b950-c930de3ab239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4751cb8-e4b5-4d2e-9e7b-d00a0c2fc244", "AQAAAAIAAYagAAAAEGBGlHQORq4ZBKb/hTx1nAX05BruNbHSVRl/tNiP4tqQctdqTxolj5lZk7zkY7gRLg==", "d292d9e9-e1ea-4235-9ab2-c218eb5ac3dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb8161f1-7a42-47f9-b511-78774faa05ba", "AQAAAAIAAYagAAAAEIbWpwmiOeZ+x3h0xMDzGTzqkj9hqFe/0MmPeigWjBXogawhUDQFks3/J4BwJrSnzA==", "47e1d005-0659-42b6-a916-66df0850a2aa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
        }
    }
}
