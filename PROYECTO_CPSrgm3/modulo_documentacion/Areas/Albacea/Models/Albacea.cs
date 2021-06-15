using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Albacea.Models
{
    public class Albacea
    {
        public int Id { get; set; }
        
        public DateTime FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int? DniAlbacea { get; set; }
        public string GradoAlbacea { get; set; }
        public string DatosAlbacea { get; set; }
        public string UnidadAlbacea { get; set; }
        public Usuario Usuario { get; set; }
        public Estado Estado { get; set; }
        public List<Seguro> Seguro { get; set; }
        public  List<PersonaAviso> PersonaAviso { get; set; }
        public List<Comentario> Comentario { get; set; }

    }
}
