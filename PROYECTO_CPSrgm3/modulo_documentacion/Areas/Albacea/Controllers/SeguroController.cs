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
    public class SeguroController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public SeguroController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Albacea/Seguro
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "SE";

            
            var se = _context.Albacea.Where(d => d.Id == id).Include(d => d.Seguro).FirstOrDefault();

            if (se == null) return NotFound();
            return View("Index", se);
        }

        // GET: Albacea/Seguro/Create
        public IActionResult _CrearSeguro(int Id)
        {
            ViewBag.AlId = Id;
            return PartialView("_CrearSeguro");
        }

        // POST: Albacea/Seguro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearSeguro([Bind("AlbaceaId,Tipo,Entidad,NroPoliza,Telefono,Email")] Seguro seguro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seguro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = seguro.AlbaceaId });
            }
            return View("_CrearSeguro", seguro);
        }

        // GET: Albacea/Seguro/Edit/5
        public async Task<IActionResult> _EditarSeguro(int? Id)
        {
            var seguro = await _context.Seguro.FindAsync(Id);
            ViewBag.AlId = seguro.AlbaceaId;
            if (seguro == null)
            {
                return NotFound();
            }
            return PartialView("_EditarSeguro", seguro);
        }

        // POST: Albacea/Seguro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarSeguro(int id, Seguro seguro)
        {
            if (id != seguro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(seguro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = seguro.AlbaceaId });
            }
            return View("_EditarSeguro");
        }
        public async Task<IActionResult> DeleteSeguro(int id)
        {
            var seguro = await _context.Seguro.FindAsync(id);
            _context.Seguro.Remove(seguro);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = seguro.AlbaceaId });
        }
        

    }
}
