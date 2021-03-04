using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Linea
    {
        [Key]
        public int Id { get; set; }

        public string Numero { get; set; }

    }
}
