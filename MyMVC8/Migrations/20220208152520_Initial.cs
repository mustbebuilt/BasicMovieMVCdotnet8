using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMVC8.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmTitle = table.Column<string>(type: "varchar(100)", nullable: false),
                    FilmCertificate = table.Column<string>(type: "varchar(5)", nullable: false),
                    FilmDescription = table.Column<string>(type: "text", nullable: false),
                    FilmImage = table.Column<string>(type: "varchar(100)", nullable: false),
                    FilmPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
