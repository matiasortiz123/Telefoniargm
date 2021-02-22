using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class DependenciaUnidadNuevo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadId",
                table: "Dependencia",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia",
                column: "UnidadId",
                principalTable: "Unidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadId",
                table: "Dependencia",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia",
                column: "UnidadId",
                principalTable: "Unidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
