using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
