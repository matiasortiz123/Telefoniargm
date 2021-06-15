using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using Commons.Models;
using System;
using modulo_documentacion.Controllers;

namespace modulo_documentacion.Areas.Albacea.Controllers
{
    [Area("Albacea")]
    public class AlbaceaReportesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public AlbaceaReportesController(ModuloDocumentacionContext context) : base(context)
        {
        }

        public IActionResult _ReporteIndividual(int Id)
        {
            string parametros = "&id=" + Id.ToString();
            @ViewBag.PDF = "data:application/pdf;base64," + Convert.ToBase64String(common.Reporting("albacea_individual", parametros, "PDF"));
            return PartialView();
        }
    }
    
}