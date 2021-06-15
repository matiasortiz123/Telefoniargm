using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class CursosEspDufi
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public int CursoEspecialId { get; set; }
        public CursoEspecial CursoEspecial { get; set; }
}
}
