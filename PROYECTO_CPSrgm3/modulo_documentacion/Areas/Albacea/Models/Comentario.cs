using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Albacea.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public int AlbaceaId { get; set; }
        public string Descripcion { get; set; }
    }
}
