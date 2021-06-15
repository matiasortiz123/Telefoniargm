
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;

namespace modulo_documentacion.Areas.DDJJ.ViewModels
    {
    public class VistaPreviaViewModel
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public DomicilioViviendaViewModel DomicilioViviendaViewModel { get; set; }
        public EstudioCausaViewModel EstudioCausaViewModel { get; set; }
        public FamiliaContactoViewModel FamiliaContactoViewModel { get; set; }
    }
}
