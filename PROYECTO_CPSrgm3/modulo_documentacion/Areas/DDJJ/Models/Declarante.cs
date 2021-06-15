using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class Declarante
    {
        private int Id { get; set; }
        private int Dni { get; set; }
        private string Cuil { get; set; }
        private string IdEstado { get; set; }
        private string UserName { get; set; }
        private string Motivo { get; set; }
        private string Barcode { get; set; }
        private int IdEstadoCivil { get; set; }
        private int IdSituacionJurada { get; set; }
        private string FamiliaSituacionOtras { get; set; }
        private string JefePersonal { get; set; }
        private string JefeElemento { get; set; }
        private DateTime FechaActualizacion { get; set; }
        private string UsuarioActualizacion { get; set; }
        private DateTime FechaElevacionJefePersonal { get; set; }
        private DateTime FechaElevacionJefeElemento { get; set; }
        private DateTime FechaElevacionDgp { get; set; }
        private int CambioId { get; set; }
        private DateTime CambioFecUpdate { get; set; }
        private string CambioMotivo { get; set; }
        private string Iosfa { get; set; }

    }
}
