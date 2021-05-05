using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class OtraSituacionLaboral_Impedimiento_Familiar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Impedimiento",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtraSituacion",
                table: "Persona",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Impedimiento",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "OtraSituacion",
                table: "Persona");
        }
    }
}
