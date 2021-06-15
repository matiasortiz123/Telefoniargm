using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Escolaridad
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Campo Requerido"),Display(Name="Tipo de Escolaridad")]
        public string Descripcion { get; set; }
        public string Tipo { get; set; } // se utiliza tipo:1 y 3 para declarante y tipo:2 y 3 para familiares
    } 
}
