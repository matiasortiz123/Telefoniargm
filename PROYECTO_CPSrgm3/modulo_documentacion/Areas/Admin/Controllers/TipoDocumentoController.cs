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
    public class TipoDocumentoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public TipoDocumentoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/TipoDocumento
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDocumento.ToListAsync());
        }

        // GET: Admin/TipoDocumento/Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/TipoDocumento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("ID,Descripcion")] TipoDocumento tipoDocumento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDocumento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDocumento);
        }

        public IActionResult _TablaTipoDocumento(Page<TipoDocumento> page)
        {
            page.SelectPage("/Admin/TipoDocumento/_TablaTipoDocumento",
                _context.TipoDocumento,
                x => (x.Descripcion.Contains(page.SearchText))
                );

            return PartialView("_TablaTipoDocumento", page);
        }
        // GET: Admin/TipoDocumento/Edit/5
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDocumento = await _context.TipoDocumento.FindAsync(id);
            if (tipoDocumento == null)
            {
                return NotFound();
            }
            return PartialView(tipoDocumento);
        }

        // POST: Admin/TipoDocumento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, TipoDocumento tipoDocumento)
        {
            if (id != tipoDocumento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDocumento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDocumentoExists(tipoDocumento.Id))
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
            return View(tipoDocumento);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var tipoDocumento = await _context.TipoDocumento.FindAsync(id);
            _context.TipoDocumento.Remove(tipoDocumento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDocumentoExists(int id)
        {
            return _context.TipoDocumento.Any(e => e.Id == id);
        }
    }
}
