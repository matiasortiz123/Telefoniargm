using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Commons.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Persona
    {
        public int Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public int TipoDocumentoID { get; set; }
        public int? NroDocumento { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el apellido")]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }
        public string Foto { get; set; }
        public string Cuil { get; set; }
        public Genero Genero { get; set; }
        public int GeneroID { get; set; }

    }
}
