using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class Observacion_Bitacora_DJJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "DeclaracionJurada",
                newName: "ObservacionActual");

            migrationBuilder.AddColumn<int>(
                name: "TipoBitacora",
                table: "Bitacora",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoBitacora",
                table: "Bitacora");

            migrationBuilder.RenameColumn(
                name: "ObservacionActual",
                table: "DeclaracionJurada",
                newName: "Descripcion");
        }
    }
}
