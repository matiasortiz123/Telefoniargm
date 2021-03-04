using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelefoniaCargas.Data;
using TelefoniaCargas.Models;

namespace TelefoniaCargas.Controllers
{
    public class LineaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LineaController (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index ()
        {
            var linea = await _context.Linea.ToListAsync();
            return View(linea);
        }
        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {

            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Linea linea)
        {
            if (ModelState.IsValid)
            {
                _context.Linea.Add(linea);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La linea se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La linea no se creo correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }
        //Detalles
        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var linea = _context.Linea.Find(id);
            if (linea == null)
            {
                return NotFound();
            }

            return PartialView(linea);
        }
        //Http get Edit
        [HttpGet]
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener datos del equipo
            var linea = await _context.Linea.FindAsync(id);
            if (linea == null)
            {
                return NotFound();
            }

            return PartialView(linea);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Linea linea)
        {
            if (ModelState.IsValid)
            {
                _context.Linea.Update(linea);
                _context.SaveChanges();

                TempData["mensaje"] = "La linea se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La linea no se guardo correctamente intente de nuevo";
            return RedirectToAction(nameof(Index));
        }
        //Http Get Delete
        public async Task<IActionResult> _Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener datos del equipo
            var linea = await _context.Linea.FindAsync(id);
            if (linea == null)
            {
                return NotFound();
            }

            return PartialView(linea);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _DeleteLinea(int? id)
        {
            //obtener el libro por id
            var linea = await _context.Linea.FindAsync(id);
            if (linea == null)
            {
                return NotFound();
            }

            _context.Linea.Remove(linea);
            await _context.SaveChangesAsync();

            TempData["mensaje1"] = "La linea se elimino correctamente";

            return RedirectToAction("Index");
        }

    }
}

