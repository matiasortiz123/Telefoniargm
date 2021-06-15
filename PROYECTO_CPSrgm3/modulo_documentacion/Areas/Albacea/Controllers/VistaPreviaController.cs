using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Models;

namespace modulo_documentacion.Controllers
{
    [Area("Albacea")]
    public class VistaPreviaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public VistaPreviaController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {

            ViewBag.MenuActivo = "VP";
            var vp = _context.Albacea.Where(d => d.Id == id).Include(d => d.Seguro).Include(d => d.PersonaAviso).Include(d => d.Usuario).Include(d => d.Comentario).First();

            if (vp == null) return NotFound();
            return View("Index", vp);
        }
    }
}