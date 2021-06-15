using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commons.Identity;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Usuario : CommonsUser
    {
        /*
         * En esta clase hay que llamar a los metodos del DatosPersonalesService
         */ 

        public PersonalMilitar Persona { get; set; }

        public override string GetFirstName()
        {
            if (Persona is null)
            {
                return "Nombres";
            }
            return Persona?.Nombre;
        }

        public override string GetLastName()
        {
            if (Persona is null)
            {
                return "Nombre completo";
            }
            return Persona?.Apellido;
        }

        public override string GetMiddleName()
        {
            if (Persona is null)
            {
                return "";
            }
            return "";
        }

        public override List<IWorkSpace> GetRelatedIWorkSpaces()
        {
            return new List<IWorkSpace>();
        }

        public override string GetRoleString()
        {
            return "Usuario";
        }
        public string GetFullName()
        {
            return (GetFirstName() + " " + GetMiddleName() + " " + GetLastName()).Trim();
        }
    }
}
