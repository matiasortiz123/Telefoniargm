using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class GuarnicionFuturo
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        public string DeseaGuarnicion1 { get; set; }
        public string DeseaGuarnicion2 { get; set; }
        public string DeseaGuarnicion3 { get; set; }
        public int PermanecerGuarnicion { get; set; }
        public string UltimaZona { get; set; }
        public Guarnicion Guarnicion { get; set; }
    }
}
