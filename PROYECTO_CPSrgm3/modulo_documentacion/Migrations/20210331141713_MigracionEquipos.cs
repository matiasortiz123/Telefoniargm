using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class MigracionEquipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Planes",
                newName: "NombrePlan");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Planes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Planes");

            migrationBuilder.RenameColumn(
                name: "NombrePlan",
                table: "Planes",
                newName: "Estado");
        }
    }
}
