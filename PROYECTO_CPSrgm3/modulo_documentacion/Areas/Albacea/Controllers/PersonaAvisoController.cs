using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Controllers
{
    [Area("Albacea")]
    public class PersonaAvisoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public PersonaAvisoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: Albacea/PersonaAviso
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "PA";

            Albacea al = _context.Albacea.Where(d => d.Id == id).Include(d => d.PersonaAviso).Include(d => d.Seguro).FirstOrDefault();

            if (al == null) return NotFound();

            return View("Index", al);
        
        }

        // GET: Albacea/PersonaAviso/Create
        public IActionResult _CrearPersonaAviso(int Id)
        {
            ViewBag.AlId = Id;
            return PartialView("_CrearPersonaAviso");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearPersonaAviso([Bind("AlbaceaId,Dni,Apellido,Nombre,Telefono,Email")] PersonaAviso personaAviso)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(personaAviso);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = personaAviso.AlbaceaId });
            }
            return View("_CrearPersonaAviso", personaAviso);
        }

        // GET: Albacea/PersonaAviso/Edit/5
        [HttpGet]
        public async Task<IActionResult> _EditarPersonaAviso(int Id)
        {
            
            var personaAviso = await _context.PersonaAviso.FindAsync(Id);
            ViewBag.AlId = personaAviso.AlbaceaId;
            if (personaAviso == null)
            {
                return NotFound();
            }
            return PartialView("_EditarPersonaAviso", personaAviso);
        }

        // POST: Albacea/PersonaAviso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarPersonaAviso(int id, PersonaAviso personaAviso)
        {
            if (id != personaAviso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(personaAviso);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = personaAviso.AlbaceaId });
            }
            return View("_EditarPersonaAviso");
        }
        public async Task<IActionResult> DeletePersonaAviso(int id)
        {
            var personaAviso = await _context.PersonaAviso.FindAsync(id);
            _context.PersonaAviso.Remove(personaAviso);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = personaAviso.AlbaceaId });
        }
    }
}
