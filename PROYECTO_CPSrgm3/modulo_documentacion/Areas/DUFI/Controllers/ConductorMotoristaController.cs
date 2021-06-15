using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.DUFI.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Controllers
{
    [Area("DUFI")]
    public class ConductorMotoristaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public ConductorMotoristaController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/ConductorMotorista/Create
        public IActionResult _CrearConductor(int Id)
        {
            ViewBag.DufiId = Id;
            return PartialView("_CrearConductor");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearConductor([Bind("DufiId,LicenciaConducir,FechaUltimaRenovacion,FechaVencimiento")] ConductorMotorista conductorMotorista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conductorMotorista);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AptEspDufi", new { id = conductorMotorista.DufiId });
            }
            return View(conductorMotorista);
        }

        // GET: DUFI/ConductorMotorista/Edit/5
        public async Task<IActionResult> _EditarConductor(int id)
        {
            
            var conductorMotorista = await _context.ConductorMotorista.FindAsync(id);
            ViewBag.DufiId = conductorMotorista.DufiId;
            if (conductorMotorista == null)
            {
                return NotFound();
            }
            return PartialView(conductorMotorista);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarConductor(int id, ConductorMotorista conductorMotorista)
        {
            if (id != conductorMotorista.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(conductorMotorista);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AptEspDufi", new { id = conductorMotorista.DufiId });
            }
            return View(conductorMotorista);
        }

        public async Task<IActionResult> EliminarConductor(int id)
        {
            var conductorMotorista = await _context.ConductorMotorista.FindAsync(id);
            _context.ConductorMotorista.Remove(conductorMotorista);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AptEspDufi", new { id = conductorMotorista.DufiId });
        }
        public IActionResult _CrearRegistro(int Id)
        {
            ViewBag.tipoRegistro = _context.TipoRegistroConductor.Select(l => new SelectListItem() { Text = l.Codigo, Value = l.Id.ToString() });
            ViewBag.DufiId = Id;
            return PartialView("_CrearRegistro");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearRegistro([Bind("DufiId,TipoRegistro")] RegistroConductorDufi registroConductorDufi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroConductorDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AptEspDufi", new { id = registroConductorDufi.DufiId });
            }
            return View(registroConductorDufi);
        }
        public async Task<IActionResult> _EditarRegistro(int id)
        {

            var registroConductorDufi = await _context.RegistroConductorDufi.FindAsync(id);
            ViewBag.tipoRegistro = _context.TipoRegistroConductor.Select(l => new SelectListItem() { Text = l.Codigo, Value = l.Id.ToString() });
            ViewBag.DufiId = registroConductorDufi.DufiId;
            if (registroConductorDufi == null)
            {
                return NotFound();
            }
            return PartialView(registroConductorDufi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarRegistro(int id, RegistroConductorDufi registroConductorDufi)
        {
            if (id != registroConductorDufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(registroConductorDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AptEspDufi", new { id = registroConductorDufi.DufiId });
            }
            return View(registroConductorDufi);
        }
        public async Task<IActionResult> EliminarRegistro(int id)
        {
            var registroConductorDufi = await _context.RegistroConductorDufi.FindAsync(id);
            _context.RegistroConductorDufi.Remove(registroConductorDufi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AptEspDufi", new { id = registroConductorDufi.DufiId });
        }
    }
}
