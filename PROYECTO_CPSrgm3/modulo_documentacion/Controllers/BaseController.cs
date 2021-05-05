using Microsoft.AspNetCore.Mvc;
using Commons.Controllers;
using Microsoft.AspNetCore.Authorization;
using Commons.Identity.Attributes;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using System.Linq;
using Commons.Identity.Services;

namespace modulo_documentacion.Controllers
{
    [Secured]
    public class BaseController : CommonsController
    {
        private ModuloDocumentacionContext _context;

        public BaseController(ModuloDocumentacionContext context)
        {
            _context = context;
        }

        public Usuario ObtenerUsuario([FromServices] UserService<Usuario> userService)
        {
            string id = userService.GetUserId(User);
            return _context.Users.FindAsync(id).Result;
        }

    }
}