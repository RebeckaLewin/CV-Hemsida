using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class addedUser3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd5065f7-f3f3-4152-b487-f9f5a9c60f8b", "82348ded-0e22-45d8-98f0-8143ccbf1ffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a7b1d70-d5d1-447a-bc53-657380141a93", "5c1ef76c-04af-4c1f-b3d7-18653d792ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16880a45-4172-4cf6-b83b-a70bbb0e940f", "91541c7d-c15a-47fa-85c8-cef8711a578f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98620659-46ce-4e9d-88e3-755b377f5006", "7ccba581-94ea-4372-9ed8-0397b2af16a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a11ce28d-cc22-45cb-a7ce-f8c26160ac96", "bf0dc5f7-d093-4f63-adc7-2d66f1eb064f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea89db58-55a8-4e5c-8552-b32e1aabc5be", "fbebd9a4-6a09-419f-ba1c-56dd9b0e9859" });
        }
    }
}
