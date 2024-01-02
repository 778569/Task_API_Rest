using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAndData : Migration
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Kavinda Bandara" },
                    { 2, "Shakuni Samanmalee" },
                    { 3, "Sam Don Karunarathne" },
                    { 4, "Harshana Disanayake" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "ID", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 2, 16, 3, 33, 74, DateTimeKind.Local).AddTicks(2374), "You need to get your book", new DateTime(2024, 1, 7, 16, 3, 33, 74, DateTimeKind.Local).AddTicks(2390), 0, "Get Books for the school" },
                    { 2, 1, new DateTime(2024, 1, 2, 16, 3, 33, 74, DateTimeKind.Local).AddTicks(2397), "You need to Super market", new DateTime(2024, 1, 7, 16, 3, 33, 74, DateTimeKind.Local).AddTicks(2397), 0, "Need to Vegitable - DB" },
                    { 3, 2, new DateTime(2024, 1, 2, 16, 3, 33, 74, DateTimeKind.Local).AddTicks(2400), "You need to go to Studio", new DateTime(2024, 1, 7, 16, 3, 33, 74, DateTimeKind.Local).AddTicks(2400), 0, "Need to Camera - DB" }
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
