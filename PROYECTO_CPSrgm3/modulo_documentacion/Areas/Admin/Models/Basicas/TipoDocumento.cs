using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Commons.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas

{
    public class TipoDocumento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Tipo de Documento")]
        public string Descripcion { get; set; }

        public static TipoDocumento Inicial(ModuloDocumentacionContext _context)
        {
            return _context.TipoDocumento.FirstOrDefault();
        }
    }
}
