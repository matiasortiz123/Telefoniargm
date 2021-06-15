using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuarnicionController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public GuarnicionController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Admin/Guarnicion
        public IActionResult Index()
        {
            return View();
        }

        // GET: Admin/Guarnicion/Details/5


        // GET: Admin/Guarnicion/Create
        public IActionResult _Create()
        {
            return PartialView();
        }
        // POST: Admin/Guarnicion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Guarnicion guarnicion)
        {
            //   if (ModelState.IsValid)
            // {
            // _context.Add(guarnicion);
            _context.Guarnicion.Add(guarnicion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            // }
            //    return View(guarnicion);
        }

        // GET: Admin/Guarnicion/Edit/5
        public IActionResult _TablaGuarnicion(Page<Guarnicion> page)
        {
            page.SelectPage("/Admin/Guarnicion/_TablaGuarnicion",
                _context.Guarnicion,
                x => (x.Descripcion.Contains(page.SearchText) || x.Codigo.Contains(page.SearchText))
                );

            return PartialView("_TablaGuarnicion", page);
        }

        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guarnicion = await _context.Guarnicion.FindAsync(id);
            if (guarnicion == null)
            {
                return NotFound();
            }
            return PartialView(guarnicion);
        }

        // POST: Admin/Guarnicion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id,  Guarnicion guarnicion)
        {
            if (id != guarnicion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guarnicion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuarnicionExists(guarnicion.Id))
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
            return View(guarnicion);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var guarnicion = await _context.Guarnicion.FindAsync(id);
            _context.Guarnicion.Remove(guarnicion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuarnicionExists(int id)
        {
            return _context.Guarnicion.Any(e => e.Id == id);
        }
    }
}
