using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.ViewModels
{
    public class DomicilioViviendaViewModel
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public DomicilioDDJJ Domicilio { get; set; }
        public Vivienda Vivienda { get; set; }
        public Provincia Provincia { get; set; }
        public Localidad Localidad { get; set; }
        public int GuarnicionViviendaProxima1ID { get; set; }
        public Guarnicion GuarnicionViviendaProxima1 { get; set; }
        public int GuarnicionViviendaProxima2ID { get; set; }
        public int GuarnicionViviendaProxima3ID { get; set; }
        public int AlojamientoUnidadID { get; set; }
        public Unidad AlojamientoUnidad { get; set; }

        public int GuarnicionSolucionaID { get; set; } // Además del lugar donde posee vivienda propia, en que guarnición soluciona por propios medios su situación de vivienda
        public Guarnicion GuarnicionSoluciona { get; set; }
        public Guarnicion GuarnicionConstruye { get; set; }
        public int GuarnicionConstruyeID { get; set; }
    }
}
