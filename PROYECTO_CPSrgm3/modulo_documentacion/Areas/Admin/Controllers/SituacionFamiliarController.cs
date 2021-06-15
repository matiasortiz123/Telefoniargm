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
    public class SituacionFamiliarController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public SituacionFamiliarController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/SituacionFamiliar
        public IActionResult Index()
        {
            return View();
        }

        // GET: Admin/SituacionFamiliar/Details/5


        // GET: Admin/SituacionFamiliar/Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        public IActionResult _TablaSituacionFamiliar(Page<SituacionFamiliar> page)
        {
            page.SelectPage("/Admin/SituacionFamiliar/_TablaSituacionFamiliar",
                _context.SituacionFamiliar,
                x => (x.Descripcion.Contains(page.SearchText)));

            return PartialView("_TablaSituacionFamiliar", page);
        }


        // POST: Admin/SituacionFamiliar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("ID,TipoSituacion,Descripcion")] SituacionFamiliar situacionFamiliar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(situacionFamiliar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(situacionFamiliar);
        }

        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var situacionFamiliar = await _context.SituacionFamiliar.FindAsync(id);
            if (situacionFamiliar == null)
            {
                return NotFound();
            }
            return PartialView(situacionFamiliar);
        }

        // POST: Admin/EstadoCivil/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, SituacionFamiliar situacionFamiliar)
        {
            if (id != situacionFamiliar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(situacionFamiliar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SituacionFamiliarExists(situacionFamiliar.Id))
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
            return View(situacionFamiliar);
        }
       
        public async Task<IActionResult> Delete(int id)
        {
            var situacionFamiliar = await _context.SituacionFamiliar.FindAsync(id);
            _context.SituacionFamiliar.Remove(situacionFamiliar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SituacionFamiliarExists(int id)
        {
            return _context.SituacionFamiliar.Any(e => e.Id == id);
        }
    }
}
