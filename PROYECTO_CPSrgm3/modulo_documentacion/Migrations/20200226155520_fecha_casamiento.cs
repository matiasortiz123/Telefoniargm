using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class fecha_casamiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCasamiento",
                table: "Persona");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCasamiento",
                table: "DeclaracionJurada",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCasamiento",
                table: "DeclaracionJurada");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCasamiento",
                table: "Persona",
                nullable: true);
        }
    }
}
