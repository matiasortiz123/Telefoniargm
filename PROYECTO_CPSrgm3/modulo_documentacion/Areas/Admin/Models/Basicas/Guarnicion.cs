using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas

{
    public class Guarnicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Descripcion { get; set; }
        public int? TipoZona { get; set; } 
        public string Codigo { get; set; }   
        public List<Unidad> Unidades { get; set; }
    }
}
