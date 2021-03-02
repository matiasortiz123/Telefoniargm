using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class Persona_Dependencia
    {
        public int Id { get; set; }

        //Vinculaciones

        public int PersonaId { get; set; }

        public virtual Persona Persona { get; set; }

        public int DependenciaId { get; set; }

        public virtual Dependencia Dependencia { get; set; }

    }
}
