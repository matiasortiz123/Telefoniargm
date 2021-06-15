using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class NuevasVinculacionesClases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Empresa_EmpresaId",
                table: "Equipo");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Planes_PlanesId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_EmpresaId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_PlanesId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "PlanesId",
                table: "Equipo");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Planes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanesId",
                table: "Linea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Planes_EmpresaId",
                table: "Planes",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Linea_PlanesId",
                table: "Linea",
                column: "PlanesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Linea_Planes_PlanesId",
                table: "Linea",
                column: "PlanesId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Empresa_EmpresaId",
                table: "Planes",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Linea_Planes_PlanesId",
                table: "Linea");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Empresa_EmpresaId",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_EmpresaId",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Linea_PlanesId",
                table: "Linea");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "PlanesId",
                table: "Linea");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Equipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanesId",
                table: "Equipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EmpresaId",
                table: "Equipo",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_PlanesId",
                table: "Equipo",
                column: "PlanesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Empresa_EmpresaId",
                table: "Equipo",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Planes_PlanesId",
                table: "Equipo",
                column: "PlanesId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
