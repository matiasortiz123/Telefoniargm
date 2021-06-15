using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Linea
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El numero de la linea es obligatorio .")]
        public string Numero { get; set; }

        //Vinculaciones
        public int PlanesId { get; set; } 
        public Planes Planes { get; set; }
    }
}
