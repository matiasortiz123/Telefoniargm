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
    public class UnidadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UnidadController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var unidad = await _context.Unidad.ToListAsync();

            return View(unidad);
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
        public async Task<IActionResult> _Create(Unidad unidad)
        {
            if (ModelState.IsValid)
            {
                _context.Unidad.Add(unidad);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La dependecia se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La dependencia no se creo correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }
        //Detalles
        public async Task<IActionResult> _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Objeto de Modelo
            var unidad = await _context.Unidad.FindAsync(id);
            if (unidad == null)
            {
                return NotFound();
            }

            return PartialView(unidad);
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
            var unidad = await _context.Unidad.FindAsync(id);
            if (unidad == null)
            {
                return NotFound();
            }

            return PartialView(unidad);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(Unidad unidad)
        {
            if (ModelState.IsValid)
            {
                _context.Unidad.Update(unidad);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La unidad se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La unidad no se guardo correctamente intente de nuevo";
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
            var unidad = await _context.Unidad.FindAsync(id);
            if (unidad == null)
            {
                return NotFound();
            }

            //ViewBag.TipoEquipo = _context.TipoEquipo.Select(i => new SelectListItem() { Text = i.Marca.Descripcion, Value = i.Id.ToString() });
            //ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(unidad);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> _DeleteUnidad(int? id)
        {
            //obtener el libro por id
            var unidad = await _context.Unidad.FindAsync(id);
            if (unidad == null)
            {
                return NotFound();
            }

            _context.Unidad.Remove(unidad);
            await _context.SaveChangesAsync();

            TempData["mensaje"] = "La unidad se elimino correctamente";

            return RedirectToAction(nameof(Index));
        }
    }
    
}
