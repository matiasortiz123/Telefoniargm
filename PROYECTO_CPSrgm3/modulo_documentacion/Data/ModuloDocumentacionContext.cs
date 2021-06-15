using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Areas.DDJJ.Models;
using Commons.Identity;
using System.Collections.Generic;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Areas.DUFI.Models;

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

        public DbSet<Bitacora> Bitacora { get; set; }

        public DbSet<DeclaracionJurada> DeclaracionJurada { get; set; }

        public DbSet<Escolaridad> Escolaridad { get; set; }
        public DbSet<TipoDocumentoAdjunto> TipoDocumentoAdjunto { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<EstadoDDJJ> EstadoDDJJ { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Parentesco> Parentesco { get; set; }
        public DbSet<SituacionLaboral> SituacionLaboral { get; set; }
        public DbSet<TipoContacto> TipoContacto { get; set; }
        public DbSet<TipoExpediente> TipoExpediente { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Guarnicion> Guarnicion { get; set; }
        public DbSet<Unidad> Unidad { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<SituacionFamiliar> SituacionFamiliar { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<PersonalMilitar> PersonaMilitar { get; set; }
        public DbSet<PersonaEquipos> PersonaEquipos { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<ContactoDDJJ> ContactoDDJJ { get; set; }
        public DbSet<DomicilioDDJJ> DomicilioDDJJ { get; set; }
        public DbSet<Familiar> Familiar { get; set; }
        public DbSet<Fuerza> Fuerza { get; set; }
        public DbSet<Grado> Grado { get; set; }
        public DbSet<EstudioDDJJ> EstudioDDJJ { get; set; }
        public DbSet<Documentacion> Documentacion { get; set; }
        public DbSet<CausaJudicialDDJJ> CausaJudicialDDJJ { get; set; }
        public DbSet<Vivienda> Vivienda { get; set; }
        public DbSet<Idioma> Idioma { get; set; }

        public DbSet<AptitudEspecial> AptitudEspecial { get; set; }
        public DbSet<CursoEspecial> CursoEspecial { get; set; }
        public DbSet<TipoCapacitacion> TipoCapacitacion { get; set; }

        //  public DbSet<GuarnicionVivienda> ViviendaGuarniciones { get; set; }

        //ALBACEA

        public DbSet<Albacea> Albacea { get; set; }
        public DbSet<Seguro> Seguro { get; set; }
        public DbSet<PersonaAviso> PersonaAviso { get; set; }
        public DbSet<PersonaAlbacea> PersonaAlbacea { get; set; }
        public DbSet<Comentario> Comentario { get; set; }

        // DUFI

        public DbSet<CargoActual> CargoActual { get; set; }
        public DbSet<CargoDocenteProf> CargoDocenteProf { get; set; }
        public DbSet<DestinoFuturo> DestinoFuturo { get; set; }
        public DbSet<Dufi> Dufi { get; set; }
        public DbSet<ExpedienteCD> ExpedienteCD { get; set; }
        public DbSet<GuarnicionFuturo> GuarnicionFuturo { get; set; }
        public DbSet<IdiomaDufi> IdiomaDufi { get; set; }
        public DbSet<MisionComExt> MisionComExt { get; set; }
        public DbSet<AptEspDufi> AptEspDufi { get; set; }
        public DbSet<CursosEspDufi> CursosEspDufi { get; set; }
        public DbSet<TipoRegistroConductor> TipoRegistroConductor { get; set; }
        public DbSet<ConductorMotorista> ConductorMotorista { get; set; }
        public DbSet<RegistroConductorDufi> RegistroConductorDufi { get; set; }

        //Equipos!!!
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
