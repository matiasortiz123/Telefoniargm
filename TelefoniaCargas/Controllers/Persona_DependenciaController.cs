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
            ViewBag.Nombre = _context.Persona.Select(i => new SelectListItem() { Text = i.Nombre + " "+ i.Apellido, Value = i.Id.ToString() });
            //ViewBag.Apellido = _context.Persona.Select(i => new SelectListItem() { Text = i.Apellido, Value = i.Id.ToString() });
            //ViewBag.DNI = _context.Persona.Select(i => new SelectListItem() { Text = i.DNI.ToString(), Value = i.Id.ToString() });
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

                TempData["mensaje"] = "La persona y dependencia se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La persona y dependencia no se creo correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var equipo = _context.Persona_Dependencia.Find(id);
            if (equipo == null)
            {
                return NotFound();
            }
            
            ViewBag.Nombre = _context.Persona.Select(i => new SelectListItem() { Text = i.Nombre + " " + i.Apellido, Value = i.Id.ToString() });
            //ViewBag.Apellido = _context.Persona.Select(i => new SelectListItem() { Text = i.Apellido, Value = i.Id.ToString() });
            //ViewBag.DNI = _context.Persona.Select(i => new SelectListItem() { Text = i.DNI.ToString(), Value = i.Id.ToString() });
            ViewBag.Dependencia = _context.Dependencia.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            return PartialView(equipo);
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
            var modelo = await _context.Persona_Dependencia.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }

            ViewBag.Nombre = _context.Persona.Select(i => new SelectListItem() { Text = i.Nombre  + i.Apellido, Value = i.Id.ToString() });
           
            ViewBag.Dependencia = _context.Dependencia.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(modelo);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Persona_Dependencia persona_dEPEN)
        {
            if (ModelState.IsValid)
            {
                _context.Persona_Dependencia.Update(persona_dEPEN);
                _context.SaveChanges();

                TempData["mensaje"] = "La persona y dependencia se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La persona y dependencia no se guardo correctamente intente de nuevo";
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
            var equipo = await _context.Persona_Dependencia.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(equipo);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _DeleteEquipos(int? id)
        {
            //obtener el libro por id
            var equipo = await _context.Persona_Dependencia.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            _context.Persona_Dependencia.Remove(equipo);
            await _context.SaveChangesAsync();

            TempData["mensaje1"] = "La persona y dependencia se eliminó correctamente";

            return RedirectToAction("Index");
        }
    }
}
