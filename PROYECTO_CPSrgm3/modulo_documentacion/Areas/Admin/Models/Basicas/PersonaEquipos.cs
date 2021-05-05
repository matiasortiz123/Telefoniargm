using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class PersonaEquipos
    {
        public int Id { get; set; }
        public int? Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Grado { set; get; }
        public string Unidad { set; get; }
        public bool Editable { set; get; }

        //Vincular Equipo
        public Equipo Equipo { get; set; }
        public int EquipoId { get; set; }
    }
}
