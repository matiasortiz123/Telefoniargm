using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Dependencia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La dependencia es requerida .")]
        [Display(Name ="Dependencia")]

        public string Nombre { get; set; }

        //Vinculaciones

        public int UnidadId { get; set; }
        public virtual Unidad Unidad { get; set; }
    }
}
