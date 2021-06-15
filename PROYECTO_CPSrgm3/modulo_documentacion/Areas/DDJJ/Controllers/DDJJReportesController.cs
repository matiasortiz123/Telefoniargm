using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.DDJJ.ViewModels;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using Commons.Models;
using System;
using modulo_documentacion.Controllers;

namespace modulo_documentacion.Areas.DDJJ.Controllers
{
    [Area("DDJJ")]
    public class DDJJReportesController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;

        public DDJJReportesController(ModuloDocumentacionContext context) : base(context)
        {
            _context = context;
        }

        public IActionResult Gestion()
        {
            return View();
        }

        public IActionResult _TablaDeclaracionJurada(Page<DeclaracionJurada> page)
        {
            page.SelectPage("/DDJJ/DDJJReportes/_TablaDeclaracionJurada",
                _context.DeclaracionJurada.Where(x => x.ObservacionActual.Contains(page.SearchText)).Include(d => d.Estado)
                );

            return PartialView("_TablaDeclaracionJurada", page);
        }

        public IActionResult _ReporteIndividual(int Id)
        {
            string parametros = "&id=" + "7";
            @ViewBag.PDF = "data:application/pdf;base64," + Convert.ToBase64String(common.Reporting("ddjj_declaracion_individual", parametros, "PDF"));
            return PartialView();
        }

    }
}