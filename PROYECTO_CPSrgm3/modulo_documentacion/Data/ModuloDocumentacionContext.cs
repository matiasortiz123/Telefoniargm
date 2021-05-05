using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using Commons.Identity;
using System.Collections.Generic;

namespace modulo_documentacion.Models
{
    public class ModuloDocumentacionContext : CommonsDbContext<Usuario>
    {
        public ModuloDocumentacionContext(DbContextOptions<ModuloDocumentacionContext> options)
            : base(options)
        {
        }
        public override List<IWorkSpace> GetIWorkSpaces()
        {
            return new List<IWorkSpace>();
        }
        //Equipos!!!
        public DbSet<Estado> Estado { get; set; }
        public DbSet<PersonaEquipos> PersonaEquipos { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<EstadoEquipo> EstadoEquipo { get; set; }
        public DbSet<Linea> Linea { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RolesPersonas> RolesPersonas { get; set; }

    }
}
