using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public class Documentacion
    {
        public DeclaracionJurada DeclaracionJurada { get; set; }
        public int DeclaracionJuradaID { get; set; }
        public int Id { get; set; }
        public int TipoDocumentoAdjuntoID { get; set; }
        public TipoDocumentoAdjunto TipoDocumentoAdjunto { get; set; }
        public int Fojas { get; set; }
        public string Observaciones { get; set; }
        public byte[] Adjunto { get; set; }
        public string Tipo { get; set; }

        //public List<Adjunto>  Adjunto { get; set; }
        //VER COMO IMPLEMENTAR EL ARRAY DE IMAGENES (CLASE APARTE ?)

        //public int DniDeclarante { get; set; }
        //public int IdTipoDocumentacion { get; set; }
        //public string UsuarioActualizacion { get; set; }
        //public DateTime FechaActualizacion { get; set; }
    }
}
