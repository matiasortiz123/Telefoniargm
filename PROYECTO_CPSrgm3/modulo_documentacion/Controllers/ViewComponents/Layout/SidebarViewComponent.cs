using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Commons.Helpers;
using Commons.Identity.Services;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using Commons.Extensions;
using Commons.Identity.Extensions;
using System.Linq;
////using Commons.Identity.Services;

namespace Commons.Controllers.ViewComponents.Layout
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly ModuloDocumentacionContext _context;
        private UserService<Usuario> _userService;

        public SidebarViewComponent(ModuloDocumentacionContext context, UserService<Usuario> userService)
        {
            _context = context;
            _userService = userService;

        }

        public IViewComponentResult Invoke(string filter)
        {
            //Usuario user = await _userService.FindByNameAsync(User.Identity.Name);
            bool userIsAdmin = ((ClaimsPrincipal)User).IsAdmin();
            
            var sidebars = new List<SidebarMenu>();

            sidebars.Add(MenuHelpers.AddHeader("MENU PRINCIPAL"));
            sidebars.Add(MenuHelpers.AddModule("Inicio", "/Home", "fa  fa-home"));
            var admin = MenuHelpers.AddTree("Datos", "fa fa-database");
            var gestion = MenuHelpers.AddTree("Gestión", "fa fa-sitemap ");
            var personal = MenuHelpers.AddTree("Reportes", "fa fa-file-pdf-o");
            var seguridad = MenuHelpers.AddTree("Sistema", "fa fa-gear");

            // TABLAS BASICAS
            admin.TreeChild = new List<SidebarMenu>();
            if (HttpContext.UserHasRoute("/Admin/Equipos/Index"))
                admin.TreeChild.Add(MenuHelpers.AddModule("Equipos", "/Admin/Equipos", "fa fa-circle-o text-yellow"));
            if (HttpContext.UserHasRoute("/Admin/Marca/Index"))
                admin.TreeChild.Add(MenuHelpers.AddModule("Marca", "/Admin/Marca", "fa fa-circle-o text-yellow"));
            if (HttpContext.UserHasRoute("/Admin/Modelo/Index"))
                admin.TreeChild.Add(MenuHelpers.AddModule("Modelos", "/Admin/Modelo", "fa fa-circle-o text-yellow"));
            if (HttpContext.UserHasRoute("/Admin/Empresa/Index"))
                admin.TreeChild.Add(MenuHelpers.AddModule("Empresa", "/Admin/Empresa", "fa fa-circle-o text-yellow"));
            if (HttpContext.UserHasRoute("/Admin/Linea/Index"))
                admin.TreeChild.Add(MenuHelpers.AddModule("Linea", "/Admin/Linea", "fa fa-circle-o text-yellow"));
            if (HttpContext.UserHasRoute("/Admin/Planes/Index"))
                admin.TreeChild.Add(MenuHelpers.AddModule("Planes", "/Admin/Planes", "fa fa-circle-o text-yellow"));

            // GESTION
            gestion.TreeChild = new List<SidebarMenu>();
            if (HttpContext.UserHasRoute("/Admin/AsignarEquipos/Index"))
                gestion.TreeChild.Add(MenuHelpers.AddModule("Asignar equipos", "/Admin/AsignarEquipos/Index", "fa fa-circle-o text-aqua"));
            if (HttpContext.UserHasRoute("/Admin/AsignarEquipos/IndexEquiposAsignados"))
                gestion.TreeChild.Add(MenuHelpers.AddModule("Mostrar equipos asignados", "/Admin/AsignarEquipos/IndexEquiposAsignados", "fa fa-circle-o text-aqua"));

            // REPORTE
            personal.TreeChild = new List<SidebarMenu>();
            if (HttpContext.UserHasRoute("/DDJJ/Elevacion/Index"))
                personal.TreeChild.Add(MenuHelpers.AddModule("DDJJ", "/Home/Privacy", "fa fa-circle-o text-green"));
            if (HttpContext.UserHasRoute("/DUFI/Elevacion/Index"))
                personal.TreeChild.Add(MenuHelpers.AddModule("DUFI", "/Home/Privacy", "fa fa-circle-o text-green"));
            if (HttpContext.UserHasRoute("/CFE/Elevacion/Index"))
                personal.TreeChild.Add(MenuHelpers.AddModule("CFE", "/Home/Privacy", "fa fa-circle-o text-green"));

            // SEGURIDAD
            seguridad.TreeChild = new List<SidebarMenu>();
            if (HttpContext.UserHasRoute("/Admin/Usuario/Index"))
                seguridad.TreeChild.Add(MenuHelpers.AddModule("Usuarios", "/Admin/Usuario", "fa fa-circle-o text-red"));
            if (HttpContext.UserHasRoute("/SecurityRoles/Index"))
                seguridad.TreeChild.Add(MenuHelpers.AddModule("Roles", "/SecurityRoles", "fa fa-circle-o text-red"));
            if (HttpContext.UserHasRoute("/SecurityFunctions/Index"))
                seguridad.TreeChild.Add(MenuHelpers.AddModule("Funciones", "/SecurityFunctions", "fa fa-circle-o text-red"));

            if (admin.TreeChild.Count > 0) sidebars.Add(admin);
            if (gestion.TreeChild.Count > 0) sidebars.Add(gestion);
            if (personal.TreeChild.Count > 0) sidebars.Add(personal);
            if (seguridad.TreeChild.Count > 0) sidebars.Add(seguridad);
    
                //// GESTION
                //gestion.TreeChild = new List<SidebarMenu>();
                //if (HttpContext.UserHasRoute("/Admin/AsignarEquipos/Index"))
                //    gestion.TreeChild.Add(MenuHelpers.AddModule("Asignar equipos", "/Admin/AsignarEquipos/Index", "fa fa-circle-o text-aqua"));
                //if (HttpContext.UserHasRoute("/Admin/AsignarEquipos/IndexEquiposAsignados"))
                //    gestion.TreeChild.Add(MenuHelpers.AddModule("Mostrar equipos asignados", "/Admin/AsignarEquipos/IndexEquiposAsignados", "fa fa-circle-o text-aqua"));

                ////Agrego al sidebar esos campos !!!
                //if (gestion.TreeChild.Count > 0) sidebars.Add(gestion);

            //sidebars.Add(MenuHelpers.AddModule("SALIR", "/Account/Logout", "fa fa-sign-out"));

            return View("LayoutSidebar", sidebars);
        }
    }
}
