using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class TipoContacto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

    }
}
