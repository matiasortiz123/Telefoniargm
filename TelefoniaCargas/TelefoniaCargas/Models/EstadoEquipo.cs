using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class EstadoEquipo
    {
        public int Id { get; set; }

        public string Disponible { get; set; }

        public string NoDisponible { get; set; }

        public string EnMantenimiento { get; set; }
    }
}
