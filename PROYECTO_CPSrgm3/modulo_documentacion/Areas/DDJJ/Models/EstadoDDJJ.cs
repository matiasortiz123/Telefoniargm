using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;

namespace modulo_documentacion.Areas.DDJJ.Models
{
    public enum EstadosBD
    {
        ConfeccionadoCausante=2,
        ElevadoPersonal = 3,
        CompletadoPersonal = 4, // solo DUFI
        ObservadaPersonal = 5,
        ElevadoJefeElemento = 6,
        CompletadoAuxJefeElemento = 7, //solo DUFI
        ObservadaElemento = 8,
        ElevadoDGP = 9,
        ModificacionSolicitada = 10,
        ModificacionAutorizada = 11,
        UltimaDGPB = 12 // Obsoleto ?
    }
    
    public class EstadoDDJJ : Estado
    {
        public string NombreExtendido { get; set; }

        public static EstadoDDJJ EstadoInicialDDJJ(ModuloDocumentacionContext context)=> context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ConfeccionadoCausante).FirstOrDefault();
        
        public static EstadoDDJJ Confeccionado(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ConfeccionadoCausante).FirstOrDefault();
        public static EstadoDDJJ ElevadoPersonal(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ElevadoPersonal).FirstOrDefault();
        public static EstadoDDJJ ElevadoJefeElemento(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ElevadoJefeElemento).FirstOrDefault();
        public static EstadoDDJJ ElevadoDGP(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ElevadoDGP).FirstOrDefault();
        public static EstadoDDJJ ModificacionSolicitada(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ModificacionSolicitada).FirstOrDefault();
        public static EstadoDDJJ ModificacionAutorizada(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ModificacionAutorizada).FirstOrDefault();
        public static EstadoDDJJ ObservadaPersonal(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ObservadaPersonal).FirstOrDefault();
        public static EstadoDDJJ ObservadaElemento(ModuloDocumentacionContext context) => context.EstadoDDJJ.Where(e => e.Id == (int)EstadosBD.ObservadaElemento).FirstOrDefault();

    }
}
