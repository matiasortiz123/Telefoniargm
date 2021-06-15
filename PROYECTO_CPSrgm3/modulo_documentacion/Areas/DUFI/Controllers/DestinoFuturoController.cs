using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.DUFI.Models;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using Commons.Models;

namespace modulo_documentacion.Controllers
{
    [Area("DUFI")]
    public class DestinoFuturoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public DestinoFuturoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/DestinoFuturo
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "DF";
            ViewBag.Parentesco = _context.Parentesco.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.EnCaso = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value == "93" || d.Value == "95" || d.Value == "96");
            var df = _context.Dufi.Where(d => d.Id == id).Include(d => d.DestinoFuturo).ThenInclude(d => d.Parentesco).Include(d => d.GuarnicionFuturo).ThenInclude(d => d.Guarnicion).Include(d => d.ExpedienteCD).FirstOrDefault();
            return View("Index", df);
        }


        // GET: DUFI/DestinoFuturo/Create
        public IActionResult _CrearDestinoFuturo(int Id)
        {
            ViewBag.Parentesco = _context.Parentesco.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.DufiId = Id;
            return PartialView("_CrearDestinoFuturo");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearDestinoFuturo([Bind("DufiId,VinculoAfectivo,VinculoParentesco,DeseaCambioGuarnicion,DeseaCambioDestino,Fundamento,OpinionFutura")] DestinoFuturo destinoFuturo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destinoFuturo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = destinoFuturo.DufiId });
            }
            return View(destinoFuturo);
        }
        // GET: DUFI/DestinoFuturo/Edit/5
        public async Task<IActionResult> _EditarDestinoFuturo(int id)
        {
            ViewBag.Parentesco = _context.Parentesco.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            var destinoFuturo = await _context.DestinoFuturo.FindAsync(id);
            ViewBag.DufiId = destinoFuturo.DufiId;
            if (destinoFuturo == null)
            {
                return NotFound();
            }
            return PartialView("_EditarDestinoFuturo", destinoFuturo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarDestinoFuturo(int id, DestinoFuturo destinoFuturo)
        {
            if (id != destinoFuturo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(destinoFuturo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = destinoFuturo.DufiId });
            }
            return View("Index");
        }
        public async Task<IActionResult> EliminarDestinoFuturo(int id)
        {
            var destinoFuturo = await _context.DestinoFuturo.FindAsync(id);
            _context.DestinoFuturo.Remove(destinoFuturo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = destinoFuturo.DufiId });
        }
    }
}
