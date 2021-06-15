using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class ConductorMotorista
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public byte LicenciaConducir { get; set; }
        public DateTime  FechaUltimaRenovacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
