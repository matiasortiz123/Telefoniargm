using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class MigracionModelosEnEquipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Modelo_ModeloId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_ModeloId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "Equipo");

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "Marca",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Marca_ModeloId",
                table: "Marca",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marca_Modelo_ModeloId",
                table: "Marca",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marca_Modelo_ModeloId",
                table: "Marca");

            migrationBuilder.DropIndex(
                name: "IX_Marca_ModeloId",
                table: "Marca");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "Marca");

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "Equipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_ModeloId",
                table: "Equipo",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Modelo_ModeloId",
                table: "Equipo",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
