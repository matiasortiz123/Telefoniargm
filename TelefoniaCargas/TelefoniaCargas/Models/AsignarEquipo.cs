using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
    public class AsignarEquipo
    {
        public int Id { get; set; }

        //Vinculaciones
        public int Persona_DependenciaId { get; set; }
        public virtual Persona_Dependencia Persona_Dependencia { get; set; }
        
        public int EquipoId { get; set; }

        public virtual Equipo Equipo { get; set; }
    }
}
