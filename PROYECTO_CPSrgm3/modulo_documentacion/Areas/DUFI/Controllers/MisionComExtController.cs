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
    public class MisionComExtController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public MisionComExtController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/MisionComExt
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "MC";
            ViewBag.Idiomas = _context.Idioma.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            //List<MisionComExt> misionComExt = _context.MisionComExt.Where(d => d.Id == id).ToList();
            var misionComExt = _context.Dufi.Where(d => d.Id == id).Include(d => d.MisionComExt).FirstOrDefault();

            if (misionComExt == null) return NotFound();
            //ViewBag.DufiID = id;

            return View("Index", misionComExt);
        }

        // GET: DUFI/MisionComExt/Create
        public IActionResult _CrearMision(int Id)
        {
            //MisionComExt misionComExt = new MisionComExt();
            //misionComExt.DufiId = Id;
            ViewBag.DufiId = Id;
            return PartialView("_CrearMision");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearMision([Bind("DufiId,Pais,Cargo,Mision,FechaInicio,FechaFin,Duracion")] MisionComExt misionComExt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(misionComExt);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = misionComExt.DufiId });
            }
            return View(misionComExt);
        }

        // GET: DUFI/MisionComExt/Edit/5
        public async Task<IActionResult> _EditarMision(int id)
        {
      
            var misionComExt = await _context.MisionComExt.FindAsync(id);
            ViewBag.DufiId = misionComExt.DufiId;
            if (misionComExt == null)
            {
                return NotFound();
            }
            return PartialView(misionComExt);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarMision(int id, MisionComExt misionComExt)
        {
            if (id != misionComExt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(misionComExt);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = misionComExt.DufiId });
            }
            return View(misionComExt);
        }
        public async Task<IActionResult> EliminarMision(int id)
        {
            var misionComExt = await _context.MisionComExt.FindAsync(id);
            _context.MisionComExt.Remove(misionComExt);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = misionComExt.DufiId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeseaOOMMP(int id, Dufi dufi)
        {
            if (id != dufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var misionComExt = _context.Dufi.Where(d => d.Id == id).Include(d => d.MisionComExt).FirstOrDefault();
                misionComExt.DeseaOOMMP = dufi.DeseaOOMMP;
                _context.Update(misionComExt);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = dufi.Id });
            }
            return View("Index",dufi);
        }

    }
}
