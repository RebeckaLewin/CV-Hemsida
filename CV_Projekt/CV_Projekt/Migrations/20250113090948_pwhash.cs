using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class pwhash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PictureFormat",
                table: "AspNetUsers",
                newName: "PictureUrl");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f0d77c0-7644-45a6-8850-71805417de09", "AQAAAAIAAYagAAAAEKVqvYGaJ+N8MB4yaOKNshpZaZn0/3Y4mldh1to1ms4Ec0krUrZqYVQHuwSS8PxD4g==", "fd6f34e7-cfd6-4ec4-9e30-accb6ce1d0ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "316fac15-992f-476f-9d38-8c840fc55629", "AQAAAAIAAYagAAAAEItc3hnIagmCMC3tExlb6T9iQqcHTavo0uxLVc6XzYyEZj8LyfnH4QAVU6TFvb4kEg==", "4a0ee41c-6894-4826-98a9-31d680ad8db0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46d91654-4143-44a7-8636-ee49a4529a00", "AQAAAAIAAYagAAAAEHnUBgcyrW4eQ3kcsbclSwWknlVmqtBuCG2uH57p8WAK5xMVbVtKhugXIL7GNRRV6w==", "0486413f-2884-4f4c-b53e-53c3f9f9e3fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f41256d-be4e-4a42-9abf-e65e69b85b85", "AQAAAAIAAYagAAAAEATHf/mOvMeZH2BDMElH2mas5FMTAYlSRyrtlv3AiDIhPCfoLpNpBUcA7EIIVGBkDw==", "8b632387-626e-49fc-b51d-38394c4fb872" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85df35ab-05eb-4c78-9b08-1a684b41e3af", "AQAAAAIAAYagAAAAEHIyq8HiKjwzDHWpLqDbmjiJV03o5wQrCFQNcR1JEHTwc4Jm47RvSAXdrQZtYGAIRQ==", "c9628945-4685-495d-904c-95db0364b5de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cfb85aa-def1-43e5-a0b4-d7b99def642c", "AQAAAAIAAYagAAAAEK3xMFSt1X7KtJ5gealkUWFM/WNay1RmpdTQkuj8KWBdDFr1b/cFWJqLEBCXO6Sh7Q==", "26b94615-c068-431e-8466-6dea0d769eb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "686d0621-40c2-46e3-a0a3-b2fb47cad7b1", "AQAAAAIAAYagAAAAENhhGPRMcrfoL24XMBS1PCYM8xa1L5Hi4u6wki6tyoc9aVK/U5bw4QOfwZTqvwDGSQ==", "bef0fb4a-34c6-465a-9ac4-da4d7ad06792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb43d1e7-bfbd-4c4a-9c88-964ed105231e", "AQAAAAIAAYagAAAAEMywOJ3w9i5GyT+D95XeaVANX/Jcb0BClwJY2lsxJPgt7zHB83ru0jZ7mH2kb6x4Aw==", "bffc1803-b792-45e6-b024-1be6e67373fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e47ddfdf-b002-4136-8599-81f59fc7dcf6", "AQAAAAIAAYagAAAAEHw5Ze06uP8xrNRj7wI2I4aQc0eTUcl8iijXq2yzb93HO8O+ObbGhZXLGsfk/nFpiQ==", "2d80e0d1-53bf-4a46-882d-c499ac23b98f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fbf8cb2-f73c-4c8f-9f2e-c53f3d53821a", "AQAAAAIAAYagAAAAEKb+SAZwHNXXNUTiX+sTElvdUX+V62xPUubQOmAlFSHwkTG3ZUTiJGW6VTLJajULTg==", "4cb5c002-7ab0-48a4-a005-6ad98baf3261" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "AspNetUsers",
                newName: "PictureFormat");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "f913e4d1-76eb-43da-ab8d-ec65570c3101", null, null, "b1ffc7bb-da70-4f49-9fe2-0fcbd586ace4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "6b8d5ec9-f0ef-4528-a331-8e0510a1c615", null, null, "94be92c2-4de8-4e00-8403-1bcfb83be44c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "94850e4e-4cea-49e5-a0b6-21fa949e28cb", null, null, "93ff70eb-e061-45a1-9bd1-1769ef3bab87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "570bfbfd-d637-4ba8-be86-dd76da5f4abc", null, null, "bd48f91a-ca80-429a-9afb-38a6e73e125d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "f3d378d6-34ed-4317-bc10-f4173dc92e35", null, null, "4d9ab2fe-31dc-489b-9ec2-fd3c2a6972a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "4f264f15-4414-47fe-99cb-1cd10136a61f", null, null, "f97e3872-c91c-4095-afb8-7bf2791cd1b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "022f5561-fdf8-4425-a0ce-bd3a45e8d865", null, null, "e516d414-d05f-4c44-8355-9e390ac2a281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "55a3e7bb-9ede-4e0a-8e31-9ec28639845e", null, null, "a4601d58-4bda-483b-9644-f3601f0e8324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "742a4faf-d367-4e26-9652-41145769b5b8", null, null, "9f4ab1f3-122c-4cb1-bd37-668185f1ca6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "f36d5f4c-26b0-4ad2-9fdf-6b72b75347ea", null, null, "be73400e-58a3-49ab-af11-ce16989c8294" });
        }
    }
}
