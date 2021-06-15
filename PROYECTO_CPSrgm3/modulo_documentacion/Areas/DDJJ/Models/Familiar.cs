using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class Familiar : Persona
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int? DeclaracionJuradaID { get; set; }
        public Escolaridad Escolaridad { get; set; }
        public int EscolaridadID { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public int EstadoCivilID { get; set; }
        public Parentesco Parentesco { get; set; }
        public int ParentescoID { get; set; }
        [Required]
        public bool Vive { get; set; }
     //   public DateTime? FechaCasamiento { get; set; }
        public DateTime? FechaDefuncion { get; set; }
        public int? ProvinciaDefuncionID { get; set; }
        public int? LocalidadDefuncionID { get; set; }
        public Provincia ProvinciaDefuncion { get; set; }
        public Localidad LocalidadDefuncion { get; set; }
        [Required]
        public bool TieneIOSFA { get; set; }
        public string NroIOSFA { get; set; }
        [Required]
        public bool Impedido  { get; set; }
        public string Impedimiento { get; set; }
        public SituacionLaboral SituacionLaboral { get; set; }
        public string OtraSituacion { get; set; }
        public int SituacionLaboralID { get; set; }
        public Fuerza Fuerza { get; set; }
        public int FuerzaID { get; set; }
        public Grado Grado { get; set; }
        public int GradoID { get; set; }
        public string Destino { get; set; }
        public int? Antiguedad { get; set; }
        public string Empleador { get; set; }
        public Provincia ProvinciaEmpleador { get; set; }
        public int? ProvinciaEmpleadorID { get; set; }
        public Localidad LocalidadEmpleador { get; set; }
        public int? LocalidadEmpleadorID { get; set; }
        public bool Convive { get; set; }
        public bool ViveExtranjero { get; set; }
        public string Pais { get; set; }
        public Domicilio Domicilio { get; set; }
        public int DomicilioID { get; set; }

        //CAMPOS A VERIFICAR

        //public int Sueldo { get; set; }
        //public int PrefijoTel { get; set; }
        //public string TelefonoFijo { get; set; }
        //public int PrefijoCel { get; set; }
        //public string TelefonoCel { get; set; }
        //public string PaisProvCiudExterior { get; set; }

        //public bool Verificado { get; set; }
        //public DateTime FechaActualizacion { get; set; }
        //public string UsuarioActualizacion { get; set; }

        //public int IdProvinciaDefuncion { get; set; }
        //public int IdLocalidadDefuncion { get; set; }

        public string nombreCompleto()
        {
            return String.Concat(Apellido, ", ",Nombre);
        }


    }
}
