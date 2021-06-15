using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Commons.Identity.Services;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.DDJJ.Models
{
   
    public class BitacoraDDJJ : Bitacora
    {
        public string TextoAdicional { get; set; }

        public static BitacoraDDJJ CrearBitacoraDDJJ(Bitacora bitacora, string textoAdicional)
        {
            BitacoraDDJJ bitacoraDDJJ = new BitacoraDDJJ();
            bitacoraDDJJ.TipoBitacora = bitacora.TipoBitacora;
            bitacoraDDJJ.Descripcion = bitacora.Descripcion;
            bitacoraDDJJ.Usuario = bitacora.Usuario;
            bitacoraDDJJ.FechaHora = bitacora.FechaHora;
            bitacoraDDJJ.TextoAdicional = textoAdicional;
            return bitacoraDDJJ;
        }

    }
}
