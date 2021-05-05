using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using Microsoft.EntityFrameworkCore;

namespace modulo_documentacion.ViewModels
{
    public class InicioPersonal
    {
        public InicioPersonal()
        {
            Documentos = new List<Documento>();
        }

        public List<Documento> Documentos { get; set; }

        public int Progreso(Documento doc)
        {
            switch (doc.Estado)
            {
                case "":
                    return 25;
                default:
                    break;
            }
            return 25;
        }

        //public void AgregarDocumentosActivos(ModuloDocumentacionContext _context, Usuario usuario)
        //{
        //    List<DeclaracionJurada> declaraciones = _context.DeclaracionJurada.Where(d => d.Usuario.Id == usuario.Id).Include(d => d.Estado).ToList();
        //    List<Documento> listaDeclaraciones = (from dj in declaraciones
        //                                          select new Documento
        //                                          {
        //                                              TipoDocumento = Documento.Tipo.DeclaracionJurada,
        //                                              DocumentoID = dj.ID,
        //                                              Estado = dj.Estado.Descripcion,
        //                                              Fecha = dj.FechaCreacion,
        //                                              Observaciones = dj.ObservacionActual,
        //                                              Progreso = Progreso(dj.EstadoID),
        //                                              EstiloBarra = EstiloBarra(dj.EstadoID),
        //                                              EstiloEstado = EstiloEstado(dj.EstadoID),
        //                                              Ruta = "DDJJ/DeclaracionJurada/DomicilioVivienda",
        //                                              PermiteEdicion = dj.PermiteEdicion(),
        //                                              PermiteReporte = dj.PermiteReporte(),
        //                                              PermiteSolicitud = dj.PermiteSolicitud()
        //                                          }).ToList();
        //    this.Documentos.AddRange(listaDeclaraciones);

        //    List<Dufi> dufis = _context.Dufi.Where(d => d.Usuario.Id == usuario.Id).Include(d => d.Estado).ToList();
        //    List<Documento> listaDUFI = (from du in dufis
        //                                 select new Documento
        //                                 {
        //                                     TipoDocumento = Documento.Tipo.Dufi,
        //                                     DocumentoID = du.Id,
        //                                     Estado = du.Estado.Descripcion,
        //                                     Fecha = du.FechaCreacion,
        //                                     Observaciones = "",
        //                                     Progreso = Progreso(du.EstadoId),
        //                                     EstiloBarra = EstiloBarra(du.EstadoId),
        //                                     EstiloEstado = EstiloEstado(du.EstadoId),
        //                                     Ruta = "/DDJJ/DeclaracionJurada/DomicilioVivienda",
        //                                     PermiteEdicion = true,
        //                                     PermiteReporte = true,
        //                                     PermiteSolicitud = true

        //                                 }).ToList();
        //    this.Documentos.AddRange(listaDUFI);

        //    List<Albacea> albaceas = _context.Albacea.Where(a => a.Usuario.Id == usuario.Id).Include(a => a.Estado).ToList();
        //    List<Documento> listaAlbacea = (from al in albaceas
        //                                    select new Documento
        //                                    {
        //                                        TipoDocumento = Documento.Tipo.Albacea,
        //                                        DocumentoID = al.Id,
        //                                        Estado = al.Estado.Descripcion,
        //                                        Fecha = al.FechaCreacion,
        //                                        Observaciones = "",
        //                                        Progreso = Progreso(al.EstadoId),
        //                                        EstiloBarra = EstiloBarra(al.EstadoId),
        //                                        EstiloEstado = EstiloEstado(al.EstadoId),
        //                                        Ruta = "DDJJ/DeclaracionJurada/DomicilioVivienda",
        //                                        PermiteEdicion = true,
        //                                        PermiteReporte = true,
        //                                        PermiteSolicitud = true
        //                                    }).ToList();
        //    this.Documentos.AddRange(listaAlbacea);
        //}

        //private int Progreso(int estado)
        //{
        //    switch (estado)
        //    {
        //        case (int)EstadosBD.ConfeccionadoCausante:
        //            return 25;
        //        case (int)EstadosBD.ElevadoPersonal:
        //            return 50;
        //        case (int)EstadosBD.ModificacionSolicitada:
        //            return 50;
        //        case (int)EstadosBD.ElevadoJefeElemento:
        //            return 75;
        //        default:
        //            return 0;
        //    }
        //}
        //private string EstiloBarra(int estado)
        //{
        //    switch (estado)
        //    {
        //        case (int)EstadosBD.ConfeccionadoCausante:
        //            return "progress-bar-danger";
        //        case (int)EstadosBD.ElevadoPersonal:
        //            return "progress-bar-warning";
        //        case (int)EstadosBD.ModificacionSolicitada:
        //            return "progress-bar-secondary";
        //        case (int)EstadosBD.ElevadoJefeElemento:
        //            return "progress-bar-success";
        //        default:
        //            return "progress-bar-info";
        //    }
        //}
        //private string EstiloEstado(int estado)
        //{
        //    switch (estado)
        //    {
        //        case (int)EstadosBD.ConfeccionadoCausante:
        //            return "text-danger";
        //        case (int)EstadosBD.ElevadoPersonal:
        //            return "text-warning";
        //        case (int)EstadosBD.ModificacionSolicitada:
        //            return "text-secondary";
        //        case (int)EstadosBD.ElevadoJefeElemento:
        //            return "text-success";
        //        default:
        //            return "text-info";
        //    }

        //}

    }
}
