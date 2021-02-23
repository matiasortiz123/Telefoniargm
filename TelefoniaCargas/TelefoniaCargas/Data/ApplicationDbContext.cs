using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TelefoniaCargas.Models;

namespace TelefoniaCargas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }

        public DbSet<Unidad> Unidad { get; set; }
        public DbSet<Dependencia> Dependencia { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Persona_Dependencia> Persona_Dependencia { get; set; }

        public DbSet<AsignarEquipo> AsignarEquipo { get; set; }

        public DbSet<EstadoEquipo> EstadoEquipo { get; set; }

    }

}