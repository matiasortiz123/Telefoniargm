using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Equipo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Imei es obligatorio")]
        [Display(Name = "IMEI")]
        public int Imei { get; set; }

        [Required(ErrorMessage = "Los accesorios son obligatorio")]
        public string Accesorios { get; set; }

        [Required(ErrorMessage = "La gama es obligatorio")]
        public string Gama { get; set; }

        [Required(ErrorMessage = "La condicion es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Condicion")]
        public string Condicion { get; set; }

        public bool Editable { get; set; }
        //Vinculaciones
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }

        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

        public int EstadoEquipoId { get; set; }
        public virtual EstadoEquipo EstadoEquipo { get; set; }

        public int LineaId { get; set; }
        public virtual Linea Linea { get; set; }

        public int PlanesId { get; set; }
        public virtual Planes Planes { get; set; }
    }
}
