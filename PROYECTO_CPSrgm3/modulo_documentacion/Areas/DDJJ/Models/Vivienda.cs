using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class Vivienda
    {
        public int DeclaracionJuradaID { get; set; }
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int ID { get; set; }
        public bool ViviendaPropia { get; set; }
        public bool AlojaUnidad { get; set; }
        public Unidad AlojamientoUnidad { get; set; }
        public int? AlojamientoUnidadID { get; set; }
        public int? GuarnicionSolucionaID { get; set; } // Además del lugar donde posee vivienda propia, en que guarnición soluciona por propios medios su situación de vivienda
        public Guarnicion GuarnicionSoluciona { get; set; }
        public int? GuarnicionViviendaProxima1ID { get; set; }
        public Guarnicion GuarnicionViviendaProxima1 { get; set; }
        public int? GuarnicionViviendaProxima2ID { get; set; }
        public Guarnicion GuarnicionViviendaProxima2 { get; set; }
        public int? GuarnicionViviendaProxima3ID { get; set; }
        public Guarnicion GuarnicionViviendaProxima3 { get; set; }

        public int? GuarnicionConstruyeID { get; set; } //proximo a que guarnicion contruye su vivienda
        public Guarnicion GuarnicionConstruye { get; set; }
        public bool Satisface { get; set; }
        public bool OcupaPropia { get; set; }
        public bool Alquila { get; set; }
        public DateTime? AlquilaDesde { get; set; }
        public DateTime? AlquilaHasta { get; set; }
        public bool OcupaViviendaEstado { get; set; }
        public int? TiempoOcupaVivienda { get; set; }
        public DateTime? FechaConstruye { get; set; }
        public bool ConstruyeVivienda { get; set; }
        public bool PoseeCreditoVivienda { get; set; }
        public string SituacionEconomica { get; set; }


        // Comentado hasta que este lo de las guarniciones

        //public virtual List<GuarnicionVivienda> GuarnicionesProximas { get; set; } = new List<GuarnicionVivienda>();
        
        //public void AgregarGuarnicion(Guarnicion guarnicion)
        //{
        //    if (GuarnicionesProximas.Any(x => x.Guarnicion == guarnicion)) return;

        //    GuarnicionesProximas.Add(
        //        new GuarnicionVivienda
        //        {
        //            Guarnicion = guarnicion,
        //            Vivienda = this
        //        });
        //}

        //public int GuarnicionSolucionConstruye { get; set; }
        //public int GuarnicionSolucionVivienda { get; set; }


    }
}
