using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.ViewModels
{
    public class EstudioCausaViewModel
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public List<EstudioDDJJ> Estudios { get; set; }
        public List<CausaJudicialDDJJ> Causas { get; set; }
        public List<Documentacion> Documentos { get; set; }

    }
}
