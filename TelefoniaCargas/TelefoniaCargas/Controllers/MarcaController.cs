using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefoniaCargas.Data;
using TelefoniaCargas.Models;

namespace TelefoniaCargas.Controllers
{
    public class MarcaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarcaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var marca = await _context.Marca.ToArrayAsync();
            return View(marca);
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
        public async Task<IActionResult> _Create(Marca marca)
        {
            if (ModelState.IsValid)
            {
                _context.Marca.Add(marca);
                await _context.SaveChangesAsync();

                TempData["mensaje"] = "La marca se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La marca no se creo correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }

        //Detalles
        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var marca = _context.Marca.Find(id);
            if (marca == null)
            {
                return NotFound();
            }

            return PartialView(marca);
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
            var marca = await _context.Marca.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            return PartialView(marca);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Marca marca)
        {
            if (ModelState.IsValid)
            {
                _context.Marca.Update(marca);
                _context.SaveChanges();

                TempData["mensaje"] = "La marca se guardo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "La marca no se guardo correctamente intente de nuevo";
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
            var marca = await _context.Marca.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            return PartialView(marca);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _DeleteMarcas(int? id)
        {
            //obtener el libro por id
            var marca = await _context.Marca.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            _context.Marca.Remove(marca);
            await _context.SaveChangesAsync();

            TempData["mensaje"] = "El equipo se elimino correctamente";

            return RedirectToAction("Index");
        }

    }


}
