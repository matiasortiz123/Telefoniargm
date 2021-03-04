using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Planes
    { 
        [Key]
        public int Id { get; set; }

        public string Nombre_Plan { get; set; }

        public string Descripcion { get; set; }

    }
}
