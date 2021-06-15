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
using modulo_documentacion.Services;
using Commons.Identity.Services;

namespace modulo_documentacion.Controllers
{
    [Area("Albacea")]
    public class AlbaceaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly PersonalService _servicios;
        private readonly UserService<Usuario> _userService;


        public AlbaceaController(ModuloDocumentacionContext context, PersonalService service, UserService<Usuario> userService) : base(context)
        {
            _context = context;
            _servicios = service;
            _userService = userService;
        }


        public IActionResult Index(int id)
        {
            ViewBag.MenuActivo = "AL";
            Albacea al = _context.Albacea.Where(d => d.Id == id).Include(d => d.Usuario).Include(d => d.Comentario).FirstOrDefault();
            return View("Index", al);
        }
        public IActionResult BusquedaDni(int id)
        {
                PersonaAlbacea al = _servicios.ObtenerPersonaAlbacea(id);
            return Json(al);
         //   return JSONEncoder(al);
        }
        public IActionResult GestionAlbacea(Usuario usuario)
        {
            ViewBag.Usuario = usuario.GetFullName();
            return View();
        }
        public IActionResult _TablaAlbacea(Page<Albacea> page)
        {
            page.SelectPage("/DDJJ/Albacea/_TablaAlbacea", _context.Albacea.Include(d => d.Estado)
                );
            return PartialView("_TablaAlbacea", page);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearAlbacea(Usuario usuario)
        {
            Albacea albacea = new Albacea();
            albacea.FechaCreacion = DateTime.Today;
            albacea.EstadoId = Estado.obtenerEstadoInicial(_context);
            //Persona per = new Persona();
            //per.Genero = Genero.Inicial(_context);
            //per.TipoDocumento = TipoDocumento.Inicial(_context);
            //per.NroDocumento = 11222333;
            //per.Nombre = usuario.GetFirstName();
            //per.Apellido = usuario.GetLastName();
            //per.FechaNacimiento = DateTime.Today;
            //albacea.Persona = per;
            albacea.Usuario = ObtenerUsuario(_userService);
            _context.Add(albacea);
            _context.SaveChanges();
            return RedirectToAction("Index", "PersonaAviso", new { id = albacea.Id });

        }

        // GET: Albacea/Albacea/Create
        public IActionResult _Crear(int Id)
        {
            Albacea al = _context.Albacea.Where(d => d.Id == Id).First();
            ViewBag.AlId = Id;
            ViewBag.AlEstadoId = al.EstadoId;
            ViewBag.ALFecha = al.FechaCreacion;
            return PartialView("_Crear");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Crear(int id, Albacea albacea)
        {
            if (id != albacea.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(albacea);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = albacea.Id });
           
            }
            return View("_Crear", albacea);
        }
        public IActionResult _Editar(int Id)
        {
            var albacea = _context.Albacea.Where(d => d.Id == Id).First();
            ViewBag.AlId = Id;
            ViewBag.AlEstadoId = albacea.EstadoId;
            ViewBag.ALFecha = albacea.FechaCreacion;
            ViewBag.Editar ="si";
            if (albacea == null)
            {
                return NotFound();
            }
            return PartialView("_Crear", albacea);
        }




    }
}
