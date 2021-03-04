using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class DbNuevaanasei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LineaId",
                table: "Equipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanesId",
                table: "Equipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Linea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Plan = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_LineaId",
                table: "Equipo",
                column: "LineaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_PlanesId",
                table: "Equipo",
                column: "PlanesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Linea_LineaId",
                table: "Equipo",
                column: "LineaId",
                principalTable: "Linea",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Linea_LineaId",
                table: "Equipo");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Planes_PlanesId",
                table: "Equipo");

            migrationBuilder.DropTable(
                name: "Linea");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_LineaId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_PlanesId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "LineaId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "PlanesId",
                table: "Equipo");
        }
    }
}
