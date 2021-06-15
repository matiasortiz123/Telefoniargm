using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class DeclaracionJurada
    {
        public int ID { get; set; }
        public string ObservacionActual { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? EstadoCivilID { get; set; }
        public int? SituacionFamiliarID { get; set; }
        public DateTime? FechaCasamiento { get; set; }
        public int EstadoID { get; set; }
        public string OtraSituacionFamiliar { get; set; }
        public string UsuarioId { get; set; }
        //Navegacion
        public Usuario Usuario { get; set; }
        public List<ContactoDDJJ> Contactos { get; set; } = new List<ContactoDDJJ>();
        public List<Familiar> Familiares { get; set; }
        public List<EstudioDDJJ> Estudios { get; set; }
        public List<CausaJudicialDDJJ> CausasJudiciales { get; set; }
        public List<Documentacion> Documentos { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public SituacionFamiliar SituacionFamiliar { get; set; }
        public DomicilioDDJJ Domicilio { get; set; }
        public Vivienda Vivienda { get; set; }
        public EstadoDDJJ Estado { get; set; }

        public List<BitacoraDDJJ> Bitacoras { get; set; } = new List<BitacoraDDJJ>();

        public bool PermiteEdicion()
        {
            if (this.EstadoID == (int)EstadosBD.ConfeccionadoCausante)return true;
            return false;
        }
        public bool PermiteReporte()
        {
            if (this.EstadoID == (int)EstadosBD.ConfeccionadoCausante) return false;
            return true;
        }
        public bool PermiteSolicitud()
        {
            if (this.EstadoID == (int)EstadosBD.ConfeccionadoCausante) return false;
            return true;
        }

    }
}
