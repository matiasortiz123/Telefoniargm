using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class grado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abreviatura",
                table: "Grado",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AbreviaturaGenerica",
                table: "Grado",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Grado",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abreviatura",
                table: "Grado");

            migrationBuilder.DropColumn(
                name: "AbreviaturaGenerica",
                table: "Grado");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Grado");
        }
    }
}
