using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace modulo_documentacion.Migrations
{
    public partial class inicio_limpio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetFunctions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    DeletedById = table.Column<string>(nullable: true),
                    LastEditTime = table.Column<DateTime>(nullable: false),
                    LastEditById = table.Column<string>(nullable: true),
                    Display = table.Column<bool>(nullable: false),
                    Show = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RoutesJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    ShowName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    Show = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: true),
                    WorkSpaceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CursoEspecial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoEspecial", x => x.Id);
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
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    NombreExtendido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
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
                    Descripcion = table.Column<string>(nullable: true),
                    TipoZona = table.Column<int>(nullable: true),
                    Codigo = table.Column<string>(nullable: true)
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
                    Descripcion = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true)
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
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    IdDepartamento = table.Column<int>(nullable: false),
                    IdProvincia = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
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
                    dni = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Grado = table.Column<string>(nullable: true),
                    Unidad = table.Column<string>(nullable: true),
                    AbreviaturaUnidad = table.Column<string>(nullable: true)
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
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    DescripcionCompleta = table.Column<string>(nullable: true)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleFunctions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<string>(nullable: true),
                    FunctionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleFunctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleFunctions_AspNetFunctions_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "AspNetFunctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetRoleFunctions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    FuerzaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grado_Fuerza_FuerzaID",
                        column: x => x.FuerzaID,
                        principalTable: "Fuerza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Unidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoUnidad = table.Column<string>(nullable: true),
                    UnidadSuperiorId = table.Column<int>(nullable: true),
                    Abreviatura = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    GuarnicionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unidad_Guarnicion_GuarnicionId",
                        column: x => x.GuarnicionId,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Unidad_Unidad_UnidadSuperiorId",
                        column: x => x.UnidadSuperiorId,
                        principalTable: "Unidad",
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
                    Descripcion = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "PersonaAviso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbaceaId = table.Column<int>(nullable: false),
                    Dni = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaAviso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbaceaId = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Entidad = table.Column<string>(nullable: true),
                    NroPoliza = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AptEspDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    AptEspId = table.Column<int>(nullable: false),
                    FechaHabilitacion = table.Column<DateTime>(nullable: false),
                    AptitudEspecialId = table.Column<int>(nullable: true),
                    TipoCapacitacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptEspDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AptEspDufi_AptitudEspecial_AptitudEspecialId",
                        column: x => x.AptitudEspecialId,
                        principalTable: "AptitudEspecial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AptEspDufi_TipoCapacitacion_TipoCapacitacionId",
                        column: x => x.TipoCapacitacionId,
                        principalTable: "TipoCapacitacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "CursosEspDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    CursoEspecialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosEspDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursosEspDufi_CursoEspecial_CursoEspecialId",
                        column: x => x.CursoEspecialId,
                        principalTable: "CursoEspecial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CausaJudicialDDJJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    Caratula = table.Column<string>(nullable: true),
                    Expediente = table.Column<string>(nullable: true),
                    TipoExpedienteID = table.Column<int>(nullable: false),
                    SituacionJudicial = table.Column<string>(nullable: true),
                    Juzgado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CausaJudicialDDJJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CausaJudicialDDJJ_TipoExpediente_TipoExpedienteID",
                        column: x => x.TipoExpedienteID,
                        principalTable: "TipoExpediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoContactoID = table.Column<int>(nullable: false),
                    PrefijoTel = table.Column<string>(nullable: true),
                    NumeroTel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Documentacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    TipoDocumentoAdjuntoID = table.Column<int>(nullable: false),
                    Fojas = table.Column<int>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentacion_TipoDocumentoAdjunto_TipoDocumentoAdjuntoID",
                        column: x => x.TipoDocumentoAdjuntoID,
                        principalTable: "TipoDocumentoAdjunto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Adjunto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Ruta = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    DocumentacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjunto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adjunto_Documentacion_DocumentacionId",
                        column: x => x.DocumentacionId,
                        principalTable: "Documentacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calle = table.Column<string>(nullable: true),
                    Altura = table.Column<string>(nullable: true),
                    Piso = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Torre = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    Manzana = table.Column<string>(nullable: true),
                    CodigoPostal = table.Column<string>(nullable: true),
                    ProvinciaStr = table.Column<string>(nullable: true),
                    LocalidadStr = table.Column<string>(nullable: true),
                    ProvinciaId = table.Column<int>(nullable: false),
                    LocalidadId = table.Column<int>(nullable: false),
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    Busquedamapa = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    DeclaracionJuradaID = table.Column<int>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    ViveExterior = table.Column<bool>(nullable: true),
                    ProvinciaExterior = table.Column<string>(nullable: true),
                    LocalidadExterior = table.Column<string>(nullable: true),
                    NroIOSFA = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Domicilio_Localidad_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Domicilio_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EstudioDDJJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    EscolaridadID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Finalizado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudioDDJJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstudioDDJJ_Escolaridad_EscolaridadID",
                        column: x => x.EscolaridadID,
                        principalTable: "Escolaridad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDocumentoID = table.Column<int>(nullable: false),
                    NroDocumento = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    Cuil = table.Column<string>(nullable: true),
                    GeneroID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Arma = table.Column<string>(nullable: true),
                    UnidadId = table.Column<int>(nullable: true),
                    EsAuxiliarUnidad = table.Column<bool>(nullable: true),
                    EsAuxiliarPersonal = table.Column<bool>(nullable: true),
                    EsJefeUnidad = table.Column<bool>(nullable: true),
                    EsJefePersonal = table.Column<bool>(nullable: true),
                    Grado = table.Column<string>(nullable: true),
                    DeclaracionJuradaID = table.Column<int>(nullable: true),
                    EscolaridadID = table.Column<int>(nullable: true),
                    EstadoCivilID = table.Column<int>(nullable: true),
                    ParentescoID = table.Column<int>(nullable: true),
                    Vive = table.Column<bool>(nullable: true),
                    FechaDefuncion = table.Column<DateTime>(nullable: true),
                    TieneIOSFA = table.Column<bool>(nullable: true),
                    NroIOSFA = table.Column<string>(nullable: true),
                    Impedido = table.Column<bool>(nullable: true),
                    SituacionLaboralID = table.Column<int>(nullable: true),
                    FuerzaID = table.Column<int>(nullable: true),
                    GradoID = table.Column<int>(nullable: true),
                    Destino = table.Column<string>(nullable: true),
                    Antiguedad = table.Column<int>(nullable: true),
                    Empleador = table.Column<string>(nullable: true),
                    ProvinciaEmpleadorID = table.Column<int>(nullable: true),
                    LocalidadEmpleadorID = table.Column<int>(nullable: true),
                    Convive = table.Column<bool>(nullable: true),
                    ViveExtranjero = table.Column<bool>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    DomicilioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Genero_GeneroID",
                        column: x => x.GeneroID,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_TipoDocumento_TipoDocumentoID",
                        column: x => x.TipoDocumentoID,
                        principalTable: "TipoDocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Unidad_UnidadId",
                        column: x => x.UnidadId,
                        principalTable: "Unidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Domicilio_DomicilioID",
                        column: x => x.DomicilioID,
                        principalTable: "Domicilio",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Escolaridad_EscolaridadID",
                        column: x => x.EscolaridadID,
                        principalTable: "Escolaridad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_EstadoCivil_EstadoCivilID",
                        column: x => x.EstadoCivilID,
                        principalTable: "EstadoCivil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Fuerza_FuerzaID",
                        column: x => x.FuerzaID,
                        principalTable: "Fuerza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Grado_GradoID",
                        column: x => x.GradoID,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Localidad_LocalidadEmpleadorID",
                        column: x => x.LocalidadEmpleadorID,
                        principalTable: "Localidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Parentesco_ParentescoID",
                        column: x => x.ParentescoID,
                        principalTable: "Parentesco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Persona_Provincia_ProvinciaEmpleadorID",
                        column: x => x.ProvinciaEmpleadorID,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_SituacionLaboral_SituacionLaboralID",
                        column: x => x.SituacionLaboralID,
                        principalTable: "SituacionLaboral",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Albacea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    DniAlbacea = table.Column<int>(nullable: true),
                    GradoAlbacea = table.Column<string>(nullable: true),
                    DatosAlbacea = table.Column<string>(nullable: true),
                    UnidadAlbacea = table.Column<string>(nullable: true),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albacea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albacea_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Albacea_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeclaracionJurada",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    PersonaID = table.Column<int>(nullable: false),
                    DJuradaEstadoID = table.Column<int>(nullable: false),
                    EstadoCivilID = table.Column<int>(nullable: true),
                    SituacionFamiliarID = table.Column<int>(nullable: true),
                    EstadoID = table.Column<int>(nullable: false),
                    OtraSituacionFamiliar = table.Column<string>(nullable: true)
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DeclaracionJurada_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DeclaracionJurada_SituacionFamiliar_SituacionFamiliarID",
                        column: x => x.SituacionFamiliarID,
                        principalTable: "SituacionFamiliar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dufi_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Dufi_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vivienda",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeclaracionJuradaID = table.Column<int>(nullable: false),
                    ViviendaPropia = table.Column<bool>(nullable: false),
                    AlojaUnidad = table.Column<bool>(nullable: false),
                    AlojamientoUnidadID = table.Column<int>(nullable: true),
                    GuarnicionSolucionaID = table.Column<int>(nullable: true),
                    GuarnicionViviendaProxima1ID = table.Column<int>(nullable: true),
                    GuarnicionViviendaProxima2ID = table.Column<int>(nullable: true),
                    GuarnicionViviendaProxima3ID = table.Column<int>(nullable: true),
                    GuarnicionConstruyeID = table.Column<int>(nullable: true),
                    Satisface = table.Column<bool>(nullable: false),
                    OcupaPropia = table.Column<bool>(nullable: false),
                    Alquila = table.Column<bool>(nullable: false),
                    AlquilaDesde = table.Column<DateTime>(nullable: true),
                    AlquilaHasta = table.Column<DateTime>(nullable: true),
                    OcupaViviendaEstado = table.Column<bool>(nullable: false),
                    TiempoOcupaVivienda = table.Column<int>(nullable: true),
                    FechaConstruye = table.Column<DateTime>(nullable: true),
                    ConstruyeVivienda = table.Column<bool>(nullable: false),
                    PoseeCreditoVivienda = table.Column<bool>(nullable: false),
                    SituacionEconomica = table.Column<string>(nullable: true)
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
                        onDelete: ReferentialAction.NoAction);
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

            migrationBuilder.CreateTable(
                name: "CargoActual",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    TiempoGuarnicion = table.Column<int>(nullable: false),
                    TiempoDestino = table.Column<int>(nullable: false),
                    TiempoCargo = table.Column<int>(nullable: false),
                    CargoOcupa = table.Column<string>(nullable: true),
                    CargoDeseado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoActual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoActual_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CargoDocenteProf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDocenteProf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoDocenteProf_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DestinoFuturo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    VinculoAfectivo = table.Column<int>(nullable: false),
                    VinculoParentesco = table.Column<int>(nullable: false),
                    DeseaCambioGuarnicion = table.Column<byte>(nullable: false),
                    DeseaCambioDestino = table.Column<byte>(nullable: false),
                    Fundamento = table.Column<string>(nullable: true),
                    OpinionFutura = table.Column<string>(nullable: true),
                    ParentescoId = table.Column<int>(nullable: true),
                    GuarnicionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinoFuturo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DestinoFuturo_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                name: "ExpedienteCD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    TieneExpediente = table.Column<byte>(nullable: false),
                    NroExpediente = table.Column<string>(nullable: true),
                    CausaExpediente = table.Column<string>(nullable: true),
                    ActualizoExpediente = table.Column<byte>(nullable: true),
                    NroExpedienteAct = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedienteCD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpedienteCD_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GuarnicionFuturo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    DeseaGuarnicion1 = table.Column<string>(nullable: true),
                    DeseaGuarnicion2 = table.Column<string>(nullable: true),
                    DeseaGuarnicion3 = table.Column<string>(nullable: true),
                    PermanecerGuarnicion = table.Column<int>(nullable: false),
                    UltimaZona = table.Column<string>(nullable: true),
                    GuarnicionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuarnicionFuturo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuarnicionFuturo_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GuarnicionFuturo_Guarnicion_GuarnicionId",
                        column: x => x.GuarnicionId,
                        principalTable: "Guarnicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdiomaDufi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    IdiomaId = table.Column<int>(nullable: true),
                    IdiomaOtro = table.Column<string>(nullable: true),
                    Nivel = table.Column<string>(nullable: true),
                    FechaAcreditacion = table.Column<DateTime>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdiomaDufi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdiomaDufi_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MisionComExt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DufiId = table.Column<int>(nullable: false),
                    DeseaOOMMP = table.Column<byte>(nullable: false),
                    Pais = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Mision = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisionComExt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MisionComExt_Dufi_DufiId",
                        column: x => x.DufiId,
                        principalTable: "Dufi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adjunto_DocumentacionId",
                table: "Adjunto",
                column: "DocumentacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Albacea_EstadoId",
                table: "Albacea",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Albacea_PersonaId",
                table: "Albacea",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_AptEspDufi_AptitudEspecialId",
                table: "AptEspDufi",
                column: "AptitudEspecialId");

            migrationBuilder.CreateIndex(
                name: "IX_AptEspDufi_DufiId",
                table: "AptEspDufi",
                column: "DufiId");

            migrationBuilder.CreateIndex(
                name: "IX_AptEspDufi_TipoCapacitacionId",
                table: "AptEspDufi",
                column: "TipoCapacitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_AptitudEspecial_TipoCapacitacionId",
                table: "AptitudEspecial",
                column: "TipoCapacitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleFunctions_FunctionId",
                table: "AspNetRoleFunctions",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleFunctions_RoleId",
                table: "AspNetRoleFunctions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonaId",
                table: "AspNetUsers",
                column: "PersonaId");

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
                name: "IX_DeclaracionJurada_PersonaID",
                table: "DeclaracionJurada",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionJurada_SituacionFamiliarID",
                table: "DeclaracionJurada",
                column: "SituacionFamiliarID");

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
                name: "IX_Dufi_PersonaId",
                table: "Dufi",
                column: "PersonaId");

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
                name: "IX_Persona_GeneroID",
                table: "Persona",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoDocumentoID",
                table: "Persona",
                column: "TipoDocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_UnidadId",
                table: "Persona",
                column: "UnidadId");

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
                name: "IX_Persona_LocalidadEmpleadorID",
                table: "Persona",
                column: "LocalidadEmpleadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ParentescoID",
                table: "Persona",
                column: "ParentescoID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ProvinciaEmpleadorID",
                table: "Persona",
                column: "ProvinciaEmpleadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_SituacionLaboralID",
                table: "Persona",
                column: "SituacionLaboralID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaAviso_AlbaceaId",
                table: "PersonaAviso",
                column: "AlbaceaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguro_AlbaceaId",
                table: "Seguro",
                column: "AlbaceaId");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_GuarnicionId",
                table: "Unidad",
                column: "GuarnicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_UnidadSuperiorId",
                table: "Unidad",
                column: "UnidadSuperiorId");

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
                name: "FK_Comentario_Albacea_AlbaceaId",
                table: "Comentario",
                column: "AlbaceaId",
                principalTable: "Albacea",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaAviso_Albacea_AlbaceaId",
                table: "PersonaAviso",
                column: "AlbaceaId",
                principalTable: "Albacea",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Seguro_Albacea_AlbaceaId",
                table: "Seguro",
                column: "AlbaceaId",
                principalTable: "Albacea",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AptEspDufi_Dufi_DufiId",
                table: "AptEspDufi",
                column: "DufiId",
                principalTable: "Dufi",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CursosEspDufi_Dufi_DufiId",
                table: "CursosEspDufi",
                column: "DufiId",
                principalTable: "Dufi",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CausaJudicialDDJJ_DeclaracionJurada_DeclaracionJuradaID",
                table: "CausaJudicialDDJJ",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_DeclaracionJurada_DeclaracionJuradaID",
                table: "Contacto",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentacion_DeclaracionJurada_DeclaracionJuradaID",
                table: "Documentacion",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_DeclaracionJurada_DeclaracionJuradaID",
                table: "Domicilio",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudioDDJJ_DeclaracionJurada_DeclaracionJuradaID",
                table: "EstudioDDJJ",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_DeclaracionJurada_DeclaracionJuradaID",
                table: "Persona",
                column: "DeclaracionJuradaID",
                principalTable: "DeclaracionJurada",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeclaracionJurada_Estado_EstadoID",
                table: "DeclaracionJurada");

            migrationBuilder.DropForeignKey(
                name: "FK_DeclaracionJurada_Persona_PersonaID",
                table: "DeclaracionJurada");

            migrationBuilder.DropTable(
                name: "Adjunto");

            migrationBuilder.DropTable(
                name: "AptEspDufi");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoleFunctions");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CargoActual");

            migrationBuilder.DropTable(
                name: "CargoDocenteProf");

            migrationBuilder.DropTable(
                name: "CausaJudicialDDJJ");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "CursosEspDufi");

            migrationBuilder.DropTable(
                name: "DestinoFuturo");

            migrationBuilder.DropTable(
                name: "EstudioDDJJ");

            migrationBuilder.DropTable(
                name: "ExpedienteCD");

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
                name: "Seguro");

            migrationBuilder.DropTable(
                name: "Vivienda");

            migrationBuilder.DropTable(
                name: "Documentacion");

            migrationBuilder.DropTable(
                name: "AptitudEspecial");

            migrationBuilder.DropTable(
                name: "AspNetFunctions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TipoExpediente");

            migrationBuilder.DropTable(
                name: "TipoContacto");

            migrationBuilder.DropTable(
                name: "CursoEspecial");

            migrationBuilder.DropTable(
                name: "Dufi");

            migrationBuilder.DropTable(
                name: "Albacea");

            migrationBuilder.DropTable(
                name: "TipoDocumentoAdjunto");

            migrationBuilder.DropTable(
                name: "TipoCapacitacion");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Unidad");

            migrationBuilder.DropTable(
                name: "Domicilio");

            migrationBuilder.DropTable(
                name: "Escolaridad");

            migrationBuilder.DropTable(
                name: "Grado");

            migrationBuilder.DropTable(
                name: "Parentesco");

            migrationBuilder.DropTable(
                name: "SituacionLaboral");

            migrationBuilder.DropTable(
                name: "Guarnicion");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "DeclaracionJurada");

            migrationBuilder.DropTable(
                name: "Fuerza");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "SituacionFamiliar");
        }
    }
}
