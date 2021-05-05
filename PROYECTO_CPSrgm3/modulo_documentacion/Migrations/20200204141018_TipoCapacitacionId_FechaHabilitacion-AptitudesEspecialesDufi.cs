using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class TipoCapacitacionId_FechaHabilitacionAptitudesEspecialesDufi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AptEspDufi_AptitudEspecial_AptitudEspecialId",
                table: "AptEspDufi");

            migrationBuilder.DropForeignKey(
                name: "FK_AptEspDufi_TipoCapacitacion_TipoCapacitacionId",
                table: "AptEspDufi");

            migrationBuilder.DropIndex(
                name: "IX_AptEspDufi_AptitudEspecialId",
                table: "AptEspDufi");

            migrationBuilder.DropIndex(
                name: "IX_AptEspDufi_TipoCapacitacionId",
                table: "AptEspDufi");

            migrationBuilder.DropColumn(
                name: "AptitudEspecialId",
                table: "AptEspDufi");

            migrationBuilder.AlterColumn<int>(
                name: "TipoCapacitacionId",
                table: "AptEspDufi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHabilitacion",
                table: "AptEspDufi",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoCapacitacionId",
                table: "AptEspDufi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHabilitacion",
                table: "AptEspDufi",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AptitudEspecialId",
                table: "AptEspDufi",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AptEspDufi_AptitudEspecialId",
                table: "AptEspDufi",
                column: "AptitudEspecialId");

            migrationBuilder.CreateIndex(
                name: "IX_AptEspDufi_TipoCapacitacionId",
                table: "AptEspDufi",
                column: "TipoCapacitacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AptEspDufi_AptitudEspecial_AptitudEspecialId",
                table: "AptEspDufi",
                column: "AptitudEspecialId",
                principalTable: "AptitudEspecial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AptEspDufi_TipoCapacitacion_TipoCapacitacionId",
                table: "AptEspDufi",
                column: "TipoCapacitacionId",
                principalTable: "TipoCapacitacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
