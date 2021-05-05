using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class ProyectoLimpio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Persona_PersonaId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Genero_GeneroID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoDocumento_TipoDocumentoID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Unidad_UnidadId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Domicilio_DomicilioID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Escolaridad_EscolaridadID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_EstadoCivil_EstadoCivilID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Fuerza_FuerzaID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Grado_GradoID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Localidad_LocalidadDefuncionID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Localidad_LocalidadEmpleadorID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Parentesco_ParentescoID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Provincia_ProvinciaDefuncionID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Provincia_ProvinciaEmpleadorID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_SituacionLaboral_SituacionLaboralID",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Unidad_Guarnicion_GuarnicionId",
                table: "Unidad");

            migrationBuilder.DropTable(
                name: "AptEspDufi");

            migrationBuilder.DropTable(
                name: "AptitudEspecial");

            migrationBuilder.DropTable(
                name: "Bitacora");

            migrationBuilder.DropTable(
                name: "CargoActual");

            migrationBuilder.DropTable(
                name: "CargoDocenteProf");

            migrationBuilder.DropTable(
                name: "CausaJudicialDDJJ");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "ConductorMotorista");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "CursosEspDufi");

            migrationBuilder.DropTable(
                name: "DestinoFuturo");

            migrationBuilder.DropTable(
                name: "Documentacion");

            migrationBuilder.DropTable(
                name: "Domicilio");

            migrationBuilder.DropTable(
                name: "EstudioDDJJ");

            migrationBuilder.DropTable(
                name: "ExpedienteCD");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Grado");

            migrationBuilder.DropTable(
                name: "GuarnicionFuturo");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "IdiomaDufi");

            migrationBuilder.DropTable(
                name: "MisionComExt");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "PersonaAlbacea");

            migrationBuilder.DropTable(
                name: "PersonaAviso");

            migrationBuilder.DropTable(
                name: "RegistroConductorDufi");

            migrationBuilder.DropTable(
                name: "Seguro");

            migrationBuilder.DropTable(
                name: "SituacionLaboral");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Vivienda");

            migrationBuilder.DropTable(
                name: "TipoCapacitacion");

            migrationBuilder.DropTable(
                name: "TipoExpediente");

            migrationBuilder.DropTable(
                name: "TipoContacto");

            migrationBuilder.DropTable(
                name: "CursoEspecial");

            migrationBuilder.DropTable(
                name: "Parentesco");

            migrationBuilder.DropTable(
                name: "TipoDocumentoAdjunto");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Escolaridad");

            migrationBuilder.DropTable(
                name: "Fuerza");

            migrationBuilder.DropTable(
                name: "Dufi");

            migrationBuilder.DropTable(
                name: "TipoRegistroConductor");

            migrationBuilder.DropTable(
                name: "Albacea");

            migrationBuilder.DropTable(
                name: "DeclaracionJurada");

            migrationBuilder.DropTable(
                name: "Guarnicion");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "SituacionFamiliar");

            migrationBuilder.DropIndex(
                name: "IX_Unidad_GuarnicionId",
                table: "Unidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_GeneroID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_TipoDocumentoID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_DeclaracionJuradaID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_DomicilioID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_EscolaridadID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_EstadoCivilID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_FuerzaID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_GradoID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_LocalidadDefuncionID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_LocalidadEmpleadorID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_ParentescoID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_ProvinciaDefuncionID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_ProvinciaEmpleadorID",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_SituacionLaboralID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "NombreExtendido",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Antiguedad",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Convive",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "DeclaracionJuradaID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "DomicilioID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "EscolaridadID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "EstadoCivilID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "FechaDefuncion",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "FuerzaID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Impedido",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "ParentescoID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "SituacionLaboralID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "TieneIOSFA",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Vive",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "ViveExtranjero",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "PersonalMilitar");

            migrationBuilder.RenameColumn(
                name: "GradoID",
                table: "PersonalMilitar",
                newName: "GradoId");

            migrationBuilder.RenameColumn(
                name: "ProvinciaEmpleadorID",
                table: "PersonalMilitar",
                newName: "UnidadInstSupId");

            migrationBuilder.RenameColumn(
                name: "ProvinciaDefuncionID",
                table: "PersonalMilitar",
                newName: "UnidadComisionId");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "PersonalMilitar",
                newName: "Uuid");

            migrationBuilder.RenameColumn(
                name: "OtraSituacion",
                table: "PersonalMilitar",
                newName: "UnidadInstSupDescripcion");

            migrationBuilder.RenameColumn(
                name: "NroIOSFA",
                table: "PersonalMilitar",
                newName: "UnidadInstSupAbreviatura");

            migrationBuilder.RenameColumn(
                name: "LocalidadEmpleadorID",
                table: "PersonalMilitar",
                newName: "OrdenMerito");

            migrationBuilder.RenameColumn(
                name: "LocalidadDefuncionID",
                table: "PersonalMilitar",
                newName: "ArmaId");

            migrationBuilder.RenameColumn(
                name: "Impedimiento",
                table: "PersonalMilitar",
                newName: "UnidadDescripcion");

            migrationBuilder.RenameColumn(
                name: "Empleador",
                table: "PersonalMilitar",
                newName: "UnidadComisionDescripcion");

            migrationBuilder.RenameColumn(
                name: "Destino",
                table: "PersonalMilitar",
                newName: "UnidadComisionAbreviatura");

            migrationBuilder.RenameColumn(
                name: "TipoDocumentoID",
                table: "PersonalMilitar",
                newName: "GradoPeso");

            migrationBuilder.RenameColumn(
                name: "GeneroID",
                table: "PersonalMilitar",
                newName: "Dni");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "PersonalMilitar",
                newName: "UnidadAbreviatura");

            migrationBuilder.RenameColumn(
                name: "Cuil",
                table: "PersonalMilitar",
                newName: "SituacionRevista");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_UnidadId",
                table: "PersonalMilitar",
                newName: "IX_PersonalMilitar_UnidadId");

            migrationBuilder.AlterColumn<int>(
                name: "GradoId",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnidadId",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EsJefeUnidad",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EsJefePersonal",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EsAuxiliarUnidad",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EsAuxiliarPersonal",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NroDocumento",
                table: "PersonalMilitar",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "PersonalMilitar",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "PersonalMilitar",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ArmaAbreviatura",
                table: "PersonalMilitar",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacim",
                table: "PersonalMilitar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FraccionGrado",
                table: "PersonalMilitar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GradoAbreviatura",
                table: "PersonalMilitar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "PersonalMilitar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalMilitar",
                table: "PersonalMilitar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonalMilitar_PersonaId",
                table: "AspNetUsers",
                column: "PersonaId",
                principalTable: "PersonalMilitar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalMilitar_Unidad_UnidadId",
                table: "PersonalMilitar",
                column: "UnidadId",
                principalTable: "Unidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonalMilitar_PersonaId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalMilitar_Unidad_UnidadId",
                table: "PersonalMilitar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalMilitar",
                table: "PersonalMilitar");

            migrationBuilder.DropColumn(
                name: "ArmaAbreviatura",
                table: "PersonalMilitar");

            migrationBuilder.DropColumn(
                name: "FechaNacim",
                table: "PersonalMilitar");

            migrationBuilder.DropColumn(
                name: "FraccionGrado",
                table: "PersonalMilitar");

            migrationBuilder.DropColumn(
                name: "GradoAbreviatura",
                table: "PersonalMilitar");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "PersonalMilitar");

            migrationBuilder.RenameTable(
                name: "PersonalMilitar",
                newName: "Persona");

            migrationBuilder.RenameColumn(
                name: "GradoId",
                table: "Persona",
                newName: "GradoID");

            migrationBuilder.RenameColumn(
                name: "Uuid",
                table: "Persona",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "UnidadInstSupId",
                table: "Persona",
                newName: "ProvinciaEmpleadorID");

            migrationBuilder.RenameColumn(
                name: "UnidadInstSupDescripcion",
                table: "Persona",
                newName: "OtraSituacion");

            migrationBuilder.RenameColumn(
                name: "UnidadInstSupAbreviatura",
                table: "Persona",
                newName: "NroIOSFA");

            migrationBuilder.RenameColumn(
                name: "UnidadDescripcion",
                table: "Persona",
                newName: "Impedimiento");

            migrationBuilder.RenameColumn(
                name: "UnidadComisionId",
                table: "Persona",
                newName: "ProvinciaDefuncionID");

            migrationBuilder.RenameColumn(
                name: "UnidadComisionDescripcion",
                table: "Persona",
                newName: "Empleador");

            migrationBuilder.RenameColumn(
                name: "UnidadComisionAbreviatura",
                table: "Persona",
                newName: "Destino");

            migrationBuilder.RenameColumn(
                name: "UnidadAbreviatura",
                table: "Persona",
                newName: "Foto");

            migrationBuilder.RenameColumn(
                name: "SituacionRevista",
                table: "Persona",
                newName: "Cuil");

            migrationBuilder.RenameColumn(
                name: "OrdenMerito",
                table: "Persona",
                newName: "LocalidadEmpleadorID");

            migrationBuilder.RenameColumn(
                name: "GradoPeso",
                table: "Persona",
                newName: "TipoDocumentoID");

            migrationBuilder.RenameColumn(
                name: "Dni",
                table: "Persona",
                newName: "GeneroID");

            migrationBuilder.RenameColumn(
                name: "ArmaId",
                table: "Persona",
                newName: "LocalidadDefuncionID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalMilitar_UnidadId",
                table: "Persona",
                newName: "IX_Persona_UnidadId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Estado",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreExtendido",
                table: "Estado",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnidadId",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NroDocumento",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Persona",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GradoID",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "EsJefeUnidad",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "EsJefePersonal",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "EsAuxiliarUnidad",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "EsAuxiliarPersonal",
                table: "Persona",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Persona",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Antiguedad",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Convive",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeclaracionJuradaID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomicilioID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EscolaridadID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivilID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDefuncion",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuerzaID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Impedido",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentescoID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SituacionLaboralID",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TieneIOSFA",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Vive",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ViveExtranjero",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Albacea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatosAlbacea = table.Column<string>(nullable: true),
                    DniAlbacea = table.Column<int>(nullable: true),
                    EstadoId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    GradoAlbacea = table.Column<string>(nullable: true),
                    UnidadAlbacea = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albacea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albacea_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albacea_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CursoEspecial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoEspecial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeseaOOMMP = table.Column<byte>(nullable: true),
                    EstadoId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaElevacionDGP = table.Column<DateTime>(nullable: false),
                    FechaElevacionJefeElemento = table.Column<DateTime>(nullable: false),
                    FechaElevacionJefePersonal = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dufi_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dufi_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Escolaridad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuerza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuerza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guarnicion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoZona = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarnicion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    IdDepartamento = table.Column<int>(nullable: false),
                    IdProvincia = table.Column<int>(nullable: false),
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    ProvinciaNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parentesco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentesco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonaAlbacea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbreviaturaUnidad = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Grado = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Unidad = table.Column<string>(nullable: true),
                    dni = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaAlbacea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    DescripcionCompleta = table.Column<string>(nullable: true),
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SituacionFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacionFamiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SituacionLaboral",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacionLaboral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCapacitacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCapacitacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContacto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContacto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoAdjunto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentoAdjunto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoExpediente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoExpediente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoRegistroConductor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRegistroConductor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbaceaId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentario_Albacea_AlbaceaId",
                        column: x => x.AlbaceaId,
                        principalTable: "Albacea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaAviso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbaceaId = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaAviso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaAviso_Albacea_AlbaceaId",
                        column: x => x.AlbaceaId,
                        principalTable: "Albacea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbaceaId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Entidad = table.Column<string>(nullable: true),
                    NroPoliza = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguro_Albacea_AlbaceaId",
                        column: x => x.AlbaceaId,
                        principalTable: "Albacea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptEspDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AptEspId = table.Column<int>(nullable: false),
                    DufiId = table.Column<int>(nullable: false),
                    FechaHabilitacion = table.Column<DateTime>(nullable: true),
                    TipoCapacitacionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptEspDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AptEspDufi_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CargoActual",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CargoDeseado = table.Column<string>(maxLength: 50, nullable: false),
                    CargoOcupa = table.Column<string>(maxLength: 50, nullable: false),
                    DufiId = table.Column<int>(nullable: false),
                    TiempoCargo = table.Column<int>(nullable: false),
                    TiempoDestino = table.Column<int>(nullable: false),
                    TiempoGuarnicion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoActual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoActual_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CargoDocenteProf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    DufiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDocenteProf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoDocenteProf_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConductorMotorista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    FechaUltimaRenovacion = table.Column<DateTime>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    LicenciaConducir = table.Column<byte>(nullable: false)
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
                name: "CursosEspDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoEspecialId = table.Column<int>(nullable: false),
                    DufiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosEspDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursosEspDufi_CursoEspecial_CursoEspecialId",
                        column: x => x.CursoEspecialId,
                        principalTable: "CursoEspecial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosEspDufi_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpedienteCD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActualizoExpediente = table.Column<byte>(nullable: true),
                    CausaExpediente = table.Column<string>(nullable: true),
                    DufiId = table.Column<int>(nullable: false),
                    NroExpediente = table.Column<string>(nullable: true),
                    NroExpedienteAct = table.Column<string>(nullable: true),
                    TieneExpediente = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedienteCD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpedienteCD_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdiomaDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    FechaAcreditacion = table.Column<DateTime>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    IdiomaId = table.Column<int>(nullable: true),
                    IdiomaOtro = table.Column<string>(nullable: true),
                    Nivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdiomaDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdiomaDufi_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MisionComExt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cargo = table.Column<string>(nullable: true),
                    DufiId = table.Column<int>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    Mision = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisionComExt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MisionComExt_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abreviatura = table.Column<string>(nullable: true),
                    AbreviaturaGenerica = table.Column<string>(nullable: true),
                    Codigo = table.Column<int>(nullable: false),
                    FuerzaID = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grado_Fuerza_FuerzaID",
                        column: x => x.FuerzaID,
                        principalTable: "Fuerza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuarnicionFuturo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeseaGuarnicion1 = table.Column<string>(nullable: true),
                    DeseaGuarnicion2 = table.Column<string>(nullable: true),
                    DeseaGuarnicion3 = table.Column<string>(nullable: true),
                    DufiId = table.Column<int>(nullable: false),
                    GuarnicionId = table.Column<int>(nullable: true),
                    PermanecerGuarnicion = table.Column<int>(nullable: false),
                    UltimaZona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuarnicionFuturo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuarnicionFuturo_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuarnicionFuturo_Guarnicion_GuarnicionId",
                        column: x => x.GuarnicionId,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DestinoFuturo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeseaCambioDestino = table.Column<byte>(nullable: false),
                    DeseaCambioGuarnicion = table.Column<byte>(nullable: false),
                    DufiId = table.Column<int>(nullable: false),
                    Fundamento = table.Column<string>(nullable: true),
                    GuarnicionId = table.Column<int>(nullable: true),
                    OpinionFutura = table.Column<string>(nullable: true),
                    ParentescoId = table.Column<int>(nullable: true),
                    VinculoAfectivo = table.Column<int>(nullable: false),
                    VinculoParentesco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinoFuturo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DestinoFuturo_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinoFuturo_Guarnicion_GuarnicionId",
                        column: x => x.GuarnicionId,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DestinoFuturo_Parentesco_ParentescoId",
                        column: x => x.ParentescoId,
                        principalTable: "Parentesco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    SituacionFamiliarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadoCivil_SituacionFamiliar_SituacionFamiliarId",
                        column: x => x.SituacionFamiliarId,
                        principalTable: "SituacionFamiliar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AptitudEspecial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoCapacitacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptitudEspecial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AptitudEspecial_TipoCapacitacion_TipoCapacitacionId",
                        column: x => x.TipoCapacitacionId,
                        principalTable: "TipoCapacitacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "DeclaracionJurada",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstadoCivilID = table.Column<int>(nullable: true),
                    EstadoID = table.Column<int>(nullable: false),
                    FechaCasamiento = table.Column<DateTime>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    ObservacionActual = table.Column<string>(nullable: true),
                    OtraSituacionFamiliar = table.Column<string>(nullable: true),
                    SituacionFamiliarID = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeclaracionJurada", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeclaracionJurada_EstadoCivil_EstadoCivilID",
                        column: x => x.EstadoCivilID,
                        principalTable: "EstadoCivil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeclaracionJurada_Estado_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeclaracionJurada_SituacionFamiliar_SituacionFamiliarID",
                        column: x => x.SituacionFamiliarID,
                        principalTable: "SituacionFamiliar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeclaracionJurada_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bitacora",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    FechaHora = table.Column<DateTime>(nullable: false),
                    TipoBitacora = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: true),
                    DeclaracionJuradaID = table.Column<int>(nullable: true),
                    TextoAdicional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bitacora_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bitacora_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CausaJudicialDDJJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caratula = table.Column<string>(nullable: true),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    Expediente = table.Column<string>(nullable: true),
                    Juzgado = table.Column<string>(nullable: true),
                    SituacionJudicial = table.Column<string>(nullable: true),
                    TipoExpedienteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CausaJudicialDDJJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CausaJudicialDDJJ_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CausaJudicialDDJJ_TipoExpediente_TipoExpedienteID",
                        column: x => x.TipoExpedienteID,
                        principalTable: "TipoExpediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Discriminator = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NumeroTel = table.Column<string>(nullable: true),
                    PrefijoTel = table.Column<string>(nullable: true),
                    TipoContactoID = table.Column<int>(nullable: false),
                    DeclaracionJuradaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacto_TipoContacto_TipoContactoID",
                        column: x => x.TipoContactoID,
                        principalTable: "TipoContacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacto_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documentacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adjunto = table.Column<byte[]>(nullable: true),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    Fojas = table.Column<int>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    TipoDocumentoAdjuntoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentacion_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documentacion_TipoDocumentoAdjunto_TipoDocumentoAdjuntoID",
                        column: x => x.TipoDocumentoAdjuntoID,
                        principalTable: "TipoDocumentoAdjunto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altura = table.Column<string>(maxLength: 5, nullable: true),
                    Busquedamapa = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(maxLength: 50, nullable: true),
                    CodigoPostal = table.Column<string>(maxLength: 8, nullable: true),
                    Departamento = table.Column<string>(maxLength: 4, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Latitud = table.Column<string>(nullable: true),
                    LocalidadId = table.Column<int>(nullable: true),
                    LocalidadStr = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    Manzana = table.Column<string>(maxLength: 10, nullable: true),
                    Piso = table.Column<string>(maxLength: 2, nullable: true),
                    ProvinciaId = table.Column<int>(nullable: true),
                    ProvinciaStr = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(maxLength: 10, nullable: true),
                    Torre = table.Column<string>(maxLength: 10, nullable: true),
                    DeclaracionJuradaID = table.Column<int>(nullable: true),
                    LocalidadExterior = table.Column<string>(nullable: true),
                    NroIOSFA = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    ProvinciaExterior = table.Column<string>(nullable: true),
                    ViveExterior = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Domicilio_Localidad_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Domicilio_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Domicilio_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstudioDDJJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    EscolaridadID = table.Column<int>(nullable: false),
                    Finalizado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudioDDJJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstudioDDJJ_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudioDDJJ_Escolaridad_EscolaridadID",
                        column: x => x.EscolaridadID,
                        principalTable: "Escolaridad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vivienda",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlojaUnidad = table.Column<bool>(nullable: false),
                    AlojamientoUnidadID = table.Column<int>(nullable: true),
                    Alquila = table.Column<bool>(nullable: false),
                    AlquilaDesde = table.Column<DateTime>(nullable: true),
                    AlquilaHasta = table.Column<DateTime>(nullable: true),
                    ConstruyeVivienda = table.Column<bool>(nullable: false),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    FechaConstruye = table.Column<DateTime>(nullable: true),
                    GuarnicionConstruyeID = table.Column<int>(nullable: true),
                    GuarnicionSolucionaID = table.Column<int>(nullable: true),
                    GuarnicionViviendaProxima1ID = table.Column<int>(nullable: true),
                    GuarnicionViviendaProxima2ID = table.Column<int>(nullable: true),
                    GuarnicionViviendaProxima3ID = table.Column<int>(nullable: true),
                    OcupaPropia = table.Column<bool>(nullable: false),
                    OcupaViviendaEstado = table.Column<bool>(nullable: false),
                    PoseeCreditoVivienda = table.Column<bool>(nullable: false),
                    Satisface = table.Column<bool>(nullable: false),
                    SituacionEconomica = table.Column<string>(nullable: true),
                    TiempoOcupaVivienda = table.Column<int>(nullable: true),
                    ViviendaPropia = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vivienda", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vivienda_Unidad_AlojamientoUnidadID",
                        column: x => x.AlojamientoUnidadID,
                        principalTable: "Unidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vivienda_DeclaracionJurada_DeclaracionJuradaID",
                        column: x => x.DeclaracionJuradaID,
                        principalTable: "DeclaracionJurada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vivienda_Guarnicion_GuarnicionConstruyeID",
                        column: x => x.GuarnicionConstruyeID,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vivienda_Guarnicion_GuarnicionSolucionaID",
                        column: x => x.GuarnicionSolucionaID,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vivienda_Guarnicion_GuarnicionViviendaProxima1ID",
                        column: x => x.GuarnicionViviendaProxima1ID,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vivienda_Guarnicion_GuarnicionViviendaProxima2ID",
                        column: x => x.GuarnicionViviendaProxima2ID,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vivienda_Guarnicion_GuarnicionViviendaProxima3ID",
                        column: x => x.GuarnicionViviendaProxima3ID,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_GuarnicionId",
                table: "Unidad",
                column: "GuarnicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_GeneroID",
                table: "Persona",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoDocumentoID",
                table: "Persona",
                column: "TipoDocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_DeclaracionJuradaID",
                table: "Persona",
                column: "DeclaracionJuradaID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_DomicilioID",
                table: "Persona",
                column: "DomicilioID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EscolaridadID",
                table: "Persona",
                column: "EscolaridadID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EstadoCivilID",
                table: "Persona",
                column: "EstadoCivilID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_FuerzaID",
                table: "Persona",
                column: "FuerzaID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_GradoID",
                table: "Persona",
                column: "GradoID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_LocalidadDefuncionID",
                table: "Persona",
                column: "LocalidadDefuncionID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_LocalidadEmpleadorID",
                table: "Persona",
                column: "LocalidadEmpleadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ParentescoID",
                table: "Persona",
                column: "ParentescoID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ProvinciaDefuncionID",
                table: "Persona",
                column: "ProvinciaDefuncionID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ProvinciaEmpleadorID",
                table: "Persona",
                column: "ProvinciaEmpleadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_SituacionLaboralID",
                table: "Persona",
                column: "SituacionLaboralID");

            migrationBuilder.CreateIndex(
                name: "IX_Albacea_EstadoId",
                table: "Albacea",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Albacea_UsuarioId",
                table: "Albacea",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AptEspDufi_DufiId",
                table: "AptEspDufi",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_AptitudEspecial_TipoCapacitacionId",
                table: "AptitudEspecial",
                column: "TipoCapacitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bitacora_UsuarioId",
                table: "Bitacora",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Bitacora_DeclaracionJuradaID",
                table: "Bitacora",
                column: "DeclaracionJuradaID");

            migrationBuilder.CreateIndex(
                name: "IX_CargoActual_DufiId",
                table: "CargoActual",
                column: "DufiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CargoDocenteProf_DufiId",
                table: "CargoDocenteProf",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_CausaJudicialDDJJ_DeclaracionJuradaID",
                table: "CausaJudicialDDJJ",
                column: "DeclaracionJuradaID");

            migrationBuilder.CreateIndex(
                name: "IX_CausaJudicialDDJJ_TipoExpedienteID",
                table: "CausaJudicialDDJJ",
                column: "TipoExpedienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_AlbaceaId",
                table: "Comentario",
                column: "AlbaceaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConductorMotorista_DufiId",
                table: "ConductorMotorista",
                column: "DufiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_TipoContactoID",
                table: "Contacto",
                column: "TipoContactoID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_DeclaracionJuradaID",
                table: "Contacto",
                column: "DeclaracionJuradaID");

            migrationBuilder.CreateIndex(
                name: "IX_CursosEspDufi_CursoEspecialId",
                table: "CursosEspDufi",
                column: "CursoEspecialId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosEspDufi_DufiId",
                table: "CursosEspDufi",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_EstadoCivilID",
                table: "DeclaracionJurada",
                column: "EstadoCivilID");

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_EstadoID",
                table: "DeclaracionJurada",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_SituacionFamiliarID",
                table: "DeclaracionJurada",
                column: "SituacionFamiliarID");

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_UsuarioId",
                table: "DeclaracionJurada",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinoFuturo_DufiId",
                table: "DestinoFuturo",
                column: "DufiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DestinoFuturo_GuarnicionId",
                table: "DestinoFuturo",
                column: "GuarnicionId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinoFuturo_ParentescoId",
                table: "DestinoFuturo",
                column: "ParentescoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentacion_DeclaracionJuradaID",
                table: "Documentacion",
                column: "DeclaracionJuradaID");

            migrationBuilder.CreateIndex(
                name: "IX_Documentacion_TipoDocumentoAdjuntoID",
                table: "Documentacion",
                column: "TipoDocumentoAdjuntoID");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_ProvinciaId",
                table: "Domicilio",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_DeclaracionJuradaID",
                table: "Domicilio",
                column: "DeclaracionJuradaID",
                unique: true,
                filter: "[DeclaracionJuradaID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dufi_EstadoId",
                table: "Dufi",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dufi_UsuarioId",
                table: "Dufi",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoCivil_SituacionFamiliarId",
                table: "EstadoCivil",
                column: "SituacionFamiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudioDDJJ_DeclaracionJuradaID",
                table: "EstudioDDJJ",
                column: "DeclaracionJuradaID");

            migrationBuilder.CreateIndex(
                name: "IX_EstudioDDJJ_EscolaridadID",
                table: "EstudioDDJJ",
                column: "EscolaridadID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedienteCD_DufiId",
                table: "ExpedienteCD",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_Grado_FuerzaID",
                table: "Grado",
                column: "FuerzaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuarnicionFuturo_DufiId",
                table: "GuarnicionFuturo",
                column: "DufiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GuarnicionFuturo_GuarnicionId",
                table: "GuarnicionFuturo",
                column: "GuarnicionId");

            migrationBuilder.CreateIndex(
                name: "IX_IdiomaDufi_DufiId",
                table: "IdiomaDufi",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_MisionComExt_DufiId",
                table: "MisionComExt",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaAviso_AlbaceaId",
                table: "PersonaAviso",
                column: "AlbaceaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroConductorDufi_DufiId",
                table: "RegistroConductorDufi",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroConductorDufi_TipoRegistroConductorId",
                table: "RegistroConductorDufi",
                column: "TipoRegistroConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguro_AlbaceaId",
                table: "Seguro",
                column: "AlbaceaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_AlojamientoUnidadID",
                table: "Vivienda",
                column: "AlojamientoUnidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_DeclaracionJuradaID",
                table: "Vivienda",
                column: "DeclaracionJuradaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_GuarnicionConstruyeID",
                table: "Vivienda",
                column: "GuarnicionConstruyeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_GuarnicionSolucionaID",
                table: "Vivienda",
                column: "GuarnicionSolucionaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_GuarnicionViviendaProxima1ID",
                table: "Vivienda",
                column: "GuarnicionViviendaProxima1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_GuarnicionViviendaProxima2ID",
                table: "Vivienda",
                column: "GuarnicionViviendaProxima2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vivienda_GuarnicionViviendaProxima3ID",
                table: "Vivienda",
                column: "GuarnicionViviendaProxima3ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Persona_PersonaId",
                table: "AspNetUsers",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Genero_GeneroID",
                table: "Persona",
                column: "GeneroID",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoDocumento_TipoDocumentoID",
                table: "Persona",
                column: "TipoDocumentoID",
                principalTable: "TipoDocumento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Unidad_UnidadId",
                table: "Persona",
                column: "UnidadId",
                principalTable: "Unidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Domicilio_DomicilioID",
                table: "Persona",
                column: "DomicilioID",
                principalTable: "Domicilio",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Escolaridad_EscolaridadID",
                table: "Persona",
                column: "EscolaridadID",
                principalTable: "Escolaridad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_EstadoCivil_EstadoCivilID",
                table: "Persona",
                column: "EstadoCivilID",
                principalTable: "EstadoCivil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Fuerza_FuerzaID",
                table: "Persona",
                column: "FuerzaID",
                principalTable: "Fuerza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Grado_GradoID",
                table: "Persona",
                column: "GradoID",
                principalTable: "Grado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Localidad_LocalidadDefuncionID",
                table: "Persona",
                column: "LocalidadDefuncionID",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Localidad_LocalidadEmpleadorID",
                table: "Persona",
                column: "LocalidadEmpleadorID",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Parentesco_ParentescoID",
                table: "Persona",
                column: "ParentescoID",
                principalTable: "Parentesco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Provincia_ProvinciaDefuncionID",
                table: "Persona",
                column: "ProvinciaDefuncionID",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Provincia_ProvinciaEmpleadorID",
                table: "Persona",
                column: "ProvinciaEmpleadorID",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_SituacionLaboral_SituacionLaboralID",
                table: "Persona",
                column: "SituacionLaboralID",
                principalTable: "SituacionLaboral",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Unidad_Guarnicion_GuarnicionId",
                table: "Unidad",
                column: "GuarnicionId",
                principalTable: "Guarnicion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
