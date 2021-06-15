using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class SituacionFamiliar
    {
        public int Id { get; set; }
      //  public int TipoSituacion { get; set; }
        public string Descripcion { get; set; }
    }
}
