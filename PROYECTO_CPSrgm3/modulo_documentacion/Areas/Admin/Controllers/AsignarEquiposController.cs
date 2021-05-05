using Commons.Controllers;
using Commons.Models;
using CommonsCps.Apis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using System;
using System.Web;
using System.Collections.Generic;
using static modulo_documentacion.Areas.Identity.Pages.RegisterModel;
using System.Linq;
//using System.Web.Mvc;
using System.Threading.Tasks;
using Rotativa.AspNetCore;

namespace modulo_documentacion.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AsignarEquiposController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        //private ApiRecursosComunes _api;
        public AsignarEquiposController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult _ListadoDeAsignacionEquipos(Page<Equipo> page)
        {
            var contador = _context.Equipo.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Equipos/_ListadoDeAsignacionEquipos",
               _context.Equipo.Include(u => u.Empresa).Include(u => u.Marca)
               .Include(m => m.Modelo).Include(u => u.EstadoEquipo)
               .Include(x => x.Linea).Include(x => x.Planes));
        
            return PartialView("_ListadoDeAsignacionEquipos", page);
        }


        //Modal de buscar por Dni y enviando Id del equipo
        [HttpGet]
        public IActionResult _CreateSeleccion(int? Id)
        {
            //Enciando el Id de los equipos
            if (Id != null)
            {
                //Estoy enviando el Id del equipo que seleccione;
                ViewBag.EquipoId = Id;
                return PartialView();
            }

            ViewBag.EquipoId = 0;
            return PartialView();
        }

        public IActionResult IndexEquiposAsignados()
        {
            return View();
        }

        //Mostrar equipos asignados;
        public IActionResult _MostrarEquiposAsignados(Page<PersonaEquipos> page)
        {
            var contador = _context.PersonaEquipos.Count();
            if (contador < 1)
            {
                contador = 1;
            }

            page.SelectPage("/Admin/Equipos/_MostrarEquiposAsignados",
                _context.PersonaEquipos.Include(u => u.Equipo)
                .Include(u => u.Equipo.Marca).Include(m => m.Equipo.Modelo).Include(e => e.Equipo.Empresa)
                .Include(u => u.Equipo.EstadoEquipo).Include(x => x.Equipo.Linea)
                .Include(x => x.Equipo.Planes));

            return PartialView("_MostrarEquiposAsignados", page);
        }

        //Buscar a la persona
        public IActionResult _BuscarPersonaMilitar(int dniPersonaMilitar)    
        {
           
            var _api = new ApiRecursosComunes(CommonsCps.Services.CpsSession.Uat);
            CommonsCps.Entities.Persona persona = _api.GetPersona(dniPersonaMilitar);
            if (persona != null)
            {
                string UserName = _api.GetNombreUsuario(Convert.ToInt32(dniPersonaMilitar));
                var UsuarioLocal = _context.Users.Where(x => x.UserName == UserName).FirstOrDefault();
                if (UsuarioLocal == null)
                {
                    CommonsCps.Entities.Grado personaGrado = _api.GetGradoById(persona.GradoId);
                    CommonsCps.Entities.Unidad personaUnidad = _api.GetUnidadById(persona.UnidadId);
                    var pers = new
                    {
                        Id = persona.Id,
                        UserName = UserName,
                        Dni = persona.Dni,
                        Grado = personaGrado.CodigoGrado,
                        Apellido = persona.Apellido,
                        Nombre = persona.Nombre,
                        Unidad = personaUnidad.Descripcion,
                        Valido = true                      
                    };
                    return Json(pers);
                }
                else
                {
                    var pers = new
                    {
                        Valido = false,
                        texto = "El Usuario ya existe"
                    };
                    return Json(pers);
                }
            }
            else
            {
                var pers = new
                {
                    Valido = false,
                    texto = "El Dni Ingresado no corresponde a un Usuario"
                };
                return Json(pers);
            }

            return View();
        }

        //Guardar datos de la persona;
        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> _CreateUsuarioEnEquipo(InputModel user, int recibirIdEquipo)
        {

            ModelState.Remove("Password");
            ModelState.Remove("ConfirmPassword");

            if (ModelState.IsValid)
            {
                Usuario Usuario = new Usuario();
                PersonaEquipos personaEquipos = new PersonaEquipos();
                Equipo equipo = new Equipo();
                var IntranetAPI = new ApiEA();

                Usuario = new Usuario
                {
                    UserName = user.Email,
                    Email = user.Email,
                    NormalizedEmail = user.Email.ToUpper(),
                    NormalizedUserName = user.Email.ToUpper(),

                };

                personaEquipos = new PersonaEquipos
                {
                    Dni = Convert.ToInt32(user.Dni),
                    Apellido = user.Apellido,
                    Nombre = user.Nombre,
                    Grado = user.Grado,
                    Unidad = user.Unidad,
                    Editable = true,
                    EquipoId = recibirIdEquipo
                };

                //Buscar equipo y agregarle un "true" de asignado;
                equipo = _context.Equipo.FirstOrDefault(e => e.Id == recibirIdEquipo);
                equipo.Editable = true;


                _context.PersonaEquipos.Add(personaEquipos);
                await _context.SaveChangesAsync();

                //var result = await _userManager.CreateAsync(Usuario, user.Password);
                //await _claimsService.AddClaimAsync(Usuario, new Claim("User Username", Usuario.UserName));
                AddPageAlerts(PageAlertType.Success, "El usuario se asigno correctamente al equipo.");
                return RedirectToAction(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Hubo un error al asignar el equipo al Usuario.");
            return RedirectToAction(nameof(Index));

        }

        public IActionResult DetalleCompletoDelEquipo(int? Id)
        {
            if (Id != null)
            {
                var personaEquipos = _context.PersonaEquipos.Include(u => u.Equipo)
                .Include(u => u.Equipo.Marca).Include(m => m.Equipo.Modelo).Include(e => e.Equipo.Empresa)
                .Include(u => u.Equipo.EstadoEquipo).Include(x => x.Equipo.Linea)
                .Include(x => x.Equipo.Planes).FirstOrDefault(i => i.Id == Id);

                AddPageAlerts(PageAlertType.Success, "El equipo se encontro correctamente, aqui esta el detalle completo.");
                return View(personaEquipos);
            }


            AddPageAlerts(PageAlertType.Error, "Hubo un error, no se a podido mostrar el detalle completo del equipo asignado.");
            return RedirectToAction(nameof(_MostrarEquiposAsignados));
        }

        public IActionResult _Desasignar_Equipos(int? id)
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _Desasignar_Equipos_Borrar(int? Id)
        {
            Equipo equipos = new Equipo();
            PersonaEquipos personaEquipos = new PersonaEquipos();
            if (Id != null || Id == 0)
            {
                //Busco al equipo y a la PersonaCon el equipo por Id
                equipos = _context.Equipo.Where(e => e.Id == Id).FirstOrDefault();
                personaEquipos = _context.PersonaEquipos.Where(p => p.EquipoId == Id).FirstOrDefault();

                //Al equipo le asigno un false y elimino en el mostrar equipo el usuario asignado
                equipos.Editable = false;
                _context.PersonaEquipos.Remove(personaEquipos);
                await _context.SaveChangesAsync();

                AddPageAlerts(PageAlertType.Success, "El equipo se a desasignado correctamente .");
                return View(nameof(Index));
            }

            AddPageAlerts(PageAlertType.Error, "Se ha producido un error al desasignar el equipo, intentelo nuevamente .");
            return View(nameof(Index));
        }

        public IActionResult Reportes()
        {

            return new ViewAsPdf("Reportes")
            { 

            };
        }


    }
}
