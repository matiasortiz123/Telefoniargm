using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Albacea.Models
{
    public class Seguro
    {
        public int Id { get; set; }
        public int AlbaceaId { get; set; }
        public string Tipo { get; set; }
        public string Entidad { get; set; }
        public string NroPoliza { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
