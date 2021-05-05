using Commons.Identity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using modulo_documentacion.Models;
using modulo_documentacion.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace modulo_documentacion.Controllers
{
    public class ExternalLoginController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<Usuario> _user;
        private readonly SignInManager<Usuario> _signIn;

        public ExternalLoginController(ModuloDocumentacionContext context, IHostingEnvironment env, UserManager<Usuario> user, SignInManager<Usuario> signInManager):base(context)
        {
            _context = context;
            _env = env;
            _user = user;
            _signIn = signInManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //await _signIn.SignOutAsync();

            // Login fuera de la red para Development.
            if (_env.IsDevelopment() || _context.Users.Count() < 2)
            {
                return Redirect("/Identity/Account/Login");
                //await LoginAsDeveloper();
                //return RedirectToAction("Index", "Home");
            }

            var dni = ReadCookieDni();

            if (dni == null) return Redirect("https://intranet.ejercito.mil.ar/inicio/intranet");

            var usuario = _context.Users.FirstOrDefault(x => x.Persona.NroDocumento == (int)dni);

            if (usuario == null) return Redirect("https://intranet.ejercito.mil.ar/inicio/intranet");


            //ClaimsService claims = new ClaimsService(Context, _user);
            //await claims.LoadClaims(usuario);

            //await _signIn.SignInAsync(usuario, false);

            //string Foto64 = "../../dist/img/user4-128x128.jpg";

            //if (usuario.Foto != null)
            //{

            //    string Foto = Convert.ToBase64String(usuario.Foto);
            //    Foto64 = $"data:image/gif;base64,{Foto}";

            //}

            //string webRootPath = _env.WebRootPath;
            //string contentRootPath = _env.ContentRootPath;

            return RedirectToAction("Index", "Home");
        }


        private async Task LoginAsDeveloper()
        {
            var developer = await _user.FindByNameAsync("admin@admin.com");

            //if (developer == null)
            //{
            //    await _user.CreateAsync(new Usuarios()
            //    {
            //        UserName = "Admin",
            //        Email = "a@a.a",
            //        DNI = 0,
            //        PerfilSistema = Perfil.Sistemas
            //    });

            //    developer = await _user.FindByNameAsync("Admin");

            //    //await _user.AddToRoleAsync(developer, "Administrador");

            //}

            //ClaimsService<Usuario> claims = new ClaimsService<Usuario>(_user,_context);
            //await claims.LoadClaims(developer);

            await _signIn.SignInAsync(developer, false);
        }

        /// <summary>
        /// Read the coockie left by siem system.
        /// </summary>
        /// <returns></returns>
        private int? ReadCookieDni()
        {
            string sesion = Request.Cookies["session"];

            if (sesion == null) return null;

            //string sesion = "28fn5u8inq4d3gbef7gdm94lttasc4aj";

            SqlConnection cnn = new SqlConnection("data source=10.120.16.123;initial catalog=mvc_emge_co_prod2;user id=sa;password=Cps@2019");
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from openquery(mysql, 'select * from sessions where id=''" + sesion + "''')", cnn);
            DataSet ds_ses = new DataSet();
            da.Fill(ds_ses);
            DataTable dt_ses = ds_ses.Tables[0];
            if (dt_ses.Rows.Count > 0)
            {
                string cadena = dt_ses.Rows[0]["data"].ToString();
                string dniParseado = cadena.Substring(cadena.IndexOf("dni", StringComparison.Ordinal) + 9, 8).Replace("\"", String.Empty);
                return (int?)Convert.ToInt64(dniParseado);
            }
            else
            {
                return null;
            }
        }

    }
}