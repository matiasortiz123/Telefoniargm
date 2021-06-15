using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Controllers
{
    [Area("Albacea")]
    public class ComentarioController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public ComentarioController(ModuloDocumentacionContext context):base (context)
        {
            _context = context;
        }

        // GET: Albacea/Comentario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comentario.ToListAsync());
        }
        // GET: Albacea/Comentario/Create
        public IActionResult _CrearComentario(int Id)
        {
            ViewBag.AlId = Id;
            return PartialView("_CrearComentario");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearComentario([Bind("AlbaceaId,Descripcion")] Comentario comentario)
        {
            if (ModelState.IsValid)
            {

                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Albacea", new { id = comentario.AlbaceaId });
            }
            return View("_CrearComentario", comentario);
        }

        public async Task<IActionResult> _EditarComentario(int? Id)
        {
            var comentario = await _context.Comentario.FindAsync(Id);
            ViewBag.AlId = comentario.AlbaceaId;
            if (comentario == null)
            {
                return NotFound();
            }
            return PartialView("_EditarComentario", comentario);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarComentario(int id, Comentario comentario)
        {
            if (id != comentario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Albacea", new { id = comentario.AlbaceaId});
            }
            return View("_EditarComentario");
        }
        public async Task<IActionResult> DeleteComentario(int id)
        {
            var comentario = await _context.Comentario.FindAsync(id);
            _context.Comentario.Remove(comentario);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Albacea", new { id = comentario.AlbaceaId });
        }

    }
}
