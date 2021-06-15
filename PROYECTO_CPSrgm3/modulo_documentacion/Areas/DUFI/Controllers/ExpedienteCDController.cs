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
    public class ExpedienteCDController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public ExpedienteCDController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/ExpedienteCD
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "EX";

            var expedienteCD = _context.Dufi.Where(d => d.Id == id).Include(d => d.ExpedienteCD).FirstOrDefault();

            if (expedienteCD == null) return NotFound();

            return View("Index", expedienteCD);
        }

        // GET: DUFI/ExpedienteCD/Create
        public IActionResult _CrearExpedienteCD(int Id)
        {
            ViewBag.DufiId = Id;
            return PartialView("_CrearExpedienteCD");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearExpedienteCD([Bind("DufiId,TieneExpediente,NroExpediente,CausaExpediente,ActualizoExpediente,NroExpedienteAct")] ExpedienteCD expedienteCD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expedienteCD);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "DestinoFuturo", new { id = expedienteCD.DufiId });
            }
            return View(expedienteCD);
        }

        // GET: DUFI/ExpedienteCD/Edit/5
        public async Task<IActionResult> _EditarExpedienteCD(int id)
        {
            
            var expedienteCD = await _context.ExpedienteCD.FindAsync(id);
            ViewBag.DufiId = expedienteCD.DufiId;
            if (expedienteCD == null)
            {
                return NotFound();
            }
            return PartialView("_EditarExpedienteCD", expedienteCD);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarExpedienteCD(int id, ExpedienteCD expedienteCD)
        {
            if (id != expedienteCD.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(expedienteCD);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "DestinoFuturo", new { id = expedienteCD.DufiId });
            }
            return View(expedienteCD);
        }

        public async Task<IActionResult> EliminarExpedienteCD(int id)
        {
            var expedienteCD = await _context.ExpedienteCD.FindAsync(id);
            _context.ExpedienteCD.Remove(expedienteCD);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "DestinoFuturo", new { id = expedienteCD.DufiId });
        }
    }
}
