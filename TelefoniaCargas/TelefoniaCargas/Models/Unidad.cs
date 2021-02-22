using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Unidad
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = " La unidad es requerida .")]
        [Display(Name = "Unidad")]
        public string Nombre { get; set; }
    }
}
