using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class MisionComExt
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public string Pais { get; set; }
        public string Cargo { get; set; }
        public string Mision { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Duracion { get { return (this.FechaFin - this.FechaInicio).Days; } }
    }
}
