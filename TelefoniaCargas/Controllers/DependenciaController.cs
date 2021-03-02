using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelefoniaCargas.Data;
using TelefoniaCargas.Models;

namespace TelefoniaCargas.Controllers
{
    public class DependenciaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DependenciaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dependencia = await _context.Dependencia.Include(x => x.Unidad).ToListAsync();

            return View(dependencia);
        }
        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {
            ViewBag.Unidad = _context.Unidad.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Dependencia dependencia)
        {
            if (ModelState.IsValid)
            {
                _context.Dependencia.Add(dependencia);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La dependencia se creo correctamente";
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
            var dependencia = await _context.Dependencia.FindAsync(id);
            if (dependencia == null)
            {
                return NotFound();
            }

            return PartialView(dependencia);
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
            var dependencia = await _context.Dependencia.FindAsync(id);
            if (dependencia == null)
            {
                return NotFound();
            }

            return PartialView(dependencia);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(Dependencia dependencia)
        {
            if (ModelState.IsValid)
            {
                _context.Dependencia.Update(dependencia);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La dependencia se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La dependencia no se guardo correctamente intente de nuevo";
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
            var dependencia = await _context.Dependencia.FindAsync(id);
            if (dependencia == null)
            {
                return NotFound();
            }

            //ViewBag.TipoEquipo = _context.TipoEquipo.Select(i => new SelectListItem() { Text = i.Marca.Descripcion, Value = i.Id.ToString() });
            //ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(dependencia);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> _DeleteDependencia(int? id)
        {
            //obtener el libro por id
            var dependencia = await _context.Dependencia.FindAsync(id);
            if (dependencia == null)
            {
                return NotFound();
            }

            _context.Dependencia.Remove(dependencia);
            await _context.SaveChangesAsync();

            TempData["mensaje1"] = "La dependencia se elimino correctamente";

            return RedirectToAction(nameof(Index));
        }
    }
}
