using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Albacea.Models
{
    public class PersonaAlbacea
    {
        public int Id { set; get; }
        public int dni { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Grado { set; get; }
        public string Unidad { set; get; }
        public string AbreviaturaUnidad { set; get; }
    }
}
