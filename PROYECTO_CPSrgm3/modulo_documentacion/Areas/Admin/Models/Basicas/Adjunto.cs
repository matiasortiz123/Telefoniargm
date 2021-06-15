using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Adjunto
    {
        [Key]
        public int Id { get; set; }
       // [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Tipo de Escolaridad")]
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public string Tipo { get; set; } 
    }
}
