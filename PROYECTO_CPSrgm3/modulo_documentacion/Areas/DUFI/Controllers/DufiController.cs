using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.DUFI.Models;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;      
using Commons.Models;
using Commons.Identity.Services;

namespace modulo_documentacion.Controllers
{
    [Area("DUFI")]
    public class DufiController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly UserService<Usuario> _userService;

        public DufiController(ModuloDocumentacionContext context, UserService<Usuario> userService) : base(context)
        {
            _context = context;
            _userService = userService;
        }

        // GET: DUFI/Dufi
        public async Task<IActionResult> Index()
        {
            var moduloDocumentacionContext = _context.Dufi.Include(d => d.Estado);
            return View(await moduloDocumentacionContext.ToListAsync());
        }

        public IActionResult GestionDufi(Usuario usuario)
        {
            ViewBag.Usuario = usuario.GetFullName();
            return View();
        }
        public IActionResult _TablaDufi(Page<Dufi> page)
        {
            page.SelectPage("/DUFI/Dufi/_TablaDufi", _context.Dufi.Include(d => d.Estado)
                );
            return PartialView("_TablaDufi", page);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearDufi(Usuario usuario)
        {
            Dufi dufi = new Dufi();
            dufi.FechaCreacion = DateTime.Today;
            dufi.EstadoId = Estado.obtenerEstadoInicial(_context);
            //Persona per = new Persona();
            //per.Genero = Genero.Inicial(_context);
            //per.TipoDocumento = TipoDocumento.Inicial(_context);
            //per.NroDocumento = 11222333;
            //per.Nombre = usuario.GetFirstName();
            //per.Apellido = usuario.GetLastName();
            //per.FechaNacimiento = DateTime.Today;
            //dufi.Persona = per;
            dufi.Usuario = ObtenerUsuario(_userService);
            _context.Add(dufi);
            _context.SaveChanges();
            return RedirectToAction("Index", "CargoActual", new { id = dufi.Id });

        }

        // GET: DUFI/Dufi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dufi = await _context.Dufi
                .Include(d => d.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dufi == null)
            {
                return NotFound();
            }

            return View(dufi);
        }

        // GET: DUFI/Dufi/Create
        public IActionResult Create()
        {
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id");
            return View();
        }

        // POST: DUFI/Dufi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaCreacion,EstadoId")] Dufi dufi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dufi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", dufi.EstadoId);
            return View(dufi);
        }

        // GET: DUFI/Dufi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dufi = await _context.Dufi.FindAsync(id);
            if (dufi == null)
            {
                return NotFound();
            }
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", dufi.EstadoId);
            return View(dufi);
        }

        // POST: DUFI/Dufi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaCreacion,EstadoId")] Dufi dufi)
        {
            if (id != dufi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dufi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DufiExists(dufi.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", dufi.EstadoId);
            return View(dufi);
        }

        // GET: DUFI/Dufi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dufi = await _context.Dufi
                .Include(d => d.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dufi == null)
            {
                return NotFound();
            }

            return View(dufi);
        }

        // POST: DUFI/Dufi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dufi = await _context.Dufi.FindAsync(id);
            _context.Dufi.Remove(dufi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DufiExists(int id)
        {
            return _context.Dufi.Any(e => e.Id == id);
        }
    }
}
