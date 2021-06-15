using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.DDJJ.ViewModels
{
    public class UsuarioViewModel
    {
        public Usuario Usuario { get; set; }
        public Persona Persona { get; set; }

    }
}
