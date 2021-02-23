using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class AsignarEquipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsignarEquipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Persona_DependenciaId = table.Column<int>(nullable: false),
                    EquipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignarEquipo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignarEquipo_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignarEquipo_Persona_Dependencia_Persona_DependenciaId",
                        column: x => x.Persona_DependenciaId,
                        principalTable: "Persona_Dependencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignarEquipo_EquipoId",
                table: "AsignarEquipo",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignarEquipo_Persona_DependenciaId",
                table: "AsignarEquipo",
                column: "Persona_DependenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignarEquipo");
        }
    }
}
