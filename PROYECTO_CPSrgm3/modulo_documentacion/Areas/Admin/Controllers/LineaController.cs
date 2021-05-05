using Commons.Controllers;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LineaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public LineaController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _ListadoDeLineas(Page<Linea> page)
        {
            var contador = _context.Linea.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Linea/_ListadoDeLineas",
                _context.Linea.Where(v => v.Numero.Contains(page.SearchText))
                );

            //var LineasTelefonicas = _context.Linea.ToListAsync();
            return PartialView("_ListadoDeLineas", page);
        }

        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {

            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        public async Task<IActionResult> _Create(Linea linea)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                _context.Linea.Add(linea);
                await _context.SaveChangesAsync();

                AddPageAlerts(PageAlertType.Success, "La linea se ha creado con exito .");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al crear la linea, intentelo nuevamente .");
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
            var linea = _context.Linea.Find(id);
            if (linea == null)
            {
                return NotFound();
            }

            return PartialView(linea);
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
            var linea = await _context.Linea.FindAsync(id);
            if (linea == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error, no se ha encontrado la linea .");
                return RedirectToAction(nameof(Index));
            }

            return PartialView(linea);
        }


        //Http post Edit
        [HttpPost]
        public IActionResult _Edit(Linea linea)
        {
            if (ModelState.IsValid)
            {
                _context.Linea.Update(linea);
                _context.SaveChanges();

                AddPageAlerts(PageAlertType.Success, "La linea se modifico correctamente.");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al modificar la linea, intentelo nuevamente .");
            return RedirectToAction(nameof(Index));
        }

        //Http Get Delete
        public IActionResult _Delete(int? id)
        {

            return PartialView();
        }

        //Http Post Delete
        [HttpPost]
        public async Task<IActionResult> _DeleteLineas(int? id)
        {
            //obtener el libro por id
            var linea = await _context.Linea.FindAsync(id);
            if (linea == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error ,La Linea no se elimino correctamente, intentelo nuevamente .");
                return RedirectToAction(nameof(Index));
            }

            _context.Linea.Remove(linea);
            await _context.SaveChangesAsync();

            AddPageAlerts(PageAlertType.Success, "La Linea se elimino correctamente .");
            return RedirectToAction(nameof(Index));
        }
    }
}
