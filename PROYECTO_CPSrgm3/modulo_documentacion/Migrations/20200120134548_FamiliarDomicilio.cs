using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class FamiliarDomicilio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_Localidad_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_Provincia_ProvinciaId",
                table: "Domicilio");

            migrationBuilder.AddColumn<int>(
                name: "LocalidadDefuncionID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaDefuncionID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProvinciaId",
                table: "Domicilio",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadId",
                table: "Domicilio",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Persona_LocalidadDefuncionID",
                table: "Persona",
                column: "LocalidadDefuncionID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ProvinciaDefuncionID",
                table: "Persona",
                column: "ProvinciaDefuncionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_Localidad_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_Provincia_ProvinciaId",
                table: "Domicilio",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Localidad_LocalidadDefuncionID",
                table: "Persona",
                column: "LocalidadDefuncionID",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Provincia_ProvinciaDefuncionID",
                table: "Persona",
                column: "ProvinciaDefuncionID",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_Localidad_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_Provincia_ProvinciaId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Localidad_LocalidadDefuncionID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Provincia_ProvinciaDefuncionID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_LocalidadDefuncionID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_ProvinciaDefuncionID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "LocalidadDefuncionID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "ProvinciaDefuncionID",
                table: "Persona");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinciaId",
                table: "Domicilio",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadId",
                table: "Domicilio",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_Localidad_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_Provincia_ProvinciaId",
                table: "Domicilio",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
