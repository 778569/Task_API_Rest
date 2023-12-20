using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "ID", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2023, 12, 20, 13, 52, 2, 956, DateTimeKind.Local).AddTicks(8761), "You need to get your book", new DateTime(2023, 12, 25, 13, 52, 2, 956, DateTimeKind.Local).AddTicks(8775), 0, "Get Books for the school" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
