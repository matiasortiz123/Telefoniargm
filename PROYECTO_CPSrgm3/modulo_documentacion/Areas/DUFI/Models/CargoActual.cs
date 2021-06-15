using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.DUFI.Models
{
    public class CargoActual
    {
        public int Id { get; set; }
        public int DufiId { get; set; }
        [Required(ErrorMessage = "Debe ingresar un tiempo en la guarnición actual")]
        [Range(1, 50, ErrorMessage = "Debe ingresar un número entre 1 y 50.")]
        public int TiempoGuarnicion { get; set; }
        [Required(ErrorMessage = "Debe ingresar un tiempo en el destino actual")]
        [Range(1, 50, ErrorMessage = "Debe ingresar un número entre 1 y 50.")]
        public int TiempoDestino { get; set; }
        [Required(ErrorMessage = "Debe ingresar un tiempo en el cargo actual")]
        [Range(1, 40, ErrorMessage = "Debe ingresar un número entre 1 y 40.")]
        public int TiempoCargo { get; set; }
        [Required(ErrorMessage = "Debe ingresar el cargo que ocupa")]
        [StringLength(50)]
        public string CargoOcupa { get; set; }
        [Required(ErrorMessage = "Debe ingresar el cargo que desea")]
        [StringLength(50)]
        public string CargoDeseado { get; set; }  

    }
}
