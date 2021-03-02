using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefoniaCargas.Data.Migrations
{
    public partial class UnidadIdparaDepend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadId",
                table: "Dependencia",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia",
                column: "UnidadId",
                principalTable: "Unidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencia_Unidad_UnidadId",
                table: "Dependencia",
                column: "UnidadId",
                principalTable: "Unidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
