using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e183eb37-db5f-477c-b0f3-1a6f0956256b", "83d5cc08-e3d1-4218-b4b3-7e44df7134f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8736ec1-304d-488b-b294-995a84df71d3", "a0e589fb-8fe5-42c4-815c-32f001672fdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93fb4a19-5b5e-456d-80e1-c6044bc8ffae", "87e942e4-6903-46cf-a9ef-66f46305469b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
