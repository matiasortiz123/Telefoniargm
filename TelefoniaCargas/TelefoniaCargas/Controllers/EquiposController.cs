﻿using System;
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
    public class EquiposController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public EquiposController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var equipo = await _context.Equipo.Include(u => u.Marca).Include(u => u.Empresa).Include(m => m.Modelo).ToListAsync();
            return View(equipo);
        }

        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {
            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString()});
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Create(Equipo equipo)
        {
            if(ModelState.IsValid)
            {
                equipo.Id = 0;
                _context.Equipo.Add(equipo);
                 _context.SaveChanges();

                TempData["mensaje"] = "El equipo se creo correctamente";
                return RedirectToAction(nameof(Index));
            }

            TempData["mensaje"] = "El equipo no se creo correctamente, intente nuevamente .";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var equipo = _context.Equipo.Find(id);
            if(equipo == null)
            {
                return NotFound();
            }

            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
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
            var modelo = await _context.Equipo.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }

            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });

            return PartialView(modelo);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Equipo.Update(equipo);
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
            var equipo = await _context.Equipo.FindAsync(id);
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
            var equipo = await _context.Equipo.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            _context.Equipo.Remove(equipo);
            await _context.SaveChangesAsync();

            TempData["mensaje"] = "El equipo se elimino correctamente";

            return RedirectToAction("Index");
        }

    }
}