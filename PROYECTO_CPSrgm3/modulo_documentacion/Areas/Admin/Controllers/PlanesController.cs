using Commons.Controllers;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlanesController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public PlanesController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _ListadoDePlanes(Page<Planes> page)
        {
            var contador = _context.Planes.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Planes/_ListadoDePlanes",
                _context.Planes.Where(v => v.NombrePlan.Contains(page.SearchText)).Include(e => e.Empresa)
                );

            //var LineasTelefonicas = _context.Linea.ToListAsync();
            return PartialView("_ListadoDePlanes", page);
        }

        //Http Get _Create
        [HttpGet]
        public IActionResult _Create()
        {
            ViewBag.Empresa = _context.Empresa.Select(i => new SelectListItem() { Text = i.Nombre, Value = i.Id.ToString() });
            return PartialView();
        }

        //Http Post _Create
        [HttpPost]
        public async Task<IActionResult> _Create(Planes planes)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                _context.Planes.Add(planes);
                await _context.SaveChangesAsync();

                AddPageAlerts(PageAlertType.Success, "El plan se ha creado con exito");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al crear el plan , intentelo nuevamente .");
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
            var planes = _context.Planes.Find(id);
            if (planes == null)
            {
                return NotFound();
            }

            return PartialView(planes);
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
            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error, no se ha encontrado la marca.");
                return RedirectToAction(nameof(Index));
            }

            return PartialView(planes);
        }


        //Http post Edit
        [HttpPost]
        public IActionResult _Edit(Planes planes)
        {
            if (ModelState.IsValid)
            {
                _context.Planes.Update(planes);
                _context.SaveChanges();

                AddPageAlerts(PageAlertType.Success, "El plan se modifico correctamente .");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al modificar el plan , intentelo nuevamente .");
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
        public async Task<IActionResult> _DeletePlanes(int? id)
        {
            //obtener el libro por id
            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                AddPageAlerts(PageAlertType.Error, "El plan no se elimino correctamente");
                return RedirectToAction("Index");
            }

            _context.Planes.Remove(planes);
            await _context.SaveChangesAsync();

            AddPageAlerts(PageAlertType.Success, "El plan se elimino correctamente");
            return RedirectToAction("Index");
        }
    }
}
