using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class CursoEspecial
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
    }
}
