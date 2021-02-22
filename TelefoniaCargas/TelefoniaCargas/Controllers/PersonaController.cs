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
    public class PersonaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonaController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var persona = await _context.Persona.ToListAsync();

            return View(persona);
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
        public async Task<IActionResult> _Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Add(persona);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La persona se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La persona no se creo correctamente, intente nuevamente .";
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
            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            return PartialView(persona);
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
            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            return PartialView(persona);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Update(persona);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La persona se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La persona no se guardo correctamente intente de nuevo";
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
            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            //ViewBag.TipoEquipo = _context.TipoEquipo.Select(i => new SelectListItem() { Text = i.Marca.Descripcion, Value = i.Id.ToString() });
            //ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(persona);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> _DeletePersona(int? id)
        {
            //obtener el libro por id
            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            _context.Persona.Remove(persona);
            await _context.SaveChangesAsync();

            TempData["mensaje"] = "La unidad se elimino correctamente";

            return RedirectToAction(nameof(Index));
        }

    }
}
