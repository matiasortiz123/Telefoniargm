using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Grado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Abreviatura { get; set; }
        public string AbreviaturaGenerica { get; set; }
        public Fuerza Fuerza { get; set; }
        public int FuerzaID { get; set; }
    }
}
