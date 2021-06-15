using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using modulo_documentacion.Areas.Admin.Models.Basicas;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Domicilio
    {
        public int ID { get; set; }
        //[Required(ErrorMessage ="Debe ingresar una calle")]
        [StringLength(50, ErrorMessage = "El campo calle no puede exceder los 50 caracteres. ")]
        public string Calle { get; set; }
        //[Required(ErrorMessage = "Debe ingresar una altura")]
        [StringLength(5, ErrorMessage = "El campo altura no puede exceder los 5 caracteres. ")]
        public string Altura { get; set; }
        [StringLength(2, ErrorMessage = "El campo piso no puede exceder los 2 caracteres.")]
        public string Piso { get; set; }
        [StringLength(4, ErrorMessage = "El campo departamento no puede exceder los 4 caracteres.")]
        public string Departamento { get; set; }
        [StringLength(10, ErrorMessage = "El campo torre no puede exceder los 10 caracteres.")]
        public string Torre { get; set; }
        [StringLength(10, ErrorMessage = "El campo sector no puede exceder los 10 caracteres.")]
        public string Sector { get; set; }
        [StringLength(10, ErrorMessage = "El campo manzana no puede exceder los 10 caracteres.")]
        public string Manzana { get; set; }
        //[Required(ErrorMessage = "Debe ingresar un código postal")]
        [StringLength(8, ErrorMessage = "El campo código postal no puede exceder los 8 caracteres.")]
        public string CodigoPostal { get; set; }
        public string ProvinciaStr { get; set; }
        public string LocalidadStr { get; set; }
        public int? ProvinciaId { get; set; }
        public int? LocalidadId { get; set; }
        public Provincia Provincia { get; set; }
        public Localidad Localidad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Busquedamapa { get; set; }

    }
}
