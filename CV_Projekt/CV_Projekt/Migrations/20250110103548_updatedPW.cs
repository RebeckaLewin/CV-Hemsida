using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedPW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d20bac1-cd01-463a-b951-40f638dd6bff", "36bddb45-e29d-460e-a0d3-75c81ab3ac7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32e8c593-bdb5-4316-8a0f-6a10c70d624b", "1bf92e55-b794-4e53-a3e6-325330687b7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57657f70-db17-4c64-9cfe-df24159a4e76", "1f196d9c-50ca-4ea3-bdfa-bf4f2f31660e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44899da1-81de-4c3e-b4be-33d8e547e089", "8f75e8ce-1a9a-4d0d-a92d-994e151db4c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cb58923-8fba-480d-b865-276c99824709", "eef3eb52-e7b1-4a8e-8b65-90a75c8de489" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73ec3303-bf15-49e5-b524-2b2638fed940", "f1f79e6f-57a5-49be-8357-76e6c4688953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b208e2dc-e3aa-4451-9b4b-61a596ddab40", "97898537-6fc0-4e12-8753-0d674bd20e80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "540ffc40-712c-4344-80ce-acd71dacc33a", "6d6f0bd6-206d-40ea-9d32-f9376b3a9abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8b0953f-390b-49f0-a26a-73ce1a593d63", "32873f6a-83b1-412e-ac15-90c9991a3aa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "865c4b27-027e-4da1-8d57-f0b737c3919d", "ed35a57b-8085-455a-9141-ee31878a8ea0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08ae0a35-d6fd-4a52-92ac-da04cc630228", "39cff57b-71f1-4e0b-87b3-6c2f51a85a15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a19d442-8fe2-4931-aacb-85dd0f96ce8c", "d910681f-e643-4d6b-ada6-520320ce5aaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ed7bc05-98c8-448a-8453-1993bf6ea991", "cb4f84e2-a2f5-4fbe-aa3c-0f73f6d50c21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca284af4-ac23-4ed7-b746-0c1fa2097b96", "9fba9708-c772-4dbc-83a4-f4f9eef6cdd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9201b6e4-1669-492c-9725-540bcbe6c8b9", "ae5d29de-109e-492a-b467-50c9a97288a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ede4033e-edc0-449a-ab22-469e21f83192", "f2b01416-85e9-40ee-bf93-24a256b3282f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e0cae15-dc0a-4b9f-bced-ec46edba4c28", "c3882472-10aa-4b1c-b2e3-ec6631060491" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69d65d17-aebc-4f55-a971-f63b6ff5709e", "0695e4e9-dc52-4bf3-aaa4-5560a22bda91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d12d8e41-75ac-44a8-91a5-c72643f96dba", "330d3b90-cf67-4699-a4b7-1e26ffc9a6f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca88468c-2bd1-4ff8-89ad-12e79e7f500a", "f0d9fa1a-cd0a-4232-b934-29e9fb54710f" });
        }
    }
}
