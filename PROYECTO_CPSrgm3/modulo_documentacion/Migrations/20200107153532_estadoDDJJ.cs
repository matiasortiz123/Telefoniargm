using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class estadoDDJJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DJuradaEstadoID",
                table: "DeclaracionJurada");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DJuradaEstadoID",
                table: "DeclaracionJurada",
                nullable: false,
                defaultValue: 0);
        }
    }
}
