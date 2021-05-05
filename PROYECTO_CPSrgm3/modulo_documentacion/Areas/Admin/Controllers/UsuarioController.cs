using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;
using Commons.Models;
using Commons.Identity.Services;
using System;
using System.Security.Claims;
using Commons.Extensions;
using Commons.Identity.Extensions;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuarioController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly UserService<Usuario> _userService;
        protected readonly SignInService<Usuario> _signInService;
        public UsuarioController(ModuloDocumentacionContext context, UserService<Usuario> userService) : base(context)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            if (String.IsNullOrWhiteSpace(CommonsCps.Services.CpsSession.Uat))
            {
                return DesloguearUsuario();
            }
            else
            {
                if (((ClaimsPrincipal)User).IsAdmin() || HttpContext.UserHasRoute("/Usuarios/Index"))
                {
                    var query = await _context.Users.Where(x => x.UserName != "admin@admin.com").ToListAsync();
                    return View(query);
                }
                else
                {
                    return Redirect("/Home");
                }
            }


            return View();
        }

        public IActionResult _Create()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        public IActionResult _TablaUsuario(Page<Usuario> page)
        {
            page.SelectPage("/Admin/Usuario/_TablaUsuario",
                _context.Users.Where(x => (x.Persona.Apellido.Contains(page.SearchText))).Include(u => u.Persona)
                );

            return PartialView("_TablaUsuario", page);
        }


        public async Task<IActionResult> _Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var usuario = await _context.Users.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return PartialView(usuario);
        }

        // POST: Admin/Genero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Edit(string id, Usuario usuario)
        {
            if (id.Equals(usuario.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(usuario);
                await _context.SaveChangesAsync();
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        public async Task<IActionResult> CrearUsuariosPrueba()
        {
            //var user = new Usuario { UserName = "usuario@prueba.com", Email = "usuario@prueba.com" };
            //await _userService.CreateAsync(user, "Probando33!");
            //user = new Usuario { UserName = "auxiliarElemento@prueba.com", Email = "auxiliarElemento@prueba.com" };
            //await _userService.CreateAsync(user, "Probando33!");
            //user = new Usuario { UserName = "jefeElemento@prueba.com", Email = "jefeElemento@prueba.com" };
            //await _userService.CreateAsync(user, "Probando33!");
            //user = new Usuario { UserName = "usuarioDGP@prueba.com", Email = "usuarioDGP@prueba.com" };
            //await _userService.CreateAsync(user, "Probando33!");

            var user = new Usuario { UserName = "alanavarro", Email = "frankitonv@gmail.com" };
            await _userService.CreateAsync(user, "Tiburon12");
            return View("Index");
        }

          protected ActionResult DesloguearUsuario()
        {
            //_signInService.SignOutAsync();
            return Redirect("/Identity/Account/Login");
        }
    }
}
