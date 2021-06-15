using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Contacto
    {
        public int ID { get; set; }
        public int TipoContactoID { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public string PrefijoTel { get; set; }
        public string NumeroTel { get; set; }
        public string Email { get; set; }

        public string getContacto()
        {
            switch (TipoContacto.Descripcion)
            {
                case "Telefono Fijo":
                    return String.Concat(PrefijoTel.ToString(), " - ", NumeroTel.ToString()).Trim();
                case "Celular":
                    return String.Concat(PrefijoTel.ToString(), " - ", NumeroTel.ToString()).Trim();
                case "Correo Electronico":
                    return Email.Trim();
                default:
                    return "";
            }


        }

    }
}
