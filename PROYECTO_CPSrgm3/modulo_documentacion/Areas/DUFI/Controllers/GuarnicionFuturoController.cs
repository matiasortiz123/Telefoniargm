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
    public class GuarnicionFuturoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public GuarnicionFuturoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        // GET: DUFI/GuarnicionFuturo
        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "GF";

            var guarnicionFuturo = _context.Dufi.Where(d => d.Id == id).Include(d => d.GuarnicionFuturo).FirstOrDefault();

            if (guarnicionFuturo == null) return NotFound();

            return View("Index", guarnicionFuturo);
        }

       

        // GET: DUFI/GuarnicionFuturo/Create
        public IActionResult _CrearGuarnicionFuturo(int Id)
        {
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.EnCaso = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value == "93" || d.Value == "95" || d.Value == "96");
            ViewBag.DufiId = Id;
            return PartialView("_CrearGuarnicionFuturo");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearGuarnicionFuturo([Bind("DufiId,DeseaGuarnicion1,DeseaGuarnicion2,DeseaGuarnicion3,PermanecerGuarnicion,UltimaZona")] GuarnicionFuturo guarnicionFuturo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guarnicionFuturo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "DestinoFuturo", new { id = guarnicionFuturo.DufiId });
            }
            return View(guarnicionFuturo);
        }

        // GET: DUFI/GuarnicionFuturo/Edit/5
        public async Task<IActionResult> _EditarGuarnicionFuturo(int? id)
        {
  
            var guarnicionFuturo = await _context.GuarnicionFuturo.FindAsync(id);
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.EnCaso = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value == "93" || d.Value == "95" || d.Value == "96");
            ViewBag.DufiId = guarnicionFuturo.DufiId;
            if (guarnicionFuturo == null)
            {
                return NotFound();
            }
            return PartialView("_EditarGuarnicionFuturo", guarnicionFuturo);
        }      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarGuarnicionFuturo(int id, GuarnicionFuturo guarnicionFuturo)
        {
            if (id != guarnicionFuturo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(guarnicionFuturo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "DestinoFuturo", new { id = guarnicionFuturo.DufiId });
            }
            return View(guarnicionFuturo);
        }
        
        public async Task<IActionResult> EliminarGuarnicionFuturo(int id)
        {
            var guarnicionFuturo = await _context.GuarnicionFuturo.FindAsync(id);
            _context.GuarnicionFuturo.Remove(guarnicionFuturo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "DestinoFuturo", new { id = guarnicionFuturo.DufiId });
        }
    }
}
