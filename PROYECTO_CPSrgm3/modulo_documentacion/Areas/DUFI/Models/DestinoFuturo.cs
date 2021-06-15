using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class DestinoFuturo
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public int VinculoAfectivo { get; set; }
        public int VinculoParentesco { get; set; }
        public byte DeseaCambioGuarnicion { get; set; }
        public byte DeseaCambioDestino { get; set; }
        public string Fundamento { get; set; }
        public string OpinionFutura { get; set; }
        public Parentesco Parentesco { get; set; }
        public Guarnicion Guarnicion { get; set; }
    }
}
