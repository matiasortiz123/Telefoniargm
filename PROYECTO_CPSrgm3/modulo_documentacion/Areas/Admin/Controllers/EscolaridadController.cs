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
    public class EscolaridadController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public EscolaridadController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
       

        // GET: Admin/Escolaridad/Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/Escolaridad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("ID,Descripcion,Tipo")] Escolaridad escolaridad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(escolaridad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(escolaridad);
        }

        // GET: Admin/Escolaridad/Edit/5
        public IActionResult _TablaEscolaridad(Page<Escolaridad> page)
        {
            page.SelectPage("/Admin/Escolaridad/_TablaEscolaridad",
                _context.Escolaridad,
                x => (x.Descripcion.Contains(page.SearchText) || x.Tipo.Contains(page.SearchText))
                );

            return PartialView("_TablaEscolaridad", page);
        }

        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var escolaridad = await _context.Escolaridad.FindAsync(id);
            if (escolaridad == null)
            {
                return NotFound();
            }
            return PartialView(escolaridad);
        }

        // POST: Admin/Escolaridad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, Escolaridad escolaridad)
        {
            if (id != escolaridad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(escolaridad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EscolaridadExists(escolaridad.Id))
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
            return View(escolaridad);
        }


        // POST: Admin/TipoDocumento/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var Escolaridad = await _context.Escolaridad.FindAsync(id);
            _context.Escolaridad.Remove(Escolaridad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool EscolaridadExists(int id)
        {
            return _context.Escolaridad.Any(e => e.Id == id);
        }
    }
}
