using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.DUFI.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using Commons.Models;

namespace modulo_documentacion.Controllers
{
    [Area("DUFI")]
    public class AptEspDufiController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public AptEspDufiController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/AptEspDufi
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "AE";
            ViewBag.aptitud = _context.AptitudEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.tipo = _context.TipoCapacitacion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.curso = _context.CursoEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.tipoRegistro = _context.TipoRegistroConductor.Select(l => new SelectListItem() { Text = l.Codigo, Value = l.Id.ToString() });
            var aptEspDufi = _context.Dufi.Where(d => d.Id == id).Include(d => d.AptEspDufi).Include(d => d.CursosEspDufi).Include(d => d.ConductorMotorista).Include(d => d.RegistroConductorDufi).FirstOrDefault();

            if (aptEspDufi == null) return NotFound();
            //ViewBag.DufiID = id;

            return View("Index", aptEspDufi);
        }

       
        public IActionResult _CrearAptEsp(int Id)
        {
            ViewBag.DufiId = Id;
            ViewBag.aptitud = _context.AptitudEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.tipo = _context.TipoCapacitacion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            return PartialView("_CrearAptEsp");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearAptEsp([Bind("DufiId,TipoCapacitacionId,AptEspId,FechaHabilitacion")] AptEspDufi aptEspDufi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aptEspDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = aptEspDufi.DufiId });
            }
            return View(aptEspDufi);
        }

        // GET: DUFI/AptEspDufi/Edit/5
        public async Task<IActionResult> _EditarAptEsp(int id)
        {

            var aptEspDufi = await _context.AptEspDufi.FindAsync(id);
            ViewBag.aptitud = _context.AptitudEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.tipo = _context.TipoCapacitacion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.DufiId = aptEspDufi.DufiId;
            if (aptEspDufi == null)
            {
                return NotFound();
            }
            return PartialView(aptEspDufi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarAptEsp(int id, AptEspDufi aptEspDufi)
        {
            if (id != aptEspDufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(aptEspDufi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = aptEspDufi.DufiId });
            }
            return View(aptEspDufi);
        }

        
        public async Task<IActionResult> EliminarAptEsp(int id)
        {
            var aptEspDufi = await _context.AptEspDufi.FindAsync(id);
            _context.AptEspDufi.Remove(aptEspDufi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = aptEspDufi.DufiId });
            //throw new NotImplementedException();
        }
        public IActionResult SelectListJsonAptitudes(int tipoId)
        {
            var items = _context.AptitudEspecial.Include(x => x.TipoCapacitacion)
                .Select(x => new
                {
                    Text = $"{x.Descripcion}",
                    Value = x.Id,
                    Tipo = x.TipoCapacitacion.Id
                }).Where(x => x.Tipo==tipoId).Take(50).ToArray();

            return Json(items);
        }

    }
}
