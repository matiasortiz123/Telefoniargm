using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class AptEspDufi
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public int AptEspId { get; set; }
        public int TipoCapacitacionId { get; set; }
        public DateTime? FechaHabilitacion { get; set; }
        //public AptitudEspecial AptitudEspecial { get; set; }
        //public TipoCapacitacion TipoCapacitacion { get; set; }
    }
}
