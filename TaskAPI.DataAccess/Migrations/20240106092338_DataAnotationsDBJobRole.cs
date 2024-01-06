using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataAnotationsDBJobRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "BA");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 1, 11, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 1, 11, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 1, 11, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2888) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 1, 10, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 1, 10, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 1, 10, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5146) });
        }
    }
}
