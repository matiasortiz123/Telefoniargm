using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int IdDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public string ProvinciaNombre { get; set; }
    }
}
