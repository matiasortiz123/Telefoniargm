using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Planes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del plan es obligatorio .")]
        public string NombrePlan { get; set; }
        [Required(ErrorMessage = "La descripción de la linea es obligatorio")]
        public string Descripcion { get; set; }
    }
}
