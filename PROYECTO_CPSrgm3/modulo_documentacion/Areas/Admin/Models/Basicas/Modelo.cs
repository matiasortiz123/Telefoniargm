using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Modelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El modelo es obligatoria .")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
