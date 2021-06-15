using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class CausaJudicialDDJJ
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public int Id { get; set; }
        public string Caratula { get; set; }
        public string Expediente { get; set; }
        public int TipoExpedienteID { get; set; }
        public string SituacionJudicial { get; set; }
        public string Juzgado { get; set; }

        public TipoExpediente TipoExpediente { get; set; }

        
        //private int DniDeclarante { get; set; }
        //private int IdTipo { get; set; }
        //private string NroExpediente { get; set; }
        //private string JuzgadoInterveniente { get; set; }
        //private string SituacionProcesal { get; set; }
        //private string OrganismoInterveniente { get; set; }
        //private string Caratula { get; set; }
        //private byte Finalizado { get; set; }
        //private DateTime FechaActualizacion { get; set; }
        //private string UsuarioActualizacion { get; set; }
       
    }
}
