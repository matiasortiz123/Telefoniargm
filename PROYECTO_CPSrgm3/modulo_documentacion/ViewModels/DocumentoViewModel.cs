using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.ViewModels
{
    public class Documento
    {
        public enum Tipo
        {
            DeclaracionJurada = 1,
            Dufi = 2,
            Albacea = 3
        }

        public Tipo TipoDocumento { get; set; }
        public int DocumentoID {get;set;}
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public int Progreso { get; set; }
        public string EstiloBarra { get; set; }
        public string EstiloEstado { get; set; }
        public string Ruta { get; set; }
        public bool PermiteEdicion { get; set; }
        public bool PermiteReporte { get; set; }
        public bool PermiteSolicitud { get; set; }
    }
}
