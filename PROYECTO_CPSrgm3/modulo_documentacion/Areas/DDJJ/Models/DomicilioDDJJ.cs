using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class DomicilioDDJJ:Domicilio
    {
        public int DeclaracionJuradaID { get; set; }
        public DeclaracionJurada DeclaracionJurada { get; set; }
        //  public int? PaisID { get; set; }
        public string Pais { get; set; }
        public bool ViveExterior { get; set; }
        public string ProvinciaExterior { get; set; }
         public string LocalidadExterior { get; set; }
        public string NroIOSFA { get; set; }
      
    }
}
