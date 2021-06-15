using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Fuerza
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
