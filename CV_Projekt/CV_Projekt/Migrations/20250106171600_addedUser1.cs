using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class addedUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "98620659-46ce-4e9d-88e3-755b377f5006", "7ccba581-94ea-4372-9ed8-0397b2af16a6", "aliA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "a11ce28d-cc22-45cb-a7ce-f8c26160ac96", "bf0dc5f7-d093-4f63-adc7-2d66f1eb064f", "BobbieB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "ea89db58-55a8-4e5c-8552-b32e1aabc5be", "fbebd9a4-6a09-419f-ba1c-56dd9b0e9859", "Charlie" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "10175356-61ec-43aa-956c-b3b28ac1ab22", "fc77d281-e848-42cc-b732-63865111ba7b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "0d0e2e75-694f-4227-89c6-65f10cb5054c", "7e1027cb-b260-4f2e-a1fd-2ffbe1183d55", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "b44bd884-358f-47d7-981f-522d2caebb3c", "e524b500-955b-4f7c-b7b7-cbda196b2f6c", null });
        }
    }
}
