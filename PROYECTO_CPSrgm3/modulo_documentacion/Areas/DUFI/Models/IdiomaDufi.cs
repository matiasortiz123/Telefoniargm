using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class IdiomaDufi
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public int? IdiomaId { get; set; }
        public string IdiomaOtro { get; set; }
        public string Nivel { get; set; }
        public DateTime FechaAcreditacion { get; set; }
        public DateTime FechaVencimiento { get; set; }

        //public Idioma Idioma { get; set; }
    }
}
