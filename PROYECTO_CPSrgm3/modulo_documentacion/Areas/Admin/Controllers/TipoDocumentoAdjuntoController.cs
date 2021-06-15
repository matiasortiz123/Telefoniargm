using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TipoDocumentoAdjuntoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public TipoDocumentoAdjuntoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/TipoDocumentoAdjunto
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDocumentoAdjunto.ToListAsync());
        }
        // GET: Admin/TipoDocumentoAdjunto/Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/TipoDocumentoAdjunto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(TipoDocumentoAdjunto tipoDocumentoAdjunto)
        {
           // if (ModelState.IsValid)
            //{
                _context.Add(tipoDocumentoAdjunto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
          
         //   return View(tipoDocumentoAdjunto);
        }
        public IActionResult _TablaTipoDocumentoAdjunto(Page<TipoDocumentoAdjunto> page)
        {
            page.SelectPage("/Admin/TipoDocumentoAdjunto/_TablaTipoDocumentoAdjunto",
                _context.TipoDocumentoAdjunto,
                x => (x.Descripcion.Contains(page.SearchText))
                );

            return PartialView("_TablaTipoDocumentoAdjunto", page);
        }

        // GET: Admin/TipoDocumentoAdjunto/Edit/5
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDocumentoAdjunto = await _context.TipoDocumentoAdjunto.FindAsync(id);
            if (tipoDocumentoAdjunto == null)
            {
                return NotFound();
            }
            return PartialView(tipoDocumentoAdjunto);
        }

        // POST: Admin/TipoDocumentoAdjunto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, TipoDocumentoAdjunto tipoDocumentoAdjunto)
        {
            if (id != tipoDocumentoAdjunto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDocumentoAdjunto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDocumentoAdjuntoExists(tipoDocumentoAdjunto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDocumentoAdjunto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var tipoDocumentoAdjunto = await _context.TipoDocumentoAdjunto.FindAsync(id);
            _context.TipoDocumentoAdjunto.Remove(tipoDocumentoAdjunto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDocumentoAdjuntoExists(int id)
        {
            return _context.TipoDocumentoAdjunto.Any(e => e.Id == id);
        }
    }
}
