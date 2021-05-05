using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class ConductorMotirsta_y_registroConducir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeseaOOMMP",
                table: "MisionComExt");

            migrationBuilder.AddColumn<byte>(
                name: "DeseaOOMMP",
                table: "Dufi",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaElevacionDGP",
                table: "Dufi",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaElevacionJefeElemento",
                table: "Dufi",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaElevacionJefePersonal",
                table: "Dufi",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ConductorMotorista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    LicenciaConducir = table.Column<byte>(nullable: false),
                    FechaUltimaRenovacion = table.Column<DateTime>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConductorMotorista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConductorMotorista_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroConductorDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    TipoRegistro = table.Column<string>(nullable: true),
                    TipoRegistroConductorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroConductorDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroConductorDufi_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistroConductorDufi_TipoRegistroConductor_TipoRegistroConductorId",
                        column: x => x.TipoRegistroConductorId,
                        principalTable: "TipoRegistroConductor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConductorMotorista_DufiId",
                table: "ConductorMotorista",
                column: "DufiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistroConductorDufi_DufiId",
                table: "RegistroConductorDufi",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroConductorDufi_TipoRegistroConductorId",
                table: "RegistroConductorDufi",
                column: "TipoRegistroConductorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConductorMotorista");

            migrationBuilder.DropTable(
                name: "RegistroConductorDufi");

            migrationBuilder.DropColumn(
                name: "DeseaOOMMP",
                table: "Dufi");

            migrationBuilder.DropColumn(
                name: "FechaElevacionDGP",
                table: "Dufi");

            migrationBuilder.DropColumn(
                name: "FechaElevacionJefeElemento",
                table: "Dufi");

            migrationBuilder.DropColumn(
                name: "FechaElevacionJefePersonal",
                table: "Dufi");

            migrationBuilder.AddColumn<byte>(
                name: "DeseaOOMMP",
                table: "MisionComExt",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
