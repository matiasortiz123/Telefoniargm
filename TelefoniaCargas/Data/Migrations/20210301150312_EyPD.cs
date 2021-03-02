using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class EyPD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Persona_DependenciaId",
                table: "Equipo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Persona_DependenciaId",
                table: "Equipo",
                column: "Persona_DependenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Persona_Dependencia_Persona_DependenciaId",
                table: "Equipo",
                column: "Persona_DependenciaId",
                principalTable: "Persona_Dependencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Persona_Dependencia_Persona_DependenciaId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_Persona_DependenciaId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "Persona_DependenciaId",
                table: "Equipo");
        }
    }
}
