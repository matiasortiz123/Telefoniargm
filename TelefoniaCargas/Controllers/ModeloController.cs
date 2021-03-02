using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TelefoniaCargas.Data;
using TelefoniaCargas.Models;


namespace TelefoniaCargas.Controllers
{
    public class ModeloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModeloController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var modelo = await _context.Modelo.ToListAsync();
            
            return View(modelo);
        }

        //Http get Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        //Http post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Modelo.Add(modelo);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "El Modelo se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El Modelo no se creo correctamente, intente nuevamente .";
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> _Detalle(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            //Objeto de Modelo
            var modelo = await _context.Modelo.FindAsync(id);
            if(modelo == null)
            {
                return NotFound();
            }

            return PartialView(modelo);
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
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }
            
            return PartialView(modelo);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Modelo.Update(modelo);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "El Modelo se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El Modelo no se guardo correctamente intente de nuevo";
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
            var equipo = await _context.Modelo.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            //ViewBag.TipoEquipo = _context.TipoEquipo.Select(i => new SelectListItem() { Text = i.Marca.Descripcion, Value = i.Id.ToString() });
            //ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(equipo);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> _DeleteModelo(int? id)
        {
            //obtener el libro por id
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }

            _context.Modelo.Remove(modelo);
            await _context.SaveChangesAsync();

            TempData["mensaje"] = "El equipo se elimino correctamente";

            return RedirectToAction(nameof(Index));
        }
    }
}