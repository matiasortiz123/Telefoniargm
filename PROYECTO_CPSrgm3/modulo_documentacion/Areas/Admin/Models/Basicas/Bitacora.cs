using Commons.Identity.Services;
using System;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public enum TipoBitacora
    {
        DDJJCreacion=1,
        DDJJElevacionElemento=2,
        DDJJElevacionPersonal = 3,
        DDJJModificacionSolicitada = 4,
        DDJJModificacionAutorizada = 5,
        DDJJObservadaPersonal = 6,
        DDJJObservadaElemento = 7,
        DDJJElevacionDGP = 8
    }
    public class Bitacora
    {
        public int Id { get; set; }
        public TipoBitacora TipoBitacora { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public Usuario Usuario { get; set; }

        public static Bitacora CrearBitacora(TipoBitacora tipoBitacora, string descripcion, Usuario usuario)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.Descripcion = descripcion;
            bitacora.Usuario = usuario;
            bitacora.TipoBitacora = tipoBitacora;
            bitacora.FechaHora = DateTime.Now;
            return bitacora;
        }

    }

    
}
