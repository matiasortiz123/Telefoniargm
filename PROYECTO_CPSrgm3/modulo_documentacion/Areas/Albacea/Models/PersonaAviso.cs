using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Albacea.Models
{
    public class PersonaAviso
    {
       
        public int Id { get; set; }
        public int AlbaceaId { get; set; }
        public string Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
