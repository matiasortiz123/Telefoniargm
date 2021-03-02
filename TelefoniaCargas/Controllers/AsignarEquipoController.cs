using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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
        public JsonResult PersonasJson(string q)
        {
         
            var items = _context.Persona
                .Where(x => x.Nombre.Contains(q)
                        || x.Apellido.Contains(q)
                        || x.DNI.ToString().Contains(q)
                        )
                .Select(x => new
                {
                    Text = $"{x.Apellido}, {x.Nombre}",
                    Value = x.Id,
                    Subtext = $"{x.DNI}",
                    Icon = "fa fa-user"
                }).Take(10).ToArray();

            return Json(items);
        }

    }
}
