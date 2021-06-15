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
    public class CargoActualController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public CargoActualController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/CargoActual
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "CA";

            var cargoActual = _context.Dufi.Where(d => d.Id == id).Include(d => d.CargoActual).FirstOrDefault();

            if (cargoActual == null) return NotFound();

            return View("Index", cargoActual);
        }

       
        public IActionResult _CrearCargoActual(int Id)
        {
            ViewBag.DufiId = Id;
            return PartialView("_CrearCargoActual");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearCargoActual([Bind("DufiId,TiempoGuarnicion,TiempoDestino,TiempoCargo,CargoOcupa,CargoDeseado")] CargoActual cargoActual)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargoActual);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = cargoActual.DufiId });
            }
            return PartialView("_CrearCargoActual", cargoActual);
        }

        // GET: DUFI/CargoActual/Edit/5
        public async Task<IActionResult> _EditarCargoActual(int? id)
        {
         
            var cargoActual = await _context.CargoActual.FindAsync(id);
            ViewBag.DufiId = cargoActual.DufiId;
            if (cargoActual == null)
            {
                return NotFound();
            }
            return PartialView("_EditarCargoActual", cargoActual);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarCargoActual(int id, [Bind("Id,DufiId,TiempoGuarnicion,TiempoDestino,TiempoCargo,CargoOcupa,CargoDeseado")] CargoActual cargoActual)
        {
            if (id != cargoActual.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(cargoActual);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = cargoActual.DufiId });
            }
            ViewBag.DufiId = cargoActual.DufiId;
            return PartialView("_EditarCargoActual", cargoActual);
        }

        public async Task<IActionResult> DeleteCargoOcupa(int id)
        {
            var cargoActual = await _context.CargoActual.FindAsync(id);
            _context.CargoActual.Remove(cargoActual);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = cargoActual.DufiId });
        }

    }
}
