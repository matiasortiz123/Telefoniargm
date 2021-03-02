using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class Principal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    DNI = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dependencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    UnidadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependencia_Unidad_UnidadId",
                        column: x => x.UnidadId,
                        principalTable: "Unidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persona_Dependencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(nullable: false),
                    DependenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona_Dependencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Dependencia_Dependencia_DependenciaId",
                        column: x => x.DependenciaId,
                        principalTable: "Dependencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Dependencia_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependencia_UnidadId",
                table: "Dependencia",
                column: "UnidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Dependencia_DependenciaId",
                table: "Persona_Dependencia",
                column: "DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Dependencia_PersonaId",
                table: "Persona_Dependencia",
                column: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona_Dependencia");

            migrationBuilder.DropTable(
                name: "Dependencia");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Unidad");
        }
    }
}
