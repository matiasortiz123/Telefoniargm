using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class ExpedienteCD
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public byte TieneExpediente { get; set; }
        public string NroExpediente { get; set; }
        public string CausaExpediente { get; set; }
        public byte? ActualizoExpediente { get; set; }
        public string NroExpedienteAct { get; set; }
    }
}
