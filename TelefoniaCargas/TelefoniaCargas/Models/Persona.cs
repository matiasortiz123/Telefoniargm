using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaCargas.Models
{
  

    public class Persona
    {
        public enum Tipos
        {
            [Display(Name = "Persona")]
            Persona,
            [Display(Name = "Rol")]
            Rol

        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido .")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido .")]

        public string Apellido { get; set; }
        [Required(ErrorMessage = " El DNI es requerido .")]
        public int DNI { get; set; }

        public string Rol { get; set; }
        

        //Vinculaciones

    }
}
