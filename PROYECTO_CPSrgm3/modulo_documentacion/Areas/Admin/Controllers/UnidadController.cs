using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CommonsCps.Apis;
using CommonsCps.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using modulo_documentacion.Areas.Admin.Models.Basicas;
//using modulo_documentacion.Models;
using Commons.Models;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UnidadController :  BaseController
    {
        //private readonly ModuloDocumentacionContext _context;
        private ApiRecursosComunes _api;

        public UnidadController(ModuloDocumentacionContext context) : base(context)
        {
            //_context = context;
            _api = new ApiRecursosComunes();
        }
        public IActionResult Index()
        {
            return View();
        }
        //public ActionResult _TablaUnidad(Page<Unidad> page)
        //{
        //    var UAT = HttpContext.Session.GetString("UAT");
        //    var Unidades = _api.GetUnidadesActivas(UAT);
        //    if (Unidades.status == 200)
        //    {
        //        page.SelectPage("_TablaUnidad", Unidades.Unidades.AsQueryable());
        //        return PartialView("_TablaUnidad", page);
        //    }
        //    else
        //    {
        //        page.SelectPage("Unidad/_TablaUnidad", null);
        //        return PartialView("_TablaUnidad", page);
        //    }
        //}

    }
}
