using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.DUFI.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Controllers
{
    [Area("DUFI")]
    public class RevisionDufiController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public RevisionDufiController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "VP";
            ViewBag.Parentesco = _context.Parentesco.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.EnCaso = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value == "93" || d.Value == "95" || d.Value == "96");
            ViewBag.Idiomas = _context.Idioma.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.aptitud = _context.AptitudEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.tipo = _context.TipoCapacitacion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.curso = _context.CursoEspecial.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.tipoRegistro = _context.TipoRegistroConductor.Select(l => new SelectListItem() { Text = l.Codigo, Value = l.Id.ToString() });

            var r = _context.Dufi.Where(d => d.Id == id).Include(d => d.CargoActual).Include(d => d.DestinoFuturo).Include(d => d.IdiomaDufi).Include(d=>d.ExpedienteCD).Include(d => d.GuarnicionFuturo).Include(d => d.CargoDocenteProf).Include(d => d.MisionComExt).Include(d => d.AptEspDufi).Include(d => d.CursosEspDufi).Include(d => d.ConductorMotorista).Include(d => d.RegistroConductorDufi).First();
            
            if (r == null) return NotFound();

            return View(r);
        }
    }
}