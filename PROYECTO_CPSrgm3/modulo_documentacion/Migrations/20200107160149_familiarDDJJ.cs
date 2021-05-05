using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class familiarDDJJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
