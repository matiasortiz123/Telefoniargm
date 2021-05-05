using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class DUFI_Albacea_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albacea_Persona_PersonaId",
                table: "Albacea");

            migrationBuilder.DropForeignKey(
                name: "FK_Dufi_Persona_PersonaId",
                table: "Dufi");

            migrationBuilder.DropIndex(
                name: "IX_Dufi_PersonaId",
                table: "Dufi");

            migrationBuilder.DropIndex(
                name: "IX_Albacea_PersonaId",
                table: "Albacea");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Dufi");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Albacea");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Dufi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Albacea",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dufi_UsuarioId",
                table: "Dufi",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Albacea_UsuarioId",
                table: "Albacea",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albacea_AspNetUsers_UsuarioId",
                table: "Albacea",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dufi_AspNetUsers_UsuarioId",
                table: "Dufi",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albacea_AspNetUsers_UsuarioId",
                table: "Albacea");

            migrationBuilder.DropForeignKey(
                name: "FK_Dufi_AspNetUsers_UsuarioId",
                table: "Dufi");

            migrationBuilder.DropIndex(
                name: "IX_Dufi_UsuarioId",
                table: "Dufi");

            migrationBuilder.DropIndex(
                name: "IX_Albacea_UsuarioId",
                table: "Albacea");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Dufi");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Albacea");

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Dufi",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Albacea",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dufi_PersonaId",
                table: "Dufi",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Albacea_PersonaId",
                table: "Albacea",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albacea_Persona_PersonaId",
                table: "Albacea",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dufi_Persona_PersonaId",
                table: "Dufi",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
