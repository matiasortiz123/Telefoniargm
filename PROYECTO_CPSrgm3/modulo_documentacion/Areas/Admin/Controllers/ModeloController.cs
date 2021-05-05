using Commons.Controllers;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class ModeloController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public ModeloController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {          

            return View();
        }

        public IActionResult _ListadoDeModelos(Page<Modelo> page)
        {
            var contador = _context.Modelo.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Modelo/_ListadoDeModelos",
                _context.Modelo.Where(v => v.Descripcion.Contains(page.SearchText))
                );

            return PartialView("_ListadoDeModelos", page);
        }

        //Http get Create
        public IActionResult _Create()
        {
            return PartialView();
        }

        //Http post Create
        [HttpPost]
        public async Task<IActionResult> _Create(Modelo modelo)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {

                _context.Modelo.Add(modelo);
                await _context.SaveChangesAsync();

                AddPageAlerts(PageAlertType.Success, "El Modelo se creo correctamente");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "El Modelo no se creo correctamente, intente nuevamente .");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Objeto de Modelo
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }

            return PartialView(modelo);
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
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error, no se ha encontrado la linea.");
                return RedirectToAction(nameof(Index));
            }

            return PartialView(modelo);
        }


        //Http post Edit
        [HttpPost]
        public async Task<IActionResult> _Edit(Modelo modelo)
        {
            if (ModelState.IsValid && modelo.Descripcion != null)
            {
                _context.Modelo.Update(modelo);
                await _context.SaveChangesAsync();

                AddPageAlerts(PageAlertType.Success, "El modelo del equipo se modifico correctamente.");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error, vuelva a intentarlo nuevamente.");
            return RedirectToAction(nameof(Index));
        }

        //Http Get Delete
        public IActionResult _Delete(int? id)
        {  
            return PartialView();
        }

        //Http Post Delete
        [HttpPost]
        public async Task<IActionResult> _DeleteModelo(int? id)
        {
            //obtener el libro por id
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error al eliminar el modelo, intentelo nuevamente.");
                return RedirectToAction(nameof(Index));
            }

            _context.Modelo.Remove(modelo);
            await _context.SaveChangesAsync();

            AddPageAlerts(PageAlertType.Success, "El modelo del equipo se ha eliminado con exito .");
            return RedirectToAction(nameof(Index));
        }
    }
}
