using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Genero")]
        public string Descripcion { get; set; }

        public static Genero Inicial(ModuloDocumentacionContext _context) {
            return _context.Genero.FirstOrDefault();
        }
    }
}
