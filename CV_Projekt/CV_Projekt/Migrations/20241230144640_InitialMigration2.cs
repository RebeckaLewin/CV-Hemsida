using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CVsIds",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 319, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 319, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 319, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 324, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 324, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 324, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 327, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 327, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 46, 38, 238, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 46, 38, 246, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 12, 30, 15, 46, 38, 246, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16d1c46f-8459-4a27-a471-251493a12f7f", "00777926-36ec-4e6c-8c34-3d7144c3c498" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb7f35c8-9a8b-4a54-aac0-22147cb69062", "92bee8aa-09d9-408e-9c49-65f3089c1d91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2708b83b-0614-43a7-9bc6-ad80593fb9bf", "c0fb5871-70ad-4ae4-9e97-1c7813a20e94" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CVsIds",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 719, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 719, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 719, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 723, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 723, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 723, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 726, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 727, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 12, 30, 15, 44, 46, 639, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 44, 46, 647, DateTimeKind.Local).AddTicks(1018), new DateTime(2024, 12, 30, 15, 44, 46, 647, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8101e7a7-2d73-4be9-b47d-2aaeec31d5ef", "1af0b56e-2fde-4912-8ba2-df4e43dc0ef5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62ad4815-24cf-41c8-b870-913d800f9288", "c9bdb667-e4db-423b-b3e3-317c5fc1a35b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37be7640-499c-438b-ae5d-2efecfec1fcf", "b5f40a84-433f-4e0a-8a59-b3b53b8e1957" });
        }
    }
}
