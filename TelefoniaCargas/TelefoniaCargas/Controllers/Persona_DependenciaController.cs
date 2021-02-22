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
    public class Persona_DependenciaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Persona_DependenciaController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index ()
        {
            var persona_dependencia = await _context.Persona_Dependencia.Include(x => x.Persona).Include(x => x.Dependencia).Include(x => x.Dependencia.Unidad).ToListAsync();

            return View(persona_dependencia);
        }
        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {
            ViewBag.Nombre = _context.Persona.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            ViewBag.Apellido = _context.Persona.Select(i => new SelectListItem() { Text = i.Apellido, Value = i.Id.ToString() });
            ViewBag.DNI = _context.Persona.Select(i => new SelectListItem() { Text = i.DNI.ToString(), Value = i.Id.ToString() });
            ViewBag.Dependencia = _context.Dependencia.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Create(Persona_Dependencia persona_dependencia)
        {
            if (ModelState.IsValid)
            {
                persona_dependencia.Id = 0;
                _context.Persona_Dependencia.Add(persona_dependencia);
                _context.SaveChanges();

                TempData["mensaje"] = "El equipo se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El equipo no se creo correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }
    }
}
