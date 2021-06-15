using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Controllers;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.DDJJ.ViewModels;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Commons.Models;
using Commons.Identity.Services;

namespace modulo_documentacion.Areas.DDJJ.Controllers
{
    [Area("DDJJ")]
    public class ElevacionController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly UserService<Usuario> _userService;

        public ElevacionController(ModuloDocumentacionContext context, UserService<Usuario> userService) : base(context)
        {
            _context = context;
            _userService = userService;
        }

        public IActionResult Index()
        {
            int idEstado = 0;
            if (User.IsInRole("Default WorkSpace: Auxiliar Personal") || User.IsInRole("Default WorkSpace: Jefe Personal"))
                idEstado = EstadoDDJJ.ElevadoPersonal(_context).Id;
            if (User.IsInRole("Default WorkSpace: Auxiliar Elemento") || User.IsInRole("Default WorkSpace: Jefe de Elemento"))
                idEstado = EstadoDDJJ.ElevadoJefeElemento(_context).Id;
            if (User.IsInRole("Default WorkSpace: Auxiliar de DGP") || User.IsInRole("Default WorkSpace: Jefe de DGP"))
                idEstado = EstadoDDJJ.ElevadoDGP(_context).Id;

            List<DeclaracionJurada> declaracionesJuradas = _context.DeclaracionJurada.Where(d => d.EstadoID == idEstado).Include(d => d.Usuario).ToList();
            List<ElevacionDDJJViewModel> djElevacion = (from d in declaracionesJuradas
                                                        select new ElevacionDDJJViewModel
                                                        { Seleccionada = false, DeclaracionJuradaID = d.ID, Titular = d.Usuario.GetFullName(), Estado = d.Estado.Descripcion, Fecha = d.FechaCreacion, Observacion = d.ObservacionActual }).ToList();
            return View(djElevacion);
        }

        [HttpPost]
        public IActionResult ElevaElemento(List<ElevacionDDJJViewModel> djElevacion)
        {
            foreach (ElevacionDDJJViewModel djele in djElevacion)
            {
                if (djele.Seleccionada)
                {
                    DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == djele.DeclaracionJuradaID).FirstOrDefault();
                    dj.Estado = EstadoDDJJ.ElevadoJefeElemento(_context);
                    dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionElemento, "Declaracion Jurada elevada al elemento", ObtenerUsuario(_userService)), ""));
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult ElevaPersonal(List<ElevacionDDJJViewModel> djElevacion)
        {
            foreach (ElevacionDDJJViewModel djele in djElevacion)
            {
                if (djele.Seleccionada)
                {
                    DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == djele.DeclaracionJuradaID).FirstOrDefault();
                    dj.Estado = EstadoDDJJ.ElevadoPersonal(_context);
                    dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionPersonal, "Declaracion Jurada elevada al area de Personal", ObtenerUsuario(_userService)), ""));
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ElevaDGP(List<ElevacionDDJJViewModel> djElevacion)
        {
            foreach (ElevacionDDJJViewModel djele in djElevacion)
            {
                if (djele.Seleccionada)
                {
                    DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == djele.DeclaracionJuradaID).FirstOrDefault();
                    dj.Estado = EstadoDDJJ.ElevadoPersonal(_context);
                    dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionDGP, "Declaracion Jurada elevada a la Direccion General de Personal y Bienestar", ObtenerUsuario(_userService)), ""));
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }


    }
}