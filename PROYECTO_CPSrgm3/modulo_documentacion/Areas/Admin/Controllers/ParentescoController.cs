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
    public class ParentescoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public ParentescoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/Parentesco
        public IActionResult Index()
        {
            return View();
        }
        // GET: Admin/Parentesco/Create
        public IActionResult _Create()
        {
            return PartialView();
        }



        // POST: Admin/Parentesco/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("ID,Descripcion")] Parentesco parentesco)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(parentesco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            //return View(parentesco);
        }

        public IActionResult _TablaParentesco(Page<Parentesco> page)
        {
            page.SelectPage("/Admin/Parentesco/_TablaEParentesco",
                _context.Parentesco,
                x => (x.Descripcion.Contains(page.SearchText) )
                );

            return PartialView("_TablaParentesco", page);
        }
        // GET: Admin/Parentesco/Edit/5
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentesco.FindAsync(id);
            if (parentesco == null)
            {
                return NotFound();
            }
            return PartialView(parentesco);
        }

        // POST: Admin/Parentesco/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, Parentesco parentesco)
        {
            if (id != parentesco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parentesco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentescoExists(parentesco.Id))
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
            return View(parentesco);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var parentesco = await _context.Parentesco.FindAsync(id);
            _context.Parentesco.Remove(parentesco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentescoExists(int id)
        {
            return _context.Parentesco.Any(e => e.Id == id);
        }
    }
}
