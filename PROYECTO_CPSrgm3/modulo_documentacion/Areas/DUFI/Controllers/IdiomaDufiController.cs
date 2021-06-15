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
    public class IdiomaDufiController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public IdiomaDufiController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/IdiomaDufi
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "ID";
            ViewBag.Idiomas = _context.Idioma.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            var idiomaDufi = _context.Dufi.Where(d => d.Id == id).Include(d => d.IdiomaDufi).Include(d => d.CargoDocenteProf).FirstOrDefault();

            if (idiomaDufi == null) return NotFound();

            return View("Index", idiomaDufi);
        }

       

        // GET: DUFI/IdiomaDufi/Create
        public IActionResult _CrearIdioma(int Id)
        {
            ViewBag.DufiId = Id;
            ViewBag.Idiomas = _context.Idioma.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            return PartialView("_CrearIdioma");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearIdioma([Bind("DufiId,IdiomaId,Nivel,FechaAcreditacion,FechaVencimiento")] IdiomaDufi idiomaDufi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(idiomaDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = idiomaDufi.DufiId });
            }
            return View(idiomaDufi);
        }

        // GET: DUFI/IdiomaDufi/Edit/5
        public async Task<IActionResult> _EditarIdioma(int? id)
        {
            
            var idiomaDufi = await _context.IdiomaDufi.FindAsync(id);
            ViewBag.DufiId = idiomaDufi.DufiId;
            ViewBag.Idiomas = _context.Idioma.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            if (idiomaDufi == null)
            {
                return NotFound();
            }
            return PartialView("_EditarIdioma", idiomaDufi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarIdioma(int id, IdiomaDufi idiomaDufi)
        {
            if (id != idiomaDufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _context.Update(idiomaDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = idiomaDufi.DufiId });
            }
            return View(idiomaDufi);
        }

        public async Task<IActionResult> EliminarIdioma(int id)
        {
            var idiomaDufi = await _context.IdiomaDufi.FindAsync(id);
            _context.IdiomaDufi.Remove(idiomaDufi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = idiomaDufi.DufiId });
        }

        public IActionResult _CrearOidioma(int Id)
        {
            ViewBag.DufiId = Id;
            return PartialView("_CrearOidioma");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearOidioma([Bind("DufiId,IdiomaOtro,Nivel,FechaAcreditacion,FechaVencimiento")] IdiomaDufi oidiomaDufi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oidiomaDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = oidiomaDufi.DufiId });
            }
            return View(oidiomaDufi);
        }

        // GET: DUFI/IdiomaDufi/Edit/5
        public async Task<IActionResult> _EditarOidioma(int? id)
        {

            var oidiomaDufi = await _context.IdiomaDufi.FindAsync(id);
            ViewBag.DufiId = oidiomaDufi.DufiId;
            if (oidiomaDufi == null)
            {
                return NotFound();
            }
            return PartialView("_EditarOidioma", oidiomaDufi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarOidioma(int id, IdiomaDufi oidiomaDufi)
        {
            if (id != oidiomaDufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _context.Update(oidiomaDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = oidiomaDufi.DufiId });
            }
            return View(oidiomaDufi);
        }

        //Cargos

        public IActionResult _CrearCargoDoc(int Id)
        {
            ViewBag.DufiId = Id;
            ViewBag.Idiomas = _context.Idioma.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            return PartialView("_CrearCargoDoc");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearCargoDoc([Bind("DufiId,Descripcion")] CargoDocenteProf cargoDocente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargoDocente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = cargoDocente.DufiId });
            }
            return View(cargoDocente);
        }

        // GET: DUFI/IdiomaDufi/Edit/5
        public async Task<IActionResult> _EditarCargoDoc(int? id)
        {

            var cargoDocente = await _context.CargoDocenteProf.FindAsync(id);
            ViewBag.DufiId = cargoDocente.DufiId;
            if (cargoDocente == null)
            {
                return NotFound();
            }
            return PartialView("_EditarCargoDoc", cargoDocente);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarCargoDoc(int id, CargoDocenteProf cargoDocente)
        {
            if (id != cargoDocente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _context.Update(cargoDocente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = cargoDocente.DufiId });
            }
            return View(cargoDocente);
        }

        public async Task<IActionResult> EliminarCargoDoc(int id)
        {
            var cargoDocente = await _context.CargoDocenteProf.FindAsync(id);
            _context.CargoDocenteProf.Remove(cargoDocente);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = cargoDocente.DufiId });
        }
    }
}
