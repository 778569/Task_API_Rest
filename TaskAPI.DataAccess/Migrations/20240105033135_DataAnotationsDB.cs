using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataAnotationsDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddressNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Todos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddressNo", "City", "FullName", "Street" },
                values: new object[,]
                {
                    { 1, "45", "Alawwa", "Kavinda Bandara", "Street 1" },
                    { 2, "21", "Jaffna", "Shakuni Samanmalee", "Street 2" },
                    { 3, "72", "Kurunegala", "Sam Don Karunarathne", "Street 3" },
                    { 4, "55", "Negombo", "Harshana Disanayake", "Street 1" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "ID", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 5, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5118), "You need to get your book", new DateTime(2024, 1, 10, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5135), 0, "Get Books for the school" },
                    { 2, 1, new DateTime(2024, 1, 5, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5142), "You need to Super market", new DateTime(2024, 1, 10, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5143), 0, "Need to Vegitable - DB" },
                    { 3, 2, new DateTime(2024, 1, 5, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5145), "You need to go to Studio", new DateTime(2024, 1, 10, 9, 1, 35, 78, DateTimeKind.Local).AddTicks(5146), 0, "Need to Camera - DB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
