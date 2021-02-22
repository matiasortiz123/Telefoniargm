using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelefoniaCargas.Data;
using TelefoniaCargas.Models;

namespace TelefoniaCargas.Controllers
{
    public class EmpresaController : Controller
    {
        //Es la porpiedad de la Base de Datos;
        private readonly ApplicationDbContext _context;

        public EmpresaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var empresa = await _context.Empresa.ToListAsync();

            return View(empresa);
        }

        [HttpGet]
        public IActionResult _Create()
        {

            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Empresa.Add(empresa);
                await _context.SaveChangesAsync();
                TempData["mensaje"] = "La empresa se creo correctamente";

                return RedirectToAction(nameof(Index));
            }

            return PartialView("_Create", empresa);
        }

        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var equipo = _context.Empresa.Find(id);
            if (equipo == null)
            {
                return NotFound();
            }

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
            var modelo = await _context.Empresa.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }

            return PartialView(modelo);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Empresa.Update(empresa);
                _context.SaveChanges();

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
            var empresa = await _context.Empresa.FindAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }

            return PartialView(empresa);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _DeleteEmpresa(int? id)
        {
            //obtener el libro por id
            var empresa = await _context.Empresa.FindAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }

            _context.Empresa.Remove(empresa);
            await _context.SaveChangesAsync();

            TempData["mensaje"] = "El equipo se elimino correctamente";

            return RedirectToAction(nameof(Index));
        }
    }
}