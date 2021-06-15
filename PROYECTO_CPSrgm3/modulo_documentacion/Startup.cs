using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Commons.Extensions;
using CommonsCps.Extensions;
using modulo_documentacion.Models;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using Commons.Identity.DummyData;
using modulo_documentacion.Services;
using Commons.Identity.Services;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace modulo_documentacion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
           
            services.AddServicesCps<Usuario, ModuloDocumentacionContext, UserCreator>();

            services.AddTransient<PersonalService>();

            services.AddCommonsLibraryViews();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddAuthorization();

            services.AddDbContext<ModuloDocumentacionContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                //options.UseSqlServer(Configuration.GetConnectionString("produccion")));

            //services.AddDbContext<ModuloDocumentacionContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("sql_express")));

            //services.AddDbContext<ModuloDocumentacionContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("produccion")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UserService<Usuario> userService, ModuloDocumentacionContext context)
        {
            var adminUserResult = context.Users.FirstOrDefault(x => x.UserName == "matiasnortiz");

            if (adminUserResult != null)
            {
                if (userService.GetClaimsAsync(adminUserResult).Result.All(x => x.Type != "IsAdmin"))
                {
                    userService.AddClaimAsync(adminUserResult, new Claim("IsAdmin", ""));
                }
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                //Provisorio
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

                //app.UseExceptionHandler("/Home/Error");
                //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCommonsLibraryScripts();
            app.UseSession();
           

            app.UseAuthentication();
            //app.UseAuthorization();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
            app.UseCookiePolicy();
            DummyAdmin.Initialize(userService).Wait();
            //Configuracion para reportes en pdf
            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Areas/Admin/Reportes");
        }
    }
}
