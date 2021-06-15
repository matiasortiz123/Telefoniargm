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
    public class CursosEspDufiController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public CursosEspDufiController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/CursosEspDufi/Create
        public IActionResult _CrearCurso(int Id)
        {
            ViewBag.DufiId = Id;
            ViewBag.CursoEspecial = _context.CursoEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            return PartialView("_CrearCurso");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearCurso([Bind("DufiId,CursoEspecialId")] CursosEspDufi cursosEspDufi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cursosEspDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AptEspDufi", new { id = cursosEspDufi.DufiId });
            }
            return View(cursosEspDufi);
        }

        // GET: DUFI/CursosEspDufi/Edit/5
        public async Task<IActionResult> _EditarCurso(int id)
        {
            
            var cursosEspDufi = await _context.CursosEspDufi.FindAsync(id);
            ViewBag.CursoEspecial = _context.CursoEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.DufiId = cursosEspDufi.DufiId;
            if (cursosEspDufi == null)
            {
                return NotFound();
            }
            return PartialView(cursosEspDufi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarCurso(int id, CursosEspDufi cursosEspDufi)
        {
            if (id != cursosEspDufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(cursosEspDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AptEspDufi", new { id = cursosEspDufi.DufiId });

            }
            return PartialView(cursosEspDufi);
        }

        
        public async Task<IActionResult> EliminarCurso(int id)
        {
            var cursosEspDufi = await _context.CursosEspDufi.FindAsync(id);
            _context.CursosEspDufi.Remove(cursosEspDufi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AptEspDufi", new { id = cursosEspDufi.DufiId });
        }
    }
}
