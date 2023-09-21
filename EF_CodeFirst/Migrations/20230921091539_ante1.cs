using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class ante1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeId", "GradeName", "Section", "StudentId" },
                values: new object[,]
                {
                    { 1, "Prvi", "a", 1 },
                    { 2, "Drugi", "b", 1 },
                    { 3, "Treci", "c", 2 },
                    { 4, "Cetvrti", "d", 1 },
                    { 5, "Peti", "e", 1 },
                    { 6, "Sesti", "f", 1 },
                    { 7, "Sedmi", "g", 2 },
                    { 8, "Osmi", "h", 2 }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, "Ante", 105f },
                    { 2, new DateTime(2002, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, "Marija", 56f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
