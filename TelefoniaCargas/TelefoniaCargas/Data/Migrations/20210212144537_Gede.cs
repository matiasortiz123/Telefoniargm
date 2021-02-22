using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class Gede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Empresa_EmpresaId",
                table: "Equipo");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_EmpresaId",
                table: "Equipo");

            migrationBuilder.AddColumn<int>(
                name: "EmpresasId",
                table: "Equipo",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Contacto = table.Column<string>(maxLength: 50, nullable: false),
                    Observacion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EmpresasId",
                table: "Equipo",
                column: "EmpresasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Empresas_EmpresasId",
                table: "Equipo",
                column: "EmpresasId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Empresas_EmpresasId",
                table: "Equipo");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_EmpresasId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "EmpresasId",
                table: "Equipo");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contacto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EmpresaId",
                table: "Equipo",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Empresa_EmpresaId",
                table: "Equipo",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
