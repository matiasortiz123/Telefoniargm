﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modulo_documentacion.Models;

namespace modulo_documentacion.Migrations
{
    [DbContext(typeof(ModuloDocumentacionContext))]
    [Migration("20210505144520_ProyectoLimpio")]
    partial class ProyectoLimpio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Commons.Identity.CommonsFunction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("DeletedById");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("Display");

                    b.Property<string>("LastEditById");

                    b.Property<DateTime>("LastEditTime");

                    b.Property<string>("Name");

                    b.Property<string>("RoutesJson");

                    b.Property<bool>("Show");

                    b.HasKey("Id");

                    b.ToTable("AspNetFunctions");
                });

            modelBuilder.Entity("Commons.Identity.CommonsRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("Enabled");

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<bool>("Show");

                    b.Property<string>("ShowName");

                    b.Property<string>("WorkSpaceId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Commons.Identity.CommonsRoleFunction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("FunctionId");

                    b.Property<string>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleFunctions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Observacion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accesorios")
                        .IsRequired();

                    b.Property<string>("Condicion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Editable");

                    b.Property<int>("EmpresaId");

                    b.Property<int>("EstadoEquipoId");

                    b.Property<string>("Gama")
                        .IsRequired();

                    b.Property<int>("Imei");

                    b.Property<int>("LineaId");

                    b.Property<int>("MarcaId");

                    b.Property<int>("ModeloId");

                    b.Property<int>("PlanesId");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EstadoEquipoId");

                    b.HasIndex("LineaId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.HasIndex("PlanesId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.EstadoEquipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado");

                    b.HasKey("Id");

                    b.ToTable("EstadoEquipo");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Linea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Numero")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Linea");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.PersonaEquipos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<int?>("Dni");

                    b.Property<bool>("Editable");

                    b.Property<int>("EquipoId");

                    b.Property<string>("Grado");

                    b.Property<string>("Nombre");

                    b.Property<string>("Unidad");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("PersonaEquipos");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.PersonalMilitar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Arma");

                    b.Property<string>("ArmaAbreviatura");

                    b.Property<int?>("ArmaId");

                    b.Property<int>("Dni");

                    b.Property<bool>("EsAuxiliarPersonal");

                    b.Property<bool>("EsAuxiliarUnidad");

                    b.Property<bool>("EsJefePersonal");

                    b.Property<bool>("EsJefeUnidad");

                    b.Property<DateTime>("FechaNacim");

                    b.Property<string>("FraccionGrado");

                    b.Property<string>("Grado");

                    b.Property<string>("GradoAbreviatura");

                    b.Property<int>("GradoId");

                    b.Property<int>("GradoPeso");

                    b.Property<string>("Nombre");

                    b.Property<int>("NroDocumento");

                    b.Property<int?>("OrdenMerito");

                    b.Property<string>("Sexo");

                    b.Property<string>("SituacionRevista");

                    b.Property<string>("UnidadAbreviatura");

                    b.Property<string>("UnidadComisionAbreviatura");

                    b.Property<string>("UnidadComisionDescripcion");

                    b.Property<int?>("UnidadComisionId");

                    b.Property<string>("UnidadDescripcion");

                    b.Property<int>("UnidadId");

                    b.Property<string>("UnidadInstSupAbreviatura");

                    b.Property<string>("UnidadInstSupDescripcion");

                    b.Property<int?>("UnidadInstSupId");

                    b.Property<string>("Uuid");

                    b.HasKey("Id");

                    b.HasIndex("UnidadId");

                    b.ToTable("PersonalMilitar");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Planes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("NombrePlan")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.RolesPersonas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("DescripcionCargos");

                    b.HasKey("Id");

                    b.ToTable("RolesPersonas");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Unidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abreviatura");

                    b.Property<string>("CodigoUnidad");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Estado");

                    b.Property<int>("GuarnicionId");

                    b.Property<int?>("UnidadSuperiorId");

                    b.HasKey("Id");

                    b.HasIndex("UnidadSuperiorId");

                    b.ToTable("Unidad");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<int?>("PersonaId");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PersonaId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Commons.Identity.CommonsRoleFunction", b =>
                {
                    b.HasOne("Commons.Identity.CommonsFunction", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId");

                    b.HasOne("Commons.Identity.CommonsRole", "Role")
                        .WithMany("RoleFunctions")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Commons.Identity.CommonsRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Commons.Identity.CommonsRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Equipo", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.EstadoEquipo", "EstadoEquipo")
                        .WithMany()
                        .HasForeignKey("EstadoEquipoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Linea", "Linea")
                        .WithMany()
                        .HasForeignKey("LineaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Planes", "Planes")
                        .WithMany()
                        .HasForeignKey("PlanesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.PersonaEquipos", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.PersonalMilitar", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Unidad", "UnidadAsignada")
                        .WithMany("Integrantes")
                        .HasForeignKey("UnidadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Unidad", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.Unidad", "UnidadSuperior")
                        .WithMany()
                        .HasForeignKey("UnidadSuperiorId");
                });

            modelBuilder.Entity("modulo_documentacion.Areas.Admin.Models.Basicas.Usuario", b =>
                {
                    b.HasOne("modulo_documentacion.Areas.Admin.Models.Basicas.PersonalMilitar", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");
                });
#pragma warning restore 612, 618
        }
    }
}
