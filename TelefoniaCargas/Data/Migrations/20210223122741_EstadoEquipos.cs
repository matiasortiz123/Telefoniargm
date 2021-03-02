using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class EstadoEquipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoEquipoId",
                table: "Equipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EstadoEquipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Disponible = table.Column<string>(nullable: true),
                    NoDisponible = table.Column<string>(nullable: true),
                    EnMantenimiento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoEquipo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EstadoEquipoId",
                table: "Equipo",
                column: "EstadoEquipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_EstadoEquipo_EstadoEquipoId",
                table: "Equipo",
                column: "EstadoEquipoId",
                principalTable: "EstadoEquipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_EstadoEquipo_EstadoEquipoId",
                table: "Equipo");

            migrationBuilder.DropTable(
                name: "EstadoEquipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_EstadoEquipoId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "EstadoEquipoId",
                table: "Equipo");
        }
    }
}
