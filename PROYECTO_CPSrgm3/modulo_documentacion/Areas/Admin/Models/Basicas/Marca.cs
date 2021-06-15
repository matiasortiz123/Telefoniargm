using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Marca
    {
        public int Id { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "La marca es obligatoria .")]
        public string Descripcion { get; set; }

        //Vinculaciones
        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }
    }
}
