using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Estado
    {
        
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public static int obtenerEstadoInicial(ModuloDocumentacionContext context) => context.Estado.FirstOrDefault().Id;

    }
}
