using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Empresa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Contacto es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres")]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "La observacion es obligatoria")]
        [Display(Name = "Observación")]
        public string Observacion { get; set; }
    
    }
}
