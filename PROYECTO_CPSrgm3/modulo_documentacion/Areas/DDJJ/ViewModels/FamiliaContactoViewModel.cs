using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.ViewModels
{
    public class FamiliaContactoViewModel
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }

        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual SituacionFamiliar SituacionFamiliar { get; set; }
        virtual
        public int DeclaracionJuradaID { get; set; }
        public List<ContactoDDJJ> Contactos { get; set; }
        public int? EstadoCivilID { get; set; }
        public int? SituacionFamiliarID { get; set; }
        public string OtraSituacion { get; set; }
     //   public virtual SituacionFamiliar SituacionFamiliar { get; set; }
        public List<Familiar> Familiares{ get; set; }


    }
}
