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
    public class AsignarEquipoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AsignarEquipoController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index ()
        {
            //var asignarequipo = await _context.AsignarEquipo.Include(x => x.Persona_Dependencia).Include(x => x.Equipo).ToListAsync();
            var personasDepen =  _context.Persona_Dependencia.Include(x => x.Persona).Include(x => x.Dependencia).Include(x => x.Dependencia.Unidad).ToList();
            return View(personasDepen);
        }
        //Http Get _Create
        [HttpGet]
        public IActionResult AgregarUsuarios()
        {
            var equipos = _context.Equipo.Include(x => x.Marca).Include(x => x.Modelo).Include(x => x.Empresa).ToList();
            return View(equipos);
        }

        //Http Post _Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Create(AsignarEquipo asignarequipo)
        {
            if (ModelState.IsValid)
            {
                asignarequipo.Id = 0;
                _context.AsignarEquipo.Add(asignarequipo);
                _context.SaveChanges();

                TempData["mensaje"] = "El equipo se asigno correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El equipo no se asigno correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }
    }
}
