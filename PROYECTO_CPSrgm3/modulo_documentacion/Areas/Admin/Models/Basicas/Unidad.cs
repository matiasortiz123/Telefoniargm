using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Commons.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace modulo_documentacion.Areas.Admin.Models.Basicas
{
    public class Unidad
    {
        public int Id { get; set; }
        public string CodigoUnidad { get; set; }
        public int? UnidadSuperiorId { get; set; }
        public virtual Unidad UnidadSuperior { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        //  public virtual TipoFuerza TipoFuerza { get; set; }
        // public virtual Co Co { get; set; }
        public List<PersonalMilitar> Integrantes { get; set; }
        public int GuarnicionId { get; set; }
        //public virtual Guarnicion Guarnicion { get; set; }
        // public virtual Domicilio Domicilio { get; set; }
        // public List<Contactos> Contacto { get; set; }
    }
}
