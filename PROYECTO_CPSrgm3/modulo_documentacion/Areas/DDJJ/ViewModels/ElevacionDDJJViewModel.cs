using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.ViewModels
{
    public class ElevacionDDJJViewModel
    {
        public bool Seleccionada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public string Titular { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }


    }
}
