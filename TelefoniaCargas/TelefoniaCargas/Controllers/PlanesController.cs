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
    public class PlanesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanesController (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index ()
        {
            var planes = await _context.Planes.ToListAsync();

            return View(planes);
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
        public async Task<IActionResult> _Create(Planes planes)
        {
            if (ModelState.IsValid)
            {
                _context.Planes.Add(planes);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "El plan se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El plan no se creo correctamente, intente nuevamente .";
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
            var planes = _context.Planes.Find(id);
            if (planes == null)
            {
                return NotFound();
            }

            return PartialView(planes);
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
            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                return NotFound();
            }

            return PartialView(planes);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Planes planes)
        {
            if (ModelState.IsValid)
            {
                _context.Planes.Update(planes);
                _context.SaveChanges();

                TempData["mensaje"] = "El plan se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El plan no se guardo correctamente intente de nuevo";
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
            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                return NotFound();
            }

            return PartialView(planes);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _DeletePlanes(int? id)
        {
            //obtener el libro por id
            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                return NotFound();
            }

            _context.Planes.Remove(planes);
            await _context.SaveChangesAsync();

            TempData["mensaje1"] = "El plan se elimino correctamente";

            return RedirectToAction("Index");
        }
    }
}
