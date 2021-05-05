using Commons.Controllers;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Commons.Controllers.BaseController;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EquiposController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public EquiposController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var equipo = await _context.Equipo.Include(u => u.Empresa).Include(u => u.Marca)
            //    .Include(m => m.Modelo).Include(u => u.EstadoEquipo)
            //    .Include(x => x.Linea).Include(x => x.Planes).ToListAsync();

            return View();
        }

        public IActionResult _ListadoDeEquipos(Page<Equipo> page)
        {
            var contador = _context.Equipo.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Equipos/_ListadoDeEquipos",
               _context.Equipo.Include(u => u.Empresa).Include(u => u.Marca)
               .Include(m => m.Modelo).Include(u => u.EstadoEquipo)
               .Include(x => x.Linea).Include(x => x.Planes));
       
            return PartialView("_ListadoDeEquipos", page);
        }
        //Http Get _Create
        public IActionResult _Create()
        {
            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            ViewBag.Linea = _context.Linea.Select(i => new SelectListItem() { Text = i.Numero, Value = i.Id.ToString() });
            ViewBag.Planes = _context.Planes.Select(i => new SelectListItem() { Text = i.NombrePlan , Value = i.Id.ToString() });
            ViewBag.Estado = _context.EstadoEquipo.Select(i => new SelectListItem() { Text = i.Estado, Value = i.Id.ToString() });

            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        public async Task<IActionResult> _Create(Equipo equipo)
        {
            //Remover id de equipo y asigno un false a todos los equipos creados
            ModelState.Remove("Id");
            equipo.Editable = false;

            if (ModelState.IsValid)
            {
                _context.Equipo.Add(equipo);
                await _context.SaveChangesAsync();

                //Alertas de exito!!
                AddPageAlerts(PageAlertType.Success, "El equipo se ha creado con exito");
                return RedirectToAction(nameof(Index));
            }
            //Alertas de error!!
            AddPageAlerts(PageAlertType.Error, "Hubo un error al crear el equipo, intente nuevamente.");
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var equipo = _context.Equipo.Find(id);
            if (equipo == null)
            {
                return NotFound();
            }

            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            ViewBag.EstadoEquipo = _context.EstadoEquipo.Select(i => new SelectListItem() { Text = i.Estado, Value = i.Id.ToString() });
            ViewBag.Planes = _context.Planes.Select(i => new SelectListItem() { Text = i.NombrePlan , Value = i.Id.ToString() });
            ViewBag.Linea = _context.Linea.Select(i => new SelectListItem() { Text = i.Numero, Value = i.Id.ToString() });


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
            var modelo = await _context.Equipo.FirstOrDefaultAsync(x => x.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }

            ViewBag.Marca = _context.Marca.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            ViewBag.EstadoEquipo = _context.EstadoEquipo.Select(i => new SelectListItem() { Text = i.Estado, Value = i.Id.ToString() });
            ViewBag.Planes = _context.Planes.Select(i => new SelectListItem() { Text = i.NombrePlan, Value = i.Id.ToString() });
            ViewBag.Linea = _context.Linea.Select(i => new SelectListItem() { Text = i.Numero, Value = i.Id.ToString() });

            return PartialView(modelo);
        }


        //Http post Edit
        [HttpPost]
        public IActionResult _Edit(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Equipo.Update(equipo);
                _context.SaveChanges();

                AddPageAlerts(PageAlertType.Success, "El equipo se ha modificado con exito .");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al modificar el equipo, intentelo nuevamente .");
            return RedirectToAction(nameof(Index));
        }

        //Http Get Delete
        public IActionResult _Delete()
        {

            return PartialView();
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
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error al eliminar el equipo, intentelo nuevamente .");
                return RedirectToAction(nameof(Index));
            }

            _context.Equipo.Remove(equipo);
            await _context.SaveChangesAsync();

            AddPageAlerts(PageAlertType.Success, "El equipo se ha eliminado con exito .");
            return RedirectToAction(nameof(Index));
        }
    }
}
