using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Parentesco
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Tipo de Parentesco")]
        public string Descripcion { get; set; }
    }
}
