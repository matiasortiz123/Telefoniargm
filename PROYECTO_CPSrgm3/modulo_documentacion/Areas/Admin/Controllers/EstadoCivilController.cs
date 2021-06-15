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
    public class EstadoCivilController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public EstadoCivilController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/EstadoCivil
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/EstadoCivil/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("ID,Descripcion")] EstadoCivil estadoCivil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoCivil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoCivil);
        }

        // GET: Admin/EstadoCivil/Edit/5
        public IActionResult _TablaEstadoCivil(Page<EstadoCivil> page)
        {
            page.SelectPage("/Admin/EstadoCivil/_TablaEstadoCivil",
                _context.EstadoCivil,
                x => (x.Descripcion.Contains(page.SearchText) || x.SituacionFamiliar.Descripcion.Contains(page.SearchText))
                );

            return PartialView("_TablaEstadoCivil", page);
        }

        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var estadoCivil = await _context.EstadoCivil.FindAsync(id);
            if (estadoCivil == null)
            {
                return NotFound();
            }
            return PartialView(estadoCivil);
        }

        // POST: Admin/EstadoCivil/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        public async Task<IActionResult> _Edit(int id,  EstadoCivil estadoCivil)
        {
            if (id != estadoCivil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoCivil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoCivilExists(estadoCivil.Id))
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
            return View(estadoCivil);
        }
       

        public async Task<IActionResult> Delete(int id)
        {
            var estadoCivil = await _context.EstadoCivil.FindAsync(id);
            _context.EstadoCivil.Remove(estadoCivil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoCivilExists(int id)
        {
            return _context.EstadoCivil.Any(e => e.Id == id);
        }
    }
}
