using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class DDJJ_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeclaracionJurada_Persona_PersonaID",
                table: "DeclaracionJurada");

            migrationBuilder.DropIndex(
                name: "IX_DeclaracionJurada_PersonaID",
                table: "DeclaracionJurada");

            migrationBuilder.DropColumn(
                name: "PersonaID",
                table: "DeclaracionJurada");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "DeclaracionJurada",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_UsuarioId",
                table: "DeclaracionJurada",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeclaracionJurada_AspNetUsers_UsuarioId",
                table: "DeclaracionJurada",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeclaracionJurada_AspNetUsers_UsuarioId",
                table: "DeclaracionJurada");

            migrationBuilder.DropIndex(
                name: "IX_DeclaracionJurada_UsuarioId",
                table: "DeclaracionJurada");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "DeclaracionJurada");

            migrationBuilder.AddColumn<int>(
                name: "PersonaID",
                table: "DeclaracionJurada",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_PersonaID",
                table: "DeclaracionJurada",
                column: "PersonaID");

            migrationBuilder.AddForeignKey(
                name: "FK_DeclaracionJurada_Persona_PersonaID",
                table: "DeclaracionJurada",
                column: "PersonaID",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
