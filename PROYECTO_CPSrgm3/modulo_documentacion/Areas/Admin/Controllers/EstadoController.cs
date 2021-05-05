using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EstadoController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public EstadoController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        // GET: Admin/Estados/Details/5
        public IActionResult _Create()
        {
            return PartialView();
        }

        // POST: Admin/Estados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("Codigo,Descripcion")] Estado Estado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Estado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Estado);
        }

        public IActionResult _TablaEstado(Page<Estado> page)
        {
            page.SelectPage("/Admin/Estado/_TablaEstado",
                _context.Estado  );

            return PartialView("_TablaEstado", page);
        }


        // GET: Admin/Estados/Edit/5
        public async Task<IActionResult> _Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Estado = await _context.Estado.FindAsync(id);
            if (Estado == null)
            {
                return NotFound();
            }
            return PartialView(Estado);
        }

        // POST: Admin/Estados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(int id, Estado Estado)
        {
            if (id != Estado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Estado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadosExists(Estado.Id))
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
            return View(Estado);
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var Estado = await _context.Estado.FindAsync(id);
            _context.Estado.Remove(Estado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadosExists(int id)
        {
            return _context.Estado.Any(e => e.Id == id);
        }
    }
}
