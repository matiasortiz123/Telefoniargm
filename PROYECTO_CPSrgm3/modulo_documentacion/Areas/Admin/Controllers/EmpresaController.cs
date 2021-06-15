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
    public class EmpresaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        public EmpresaController(ModuloDocumentacionContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult _ListadoDeEmpresas(Page<Empresa> page)
        {
            var contador = _context.Empresa.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Empresa/_ListadoDeEmpresas",
                _context.Empresa.Where(v => v.Nombre.Contains(page.SearchText) || v.Contacto.Contains(page.SearchText))
                );

            //var LineasTelefonicas = _context.Linea.ToListAsync();
            return PartialView("_ListadoDeEmpresas", page);
        }

        [HttpGet]
        public IActionResult _Create()
        {

            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Empresa empresa)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                _context.Empresa.Add(empresa);
                await _context.SaveChangesAsync();

                AddPageAlerts(PageAlertType.Success, "La empresa se creo correctamente .");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al crear la empresa, intentelo nuevamente .");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult _Detalle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var equipo = _context.Empresa.Find(id);
            if (equipo == null)
            {
                return NotFound();
            }

            return PartialView(equipo);
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
            var empresa = await _context.Empresa.FindAsync(id);
            if (empresa == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error, no se encontro la empresa, intentelo nuevamente.");
                return RedirectToAction(nameof(Index));
            }

            return PartialView(empresa);
        }


        //Http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Edit(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Empresa.Update(empresa);
                _context.SaveChanges();

                AddPageAlerts(PageAlertType.Success, "La empresa de modifico correctamente.");
                return RedirectToAction(nameof(Index));
            }
            
            AddPageAlerts(PageAlertType.Success, "Se ha producido un error al modificar el modelo, intentelo nuevamente.");
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
        public async Task<IActionResult> _DeleteEmpresa(int? id)
        {
            //obtener por id
            var empresa = await _context.Empresa.FindAsync(id);
            if (empresa == null)
            {
                AddPageAlerts(PageAlertType.Error, "Se ha producido un error ,La empresa no se elimino correctamente, intentelo nuevamente .");
                return RedirectToAction(nameof(Index));
            }

            _context.Empresa.Remove(empresa);
            await _context.SaveChangesAsync();

            AddPageAlerts(PageAlertType.Success, "La empresa se elimino correctamente .");
            return RedirectToAction(nameof(Index));
        }
    }
}
