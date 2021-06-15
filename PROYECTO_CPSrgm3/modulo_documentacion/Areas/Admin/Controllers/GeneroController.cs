//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using modulo_documentacion.Areas.Admin.Models.Basicas;
//using modulo_documentacion.Models;
//using Commons.Controllers;
//using Commons.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GeneroController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public GeneroController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/Genero
        public IActionResult Index()
        {
            return View();
        }

        // GET: Admin/Genero/Details/5


        // GET: Admin/Genero/Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/Genero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("Descripcion")] Genero genero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genero);
        }

        // GET: Admin/Genero/Edit/5
        public IActionResult _TablaGenero(Page<Genero> page)
        {
            page.SelectPage("/Admin/Genero/_TablaGenero",
                _context.Genero,
                x => (x.Descripcion.Contains(page.SearchText)) 
                );

            return PartialView("_TablaGenero", page);
        }
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Genero.FindAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return PartialView(genero);
        }

        // POST: Admin/Genero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id,  Genero genero)
        {
            if (id != genero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneroExists(genero.Id))
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
            return View(genero);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var genero = await _context.Genero.FindAsync(id);
            _context.Genero.Remove(genero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneroExists(int id)
        {
            return _context.Genero.Any(e => e.Id == id);
        }
    }
}
