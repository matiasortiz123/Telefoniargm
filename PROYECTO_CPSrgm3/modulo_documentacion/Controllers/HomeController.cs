using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.ViewModels;
using Commons.Identity.Extensions;
using Microsoft.AspNetCore.Authorization;
using Commons.Controllers;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using Commons.Identity.Services;
using Commons.Identity;
using Commons.Identity.Attributes;
using modulo_documentacion.Areas.Albacea.Models;
using modulo_documentacion.Areas.DUFI.Models;
using Microsoft.AspNetCore.Http;
using CommonsCps.Apis;

namespace modulo_documentacion.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly UserService<Usuario> _userService;

        [AllowAnonymous]
        public async Task<string> verUsuarios()
        {
            return  _userService.GetUserId(User);

            //var claims = User.Claims;
            //string txt = "";
            //foreach (var v in claims)
            //{

            //    txt += v.ToString() + " -- ";

            //}
            //return txt;

        }

        public HomeController(ModuloDocumentacionContext context, UserService<Usuario> userService) : base(context)
        {
            _context = context;
            _userService = userService;
        }

        [Unsecured]
        public IActionResult Index()        
        {
            var a = HttpContext.Session.GetString("UAT");
            //ApiRecursosComunes api = new ApiRecursosComunes();
            //var b = api.GetUnidadesActivas(a);
            //api.
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Index", "ExternalLogin");
            ViewBag.Equipos = _context.Equipo.Count();
            ViewBag.Asignados = _context.Equipo.Where(e => e.Editable == false).Count();
            ViewBag.Libres = _context.Equipo.Where(e => e.Editable == true).Count();

            Usuario usuario = ObtenerUsuario(_userService);
            InicioPersonal inicio = new InicioPersonal();
            inicio.AgregarDocumentosActivos(_context, usuario);
            return View(inicio);
        }

        public IActionResult Gestion()
        {
            return View("Index_Gestion");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
