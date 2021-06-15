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
    public class SituacionLaboralController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public SituacionLaboralController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/SituacionLaboral
        public async Task<IActionResult> Index()
        {
            return View(await _context.SituacionLaboral.ToListAsync());
        }
        // GET: Admin/SituacionLaboral/Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/SituacionLaboral/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("ID,Descripcion")] SituacionLaboral situacionLaboral)
        {
            if (ModelState.IsValid)
            {
                _context.Add(situacionLaboral);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(situacionLaboral);
        }
        public IActionResult _TablaSituacionLaboral(Page<SituacionLaboral> page)
        {
            page.SelectPage("/Admin/SituacionLaboral/_TablaSituacionLaboral",
                _context.SituacionLaboral,
                x => (x.Descripcion.Contains(page.SearchText))
                );

            return PartialView("_TablaSituacionLaboral", page);
        }
        // GET: Admin/SituacionLaboral/Edit/5
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var situacionLaboral = await _context.SituacionLaboral.FindAsync(id);
            if (situacionLaboral == null)
            {
                return NotFound();
            }
            return PartialView(situacionLaboral);
        }

        // POST: Admin/SituacionLaboral/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, SituacionLaboral situacionLaboral)
        {
            if (id != situacionLaboral.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(situacionLaboral);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SituacionLaboralExists(situacionLaboral.Id))
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
            return View(situacionLaboral);
        }

        // GET: Admin/SituacionLaboral/Delete/5
        public async Task<IActionResult> _Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var situacionLaboral = await _context.SituacionLaboral
                .FirstOrDefaultAsync(m => m.Id == id);
            if (situacionLaboral == null)
            {
                return NotFound();
            }

            return PartialView(situacionLaboral);
        }

        // POST: Admin/SituacionLaboral/Delete/5
        [HttpPost, ActionName("_Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var situacionLaboral = await _context.SituacionLaboral.FindAsync(id);
            _context.SituacionLaboral.Remove(situacionLaboral);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SituacionLaboralExists(int id)
        {
            return _context.SituacionLaboral.Any(e => e.Id == id);
        }
    }
}
