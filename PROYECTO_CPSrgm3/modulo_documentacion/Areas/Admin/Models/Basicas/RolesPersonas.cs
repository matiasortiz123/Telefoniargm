using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class RolesPersonas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio")]
        public string Descripcion { get; set; }

        public string DescripcionCargos { get; set; }
    }
}
