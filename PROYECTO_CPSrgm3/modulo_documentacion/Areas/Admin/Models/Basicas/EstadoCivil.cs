using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class EstadoCivil
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Estado Civil")]

        public string Descripcion { get; set; }
        public virtual SituacionFamiliar SituacionFamiliar { get; set; }



    }
}
