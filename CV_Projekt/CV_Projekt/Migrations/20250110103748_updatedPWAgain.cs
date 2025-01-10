using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedPWAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a025e52-8bd4-4c3d-8b18-ad52b675cfd8", "020b4926-4011-4055-9673-6af6eed66b2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30c2a46f-2917-41ca-a2dc-698c7feef951", "90df8617-04a8-4f0c-ab4f-30dd5d1b3616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bae7dce-b0c4-49c3-a6e9-35aab74223bf", "ec7fd55a-a06b-49de-981a-8aa88346e617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7e6f7f9-5a17-4c8f-a642-98e418a006a0", "2e2de5c7-029f-48da-8c1e-e21215a1f952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8f08276-51b0-4b9c-abd1-6c17d2c756f3", "2b9aa51b-a8d0-42fb-891b-160b724be6a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f6ab7dd-2737-46d1-9ff4-4f38c7f66567", "7fcb5256-85c7-423b-a905-cc2e7b544e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aaf0f7c0-cd56-4803-ba8e-449054604b33", "f4c1b34f-d307-4a1b-8849-f686600e355c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5840bee-02f6-40c7-81c9-1b10c266221e", "719d0613-b097-4999-9db8-93f50c1b7de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24e791d0-8f0b-4f5f-91c8-31414025acd8", "3f83e834-d979-489b-b134-63d2765d1d88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0127ab32-c71a-4d59-ab30-f98687cb4e74", "a8dc1b33-0fac-4d13-bb03-93b00f0b648e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
