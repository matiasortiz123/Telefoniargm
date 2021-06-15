using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class ContactoDDJJ : Contacto
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        //public string Descripcion { get; set; }

    }
}
