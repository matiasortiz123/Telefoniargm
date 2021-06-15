using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class EstudioDDJJ
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public int Id { get; set; }
        public int EscolaridadID { get; set; }
        public Escolaridad Escolaridad { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizado { get; set; }
    }
}
