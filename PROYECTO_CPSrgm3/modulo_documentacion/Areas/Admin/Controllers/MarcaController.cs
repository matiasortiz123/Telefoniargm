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

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarcaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public MarcaController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _ListadoDeMarcas(Page<Marca> page)
        {
            var contador = _context.Marca.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Marca/_ListadoDeMarcas",
                _context.Marca.Where(v => v.Descripcion.Contains(page.SearchText))
                .Include(m => m.Modelo)
                );

            //var LineasTelefonicas = _context.Linea.ToListAsync();
            return PartialView("_ListadoDeMarcas", page);
        }

        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {
            //Enviando listado de marcas;
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Marca marca)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                using (var transaccion = _context.Database.BeginTransaction()) 
                {
                    try
                    {
                        _context.Marca.Add(marca);
                        await _context.SaveChangesAsync();
                        transaccion.Commit(); // => Aca para terminar la transaccion
                        AddPageAlerts(PageAlertType.Success, "La marca se ha creado con exito");
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback(); // => para que en todo caso falle en la base de datos al insertar datos en la tabla , el rollback me deja todo como estaba;
                        AddPageAlerts(PageAlertType.Error, "Se ha producido un error al crear la marca, vuelva a intentalo nuevamente.");
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            else
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error al crear la marca, vuelva a intentalo nuevamente.");
                return RedirectToAction(nameof(Index));
            }
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
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
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
            var marca = await _context.Marca.Include(m => m.Modelo).Where(t => t.Id == id).FirstOrDefaultAsync();
            ViewBag.Modelo = _context.Modelo.Select(i => new SelectListItem() { Text = i.Descripcion, Value = i.Id.ToString() });
            if (marca == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error, no se ha encontrado la marca.");
                return RedirectToAction(nameof(Index));
            }

            return PartialView(marca);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Marca marca)
        {
            if (ModelState.IsValid && marca.Descripcion != null)
            {
                _context.Marca.Update(marca);
                _context.SaveChanges();

                AddPageAlerts(PageAlertType.Success, "La marca se ha editado con exito");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al editar la marca, intentelo nuevamente.");
            return RedirectToAction(nameof(Index));
        }

        //Http Get Delete
        public IActionResult _Delete(int? id)
        {

            return PartialView();
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
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error al eliminar la marca, intentelo nuevamente .");
                return RedirectToAction(nameof(Index));
            }

            _context.Marca.Remove(marca);
            await _context.SaveChangesAsync();

            AddPageAlerts(PageAlertType.Success, "La marca se ha eliminado con exito .");
            return RedirectToAction("Index");
        }

    }
}
