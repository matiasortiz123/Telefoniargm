using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class PersonalMilitar : Persona
    {
        public string Arma { get; set; } //virtual Arma Arma
        public int UnidadId { get; set; }
        [ForeignKey("UnidadId")]
        [InverseProperty("Integrantes")]
        public Unidad UnidadAsignada { get; set; }
        public bool EsAuxiliarUnidad { get; set; }
        public bool EsAuxiliarPersonal { get; set; }
        public bool EsJefeUnidad { get; set; }
        public bool EsJefePersonal { get; set; }
        public string Grado { get; set; } //virtual Grado Grado
    }
}
