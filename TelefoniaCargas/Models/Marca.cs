﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Marca")]
        public string Descripcion { get; set; }
    }
}
