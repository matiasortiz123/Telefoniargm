using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class Estado1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "EstadoEquipo");

            migrationBuilder.DropColumn(
                name: "EnMantenimiento",
                table: "EstadoEquipo");

            migrationBuilder.DropColumn(
                name: "NoDisponible",
                table: "EstadoEquipo");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "EstadoEquipo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "EstadoEquipo");

            migrationBuilder.AddColumn<string>(
                name: "Disponible",
                table: "EstadoEquipo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnMantenimiento",
                table: "EstadoEquipo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoDisponible",
                table: "EstadoEquipo",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
