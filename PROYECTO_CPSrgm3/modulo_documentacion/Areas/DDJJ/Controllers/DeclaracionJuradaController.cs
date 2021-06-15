using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modulo_documentacion.Models;
using modulo_documentacion.Controllers;
using modulo_documentacion.Areas.DDJJ.Models;
using modulo_documentacion.Areas.DDJJ.ViewModels;
using modulo_documentacion.Areas.Admin.Models.Basicas;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
//using GeoCoordinatePortable;
using System.Collections.Generic;
using Commons.Models;
using Commons.Identity.Attributes;
using Commons.Identity.Services;
using System.IO;
using System.Drawing; //imagenes
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Http;
using HeyRed.Mime;

namespace modulo_documentacion.Areas.DDJJ.Controllers
{
    [Area("DDJJ")]
    public class DeclaracionJuradaController : BaseController
    {
        private readonly ModuloDocumentacionContext _context;
        private readonly UserService<Usuario> _userService;
        private readonly string[] permittedExtensions = { "jpeg", "pdf" };
        private string auxExt;

        public DeclaracionJuradaController(ModuloDocumentacionContext context, UserService<Usuario> userService) : base(context)
        {
            _context = context;
            _userService = userService;
        }

        public IActionResult Gestion()
        {
            return View();
        }

        public IActionResult GestionPersonal(Usuario usuario)
        {
            ViewBag.Usuario = usuario.GetFullName();
            return View();
        }

        public IActionResult _TablaDeclaracionJurada(Page<DeclaracionJurada> page)
        {
            Usuario usuario = ObtenerUsuario(_userService);
            page.SelectPage("/DDJJ/DeclaracionJurada/_TablaDeclaracionJurada",
                _context.DeclaracionJurada.Where(x => x.UsuarioId==usuario.Id).Include(d => d.Estado)
                );

            return PartialView("_TablaDeclaracionJurada", page);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearDDJJ(Usuario usuario)
        {
            DeclaracionJurada declaracionJurada = new DeclaracionJurada();
            declaracionJurada.FechaCreacion = DateTime.Today;
            declaracionJurada.Estado = EstadoDDJJ.EstadoInicialDDJJ(_context);
            declaracionJurada.Usuario = ObtenerUsuario(_userService);
            declaracionJurada.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJCreacion, "Declaracion Jurada creada", ObtenerUsuario(_userService)),""));
            _context.Add(declaracionJurada);
            _context.SaveChanges();
            
            return RedirectToAction("DomicilioVivienda", new { id = declaracionJurada.ID });
        }

        //public BitacoraDDJJ CrearBitacora(TipoBitacora tipo, string texto)
        //{
        //    BitacoraDDJJ bitacora = new BitacoraDDJJ();
        //    bitacora.TipoBitacora = tipo;
        //    bitacora.Descripcion = texto;
        //    bitacora.FechaHora = DateTime.Now;
        //    bitacora.Usuario = ObtenerUsuario(_userService);
        //    return bitacora;
        //}


        //DOMICILIO Y VIVIENDA
        public IActionResult DomicilioVivienda(int id)
        {
            ViewBag.MenuActivo = "DF";
           
            DomicilioViviendaViewModel df = new DomicilioViviendaViewModel();

            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Domicilio).ThenInclude(d => d.Provincia).Include(d => d.Vivienda).Include(d => d.Domicilio).ThenInclude(d => d.Localidad).FirstOrDefault();            
            // DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Domicilio).Include(d => d.Vivienda).FirstOrDefault();

            df.DeclaracionJuradaID = dj.ID;
            df.Domicilio = dj.Domicilio;
            df.Vivienda = dj.Vivienda;

    



            return View("DomicilioVivienda/Index", df);
        }
       [HttpPost]
        public IActionResult GetGuarniciones(string q)
        {
           var items = _context.Guarnicion.Where(x => x.Descripcion.Contains(q))
                .Select(x => new
                {
                    Text = $"{x.Descripcion}, {x.Codigo}",
                    Value = x.Id,
                    //Subtext = $"{x.Unidades} {x.Descripcion}",
                    Icon = "fa fa-plus",
                    Class = ""
                }).Take(50).ToArray();
            return Json(items);
        }
        [HttpGet]
        public JsonResult GetLocalidades(int Id)
        {
            List<Localidad> GetLocalidadesList = new List<Localidad>();
           // var loca=_context.Localidad.GroupBy(s => s.ProvinciaNombre);
            // ------- Getting Data from Database Using EntityFrameworkCore -------
            GetLocalidadesList = (from subcategory in _context.Localidad
                               where subcategory.IdDepartamento == Id
                                  select subcategory).ToList();
          //   double lat1=loca.All;

            //var students = ctx.Students.(StandardId);
            //var coord1 = new GeoCoordinate(lat1, long1);
            //var coord2 = new GeoCoordinate(lat2, long2);

          //  var distance = coord1.GetDistanceTo(coord2);

            // ------- Inserting Select Item in List -------
            // subCategorylist.Insert(0, new Localidad { Id = 0, Descripcion = "Select" });

            return Json(new SelectList(GetLocalidadesList, "Id", "Descripcion"));
            //  return Json(subCategorylist);
        }
        //public JsonResult GetDistancia(string lat, string lon)
        //{
        //   // List<Localidad> GetLocalidadesList = new List<Localidad>();
        //    var loca = _context.Localidad.ToList();
        //    // ------- Getting Data from Database Using EntityFrameworkCore -------
        //    //GetLocalidadesList = (from subcategory in _context.Localidad
        //    //                   where subcategory.IdDepartamento == Id
        //    //                      select subcategory).ToList();
        //    //   double lat1=loca.All;
        //    double menor = 999999999;
        //    Localidad cercana = new Localidad();
        //    foreach (Localidad geo in loca)
        //    {
        //        if (geo.Latitud != null || geo.Longitud != null)
        //        {
        //            var latitudconvert = (Convert.ToDouble(geo.Latitud.Replace(".", ",")));
        //            var coord1 = new GeoCoordinate(Convert.ToDouble(geo.Latitud.Replace(".", ",")), Convert.ToDouble(geo.Longitud.Replace(".", ",")));
        //            var coord2 = new GeoCoordinate(Convert.ToDouble(lat.Replace(".", ",")), Convert.ToDouble(lon.Replace(".", ",")));

        //            var distance = coord1.GetDistanceTo(coord2);
        //            if (menor > distance)
        //            {
        //                menor = distance;
        //                cercana = geo;
        //            }
        //        }
        //    }
        //    return Json(cercana);
        //    // ------- Inserting Select Item in List -------
        //    // subCategorylist.Insert(0, new Localidad { Id = 0, Descripcion = "Select" });

        //    //return Json(new SelectList(GetLocalidadesList, "Id", "Descripcion"));
        //    //  return Json(subCategorylist);
        //}


        /*  --------------------- CREAR DOMICILIO  --------------------*/
        public IActionResult _CrearDomicilio(int Id)
        {

            ViewBag.DJId = Id;
            ViewBag.Provincias = _context.Provincia.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            return PartialView("DomicilioVivienda/_CrearDomicilio");
        }
       
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearDomicilio(DomicilioViviendaViewModel domicilioVivienda)
        {
            if (domicilioVivienda.Domicilio.Pais == "Argentina")
            {
                domicilioVivienda.Domicilio.LocalidadExterior =null;
                domicilioVivienda.Domicilio.ProvinciaExterior = null;
            }
            else
            {
                domicilioVivienda.Domicilio.ViveExterior = true;
                domicilioVivienda.Domicilio.ProvinciaId = 14;
                domicilioVivienda.Domicilio.LocalidadId = 14;
            }
            //var provincia = _context.Provincia.Where(d => d.Descripcion == domicilioVivienda.Domicilio.ProvinciaStr);
            //var prueba = "https://apis.datos.gob.ar/georef/api/ubicacion?lat=" + domicilioVivienda.Domicilio.Latitud + "&lon=" + domicilioVivienda.Domicilio.Longitud;
            //var json = new WebClient().DownloadString(prueba);
            //dynamic m = JsonConvert.DeserializeObject(json);
      


            if (ModelState.IsValid)
            {
                DomicilioDDJJ domicilio = domicilioVivienda.Domicilio;
                var Provincia = await _context.Provincia.FindAsync(domicilio.ProvinciaId);
                var Localidad = await _context.Localidad.FindAsync(domicilio.LocalidadId);
                domicilio.LocalidadId = Localidad.Id;

      
                if (Provincia == null)
                    return NotFound();
                if (Localidad == null)
                    return NotFound();
      
                    domicilio.Provincia = Provincia;
                 domicilio.Localidad = Localidad;
                _context.Add(domicilio);
                await _context.SaveChangesAsync();
                return RedirectToAction("DomicilioVivienda", new { id = domicilio.DeclaracionJuradaID });
            }
            else
            {
                ViewBag.DJID = domicilioVivienda.DeclaracionJuradaID;
                ViewBag.Provincias = _context.Provincia.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
                DomicilioDDJJ domicilio = domicilioVivienda.Domicilio;
                return PartialView("DomicilioVivienda/_CrearDomicilio", domicilio);
            }
            
        }
      


        /*-----------------------EDITAR DOMICILIO-----------------------------*/
        [HttpGet]
        public async Task<IActionResult> _EditarDomicilio(int Id)
        {
           // ViewBag.Pais = _context.Pais.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
          
            var domicilio = await _context.DomicilioDDJJ.FindAsync(Id);
       
            ViewBag.DJId = domicilio.DeclaracionJuradaID;
            domicilio.Provincia= _context.Provincia.Find(domicilio.ProvinciaId);
            domicilio.Localidad=_context.Localidad.Find(domicilio.LocalidadId);
            ViewBag.Provincia = _context.Provincia.Find(domicilio.ProvinciaId);
            ViewBag.Provincias = _context.Provincia.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() }); 
            ViewBag.Localidad = _context.Localidad.Find(domicilio.LocalidadId);
            if (domicilio == null)
            {
                return NotFound();
            }
            return PartialView("DomicilioVivienda/_EditarDomicilio", domicilio);
        }

        //[HttpPost]
        //public async Task<IActionResult> _EditarDomicilio(int id, DomicilioDDJJ domicilio)
        //{
        //    if (id != domicilio.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(domicilio);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("DomicilioVivienda", new { id = domicilio.DeclaracionJuradaID });
        //    }
        //    return View("DomicilioVivienda/Index");
        //    //return RedirectToAction("Index");
        //}

        [HttpPost]
        public async Task<IActionResult> _EditarDomicilio(int id, DomicilioDDJJ DomicilioDDJJ)
        {
            //ModelState.Remove("Calle");
            if (DomicilioDDJJ.Pais == "Argentina")
            {
                var Provincia = await _context.Provincia.FindAsync(DomicilioDDJJ.ProvinciaId);
                var Localidad = await _context.Localidad.FindAsync(DomicilioDDJJ.LocalidadId);
                DomicilioDDJJ.LocalidadId = Localidad.Id;


                if (Provincia == null)
                    return NotFound();
                if (Localidad == null)
                    return NotFound();

                DomicilioDDJJ.Provincia = Provincia;
                DomicilioDDJJ.Localidad = Localidad;
            }
            else
            {
                //var ProvinciaExt = await _context.Provincia.FindAsync(DomicilioDDJJ.ProvinciaExterior);
                //var LocalidadExt = await _context.Localidad.FindAsync(DomicilioDDJJ.LocalidadExterior);
                DomicilioDDJJ.ViveExterior = true;
                DomicilioDDJJ.ProvinciaId = 14;
                DomicilioDDJJ.LocalidadId = 14;

                //if (ProvinciaExt == null)
                //    return NotFound();
                //if (LocalidadExt == null)
                //    return NotFound();

                //DomicilioDDJJ.ProvinciaExterior = ProvinciaExt.Descripcion;
                //DomicilioDDJJ.LocalidadExterior = LocalidadExt.Descripcion;
            }

            //if (id != DomicilioDDJJ.id)
            //{
            //    return NotFound();
            //}
            
            if (ModelState.IsValid)
            {
                
                _context.Update(DomicilioDDJJ);
                await _context.SaveChangesAsync();
                return RedirectToAction("DomicilioVivienda", new { id = DomicilioDDJJ.DeclaracionJuradaID });
            }
            return PartialView("DomicilioVivienda/_EditarDomicilio", DomicilioDDJJ);
            //return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult _EditarDomicilioFamiliar(int Id)
        //{
        //    // ViewBag.Pais = _context.Pais.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });

        //    //var domicilio = await _context.DomicilioDDJJ.FindAsync(Id);

        //    //ViewBag.DJId = domicilio.DeclaracionJuradaID;
        //    //domicilio.Provincia = _context.Provincia.Find(domicilio.ProvinciaId);
        //    //domicilio.Localidad = _context.Localidad.Find(domicilio.LocalidadId);
        //    //ViewBag.Provincia = _context.Provincia.Find(domicilio.ProvinciaId);
        //    //ViewBag.Localidad = _context.Localidad.Find(domicilio.LocalidadId);
        //    //if (domicilio == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    Familiar familiar = _context.Familiar.Where(f => f.Id == Id).Include(f => f.Parentesco).Include(f => f.Domicilio).Include(d => d.LocalidadEmpleador).Include(u => u.Domicilio.Localidad).Include(d => d.LocalidadDefuncion).FirstOrDefault();
        //    if (familiar is null)
        //    {
        //        return NotFound();
        //    }
        //    //armaListasFamiliar();
        //    ViewBag.DJId = familiar.DeclaracionJuradaID;
        //    ViewBag.Provincia = _context.Provincia.Find(familiar.Domicilio.ProvinciaId);
        //    ViewBag.Localidad = _context.Localidad.Find(familiar.Domicilio.LocalidadId);
        //    return PartialView("FamiliaContacto/_EditarDomicilioFamiliar", familiar);
        //}

        //[HttpPost]
        //public async Task<IActionResult> _EditarDomicilioFamiliar(int id, Familiar familiar)
        //{

        //    if (familiar.Pais == "Argentina")
        //    {
        //        var Provincia = await _context.Provincia.FindAsync(familiar.Domicilio.ProvinciaId);
        //        var Localidad = await _context.Localidad.FindAsync(familiar.Domicilio.LocalidadId);
        //        familiar.Domicilio.LocalidadId = Localidad.Id;


        //        if (Provincia == null)
        //            return NotFound();
        //        if (Localidad == null)
        //            return NotFound();

        //        familiar.Domicilio.Provincia = Provincia;
        //        familiar.Domicilio.Localidad = Localidad;
        //    }
        //    else
        //    {
        //        //var ProvinciaExt = await _context.Provincia.FindAsync(DomicilioDDJJ.ProvinciaExterior);
        //        //var LocalidadExt = await _context.Localidad.FindAsync(DomicilioDDJJ.LocalidadExterior);
        //        familiar.ViveExtranjero = true;
        //        familiar.Domicilio.ProvinciaId = 14;
        //        familiar.Domicilio.LocalidadId = 14;

        //        //if (ProvinciaExt == null)
        //        //    return NotFound();
        //        //if (LocalidadExt == null)
        //        //    return NotFound();

        //        //DomicilioDDJJ.ProvinciaExterior = ProvinciaExt.Descripcion;
        //        //DomicilioDDJJ.LocalidadExterior = LocalidadExt.Descripcion;
        //    }

        //    //if (id != DomicilioDDJJ.id)
        //    //{
        //    //    return NotFound();
        //    //}

        //    if (ModelState.IsValid)
        //    {

        //        _context.Update(familiar);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("FamiliaContacto/EditarFamiliar", new { id = familiar.Id });
        //    }
        //    return View("FamiliaContacto/EditarFamiliar");
        //    //return RedirectToAction("Index");
        //}
        /*  --------------------- CREAR VIVIENDA  --------------------*/
        public IActionResult _CrearVivienda(int Id)
        {
            ViewBag.Unidad = _context.Unidad.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.DJId = Id;
            return PartialView("DomicilioVivienda/_CrearVivienda");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearVivienda(Vivienda vivienda, int id)
         {
            // viviendaViewModel.Domicilio = _context.DomicilioDDJJ.Where(d => d.DeclaracionJuradaID == id).FirstOrDefault();
            // if (ModelState.IsValid)
            //{
            var GuarnicionConstruye = await _context.Guarnicion.FindAsync(vivienda.GuarnicionConstruyeID);
            var GuarnicionSoluciona = await _context.Guarnicion.FindAsync(vivienda.GuarnicionSolucionaID);
            var GuarnicionViviendaProxima1 = await _context.Guarnicion.FindAsync(vivienda.GuarnicionViviendaProxima1ID);
         
            vivienda.DeclaracionJuradaID = id;
            vivienda.GuarnicionConstruye = GuarnicionConstruye;
            vivienda.GuarnicionSoluciona = GuarnicionSoluciona;
            vivienda.GuarnicionViviendaProxima1 = GuarnicionViviendaProxima1;
            _context.Add(vivienda);
                await _context.SaveChangesAsync();
                return RedirectToAction("DomicilioVivienda", new { id = id });
             //}   
              
            }
        [HttpGet]
        public async Task<IActionResult> _EditarVivienda(int Id)
        {

            var vivienda = await _context.Vivienda.FindAsync(Id);
            ViewBag.Pais = _context.Pais.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            ViewBag.Provincia = _context.Provincia.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            ViewBag.Localidad = _context.Localidad.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            ViewBag.Unidad = _context.Unidad.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() }).Where(d => d.Value != "93" && d.Value != "95" && d.Value != "96");
            ViewBag.DJId = vivienda.DeclaracionJuradaID;
            if (vivienda == null)
            {
                return NotFound();
            }
            return PartialView("DomicilioVivienda/_EditarVivienda", vivienda);
        }


        [HttpPost]
        public async Task<IActionResult> _EditarVivienda(Vivienda Vivienda, int id)
        {
            /*if (id != Vivienda.ID)
            {
                return NotFound();
            }*/
            if (ModelState.IsValid)
            {
                _context.Update(Vivienda);
                await _context.SaveChangesAsync();
                return RedirectToAction("DomicilioVivienda", new { id = Vivienda.DeclaracionJuradaID });

            }
            return View("DomicilioVivienda/Index");
            //return RedirectToAction("Index");
        }





        //FAMILIA Y CONTACTO

        public IActionResult FamiliaContacto(int id)
        {
            ViewBag.MenuActivo = "FC";
            ViewBag.EstadoCivil = _context.EstadoCivil.Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.SituacionFamiliar = _context.SituacionFamiliar.Select(s => new SelectListItem() { Text = s.Descripcion, Value = s.Id.ToString() });

            FamiliaContactoViewModel fc = new FamiliaContactoViewModel();
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Contactos).ThenInclude(t => t.TipoContacto).Include(d => d.Familiares).ThenInclude(f => f.Parentesco).Include(d => d.EstadoCivil).Include(d =>d.SituacionFamiliar).FirstOrDefault();
            fc.DeclaracionJuradaID = dj.ID;
            fc.DeclaracionJurada = dj;
           if (dj.Contactos != null)
                fc.Contactos = dj.Contactos;
           if (dj.EstadoCivil != null)
                fc.EstadoCivil = dj.EstadoCivil;
           if (dj.SituacionFamiliarID != null)
                fc.SituacionFamiliar = dj.SituacionFamiliar;
                fc.OtraSituacion = dj.OtraSituacionFamiliar;
                fc.Familiares = dj.Familiares;
           if (dj.EstadoCivil == null)
                fc.EstadoCivilID = -1;

            return View("FamiliaContacto/Index", fc);
        }


        public IActionResult _CrearContacto(int Id)
        {
            ViewBag.TipoContacto = _context.TipoContacto.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            ViewBag.DJId = Id;
            return PartialView("FamiliaContacto/_CrearContacto");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearContacto([Bind("TipoContactoID,PrefijoTel,NumeroTel,Email, DeclaracionJuradaID")] ContactoDDJJ contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction("FamiliaContacto", new { id = contacto.DeclaracionJuradaID });
            }
            return View("FamiliaContacto/_CrearContacto", contacto);
        }

        [HttpGet]
        public async Task<IActionResult> _EditarContacto(int id)
        {

            var contacto = await _context.ContactoDDJJ.FindAsync(id);
            ViewBag.TipoContacto = _context.TipoContacto.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            ViewBag.DJId = contacto.DeclaracionJuradaID;
            if (contacto == null)
            {
                return NotFound();
            }
            return PartialView("FamiliaContacto/_EditarContacto", contacto);
        }

        [HttpPost]
        public async Task<IActionResult> _EditarContacto(int id, ContactoDDJJ contacto)
        {
            if (id != contacto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction("familiacontacto", new { id = contacto.DeclaracionJuradaID });
            }
            return View("DeclaracionJurada/FamiliaContacto/Index");
            //return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteContacto(int id)
        {
            var contacto = await _context.ContactoDDJJ.FindAsync(id);
            _context.Contacto.Remove(contacto);
            await _context.SaveChangesAsync();
            return RedirectToAction("familiacontacto", new { id = contacto.DeclaracionJuradaID });
        }

        public IActionResult _CrearEstadoCivil(int Id)
        {
            ViewBag.EstadoCivil = _context.EstadoCivil.Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.SituacionFamiliar = _context.SituacionFamiliar.Select(s => new SelectListItem() { Text = s.Descripcion, Value = s.Id.ToString() });
            ViewBag.DJId = Id;
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == Id).FirstOrDefault();
            @ViewBag.OtraSituacion = dj.OtraSituacionFamiliar;



            //  DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == Id).Include(d => d.Contactos).ThenInclude(t => t.TipoContacto).Include(d => d.Familiares).ThenInclude(f => f.Parentesco).Include(d => d.EstadoCivil).FirstOrDefault();



            return PartialView("FamiliaContacto/_CrearEstadoCivil");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearEstadoCivil(int DeclaracionJuradaID, int EstadoCivilID, int SituacionFamiliarID, string OtraSituacion, DateTime FechaCasamiento)
        {
            //if (ModelState.IsValid)
            //{
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == DeclaracionJuradaID).FirstOrDefault();
            if (dj == null) { return NotFound(); }
            dj.EstadoCivilID = EstadoCivilID;
            dj.SituacionFamiliarID = SituacionFamiliarID;
            dj.OtraSituacionFamiliar = OtraSituacion;
            dj.FechaCasamiento = FechaCasamiento;

            _context.Update(dj);
            await _context.SaveChangesAsync();
            return RedirectToAction("FamiliaContacto", new { id = dj.ID });
            //}
            //return View("GestionPersonal");
        }
        public async Task<IActionResult> _EditarEstadoCivil(int Id)
        {
            ViewBag.EstadoCivil = _context.EstadoCivil.Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.SituacionFamiliar = _context.SituacionFamiliar.Select(s => new SelectListItem() { Text = s.Descripcion, Value = s.Id.ToString() });
            ViewBag.DJId = Id;

            var dj = await _context.DeclaracionJurada.FindAsync(Id);
            //DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == Id).FirstOrDefault();
            @ViewBag.OtraSituacion = dj.OtraSituacionFamiliar;
            @ViewBag.FechaCasamiento = dj.FechaCasamiento;

            if (dj is null)
            {
                return NotFound();
            }



            return PartialView("FamiliaContacto/_EditarEstadoCivil", dj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _EditarEstadoCivil(int DeclaracionJuradaID, int EstadoCivilID, int SituacionFamiliarID, string OtraSituacion, DateTime FechaCasamiento)
        {
            //if (ModelState.IsValid)
            //{
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == DeclaracionJuradaID).FirstOrDefault();
            if (dj == null) { return NotFound(); }
            dj.EstadoCivilID = EstadoCivilID;
            dj.SituacionFamiliarID = SituacionFamiliarID;
            dj.OtraSituacionFamiliar = OtraSituacion;
            if (FechaCasamiento.Year == 1)
            {
               dj.FechaCasamiento = null;
            }
            else
            {
               dj.FechaCasamiento = FechaCasamiento;
            }
            

            _context.Update(dj);
            await _context.SaveChangesAsync();
            return RedirectToAction("FamiliaContacto", new { id = dj.ID });
            //}
            //return View("GestionPersonal");
        }
        public IActionResult CrearFamiliar(int djId)
        {
            armaListasFamiliar();
            ViewBag.DJID = djId;
            return View("FamiliaContacto/CrearFamiliar");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearFamiliar(Familiar familiar)
        {
            /*var persona = _context.Persona.Find(familiar.DeclaracionJuradaID);

            if (familiar.Convive)
            {
                familiar.Domicilio = persona.Domicilio;
            }
            */
            if (ModelState.IsValid)
            {
                _context.Add(familiar);
                await _context.SaveChangesAsync();
                return RedirectToAction("FamiliaContacto", new { id = familiar.DeclaracionJuradaID });
            }
            armaListasFamiliar();
            ViewBag.DJID = familiar.DeclaracionJuradaID;
            return View("FamiliaContacto/CrearFamiliar");
        }

        public IActionResult EditarFamiliar(int Id)
        {
            Familiar familiar = _context.Familiar.Where(f => f.Id == Id).Include(f => f.Parentesco).Include(f => f.Domicilio).Include(d => d.LocalidadEmpleador).Include(u => u.Domicilio.Localidad).Include(d => d.LocalidadDefuncion).FirstOrDefault();
            if (familiar is null)
            {
                return NotFound();
            }
            armaListasFamiliar();
            ViewBag.DJID = familiar.DeclaracionJuradaID;
            return View("FamiliaContacto/EditarFamiliar", familiar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarFamiliar(Familiar familiar)
        {
            if (!familiar.Vive)
            {
                familiar.FechaNacimiento = null;
                familiar.NroDocumento = 0;
            }


            if (ModelState.IsValid)
            {
                //Domicilio dom = familiar.Domicilio;
                //_context.Add(dom);
                //familiar.DomicilioID = dom.ID;
                _context.Update(familiar);
                await _context.SaveChangesAsync();
                return RedirectToAction("FamiliaContacto", new { id = familiar.DeclaracionJuradaID });
            }
            armaListasFamiliar();
            ViewBag.DJID = familiar.DeclaracionJuradaID;
            return View("FamiliaContacto/EditarFamiliar");
        }
        public async Task<IActionResult> DeleteFamiliar(int id)
        {
            var familiar = await _context.Familiar.FindAsync(id);
            _context.Familiar.Remove(familiar);
            await _context.SaveChangesAsync();
            return RedirectToAction("familiacontacto", new { id = familiar.DeclaracionJuradaID });
        }

        public void armaListasFamiliar()
        {
            ViewBag.TipoDocumento = _context.TipoDocumento.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            ViewBag.Genero = _context.Genero.Select(g => new SelectListItem() { Text = g.Descripcion, Value = g.Id.ToString() });
            ViewBag.Escolaridad = _context.Escolaridad.Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.Parentesco = _context.Parentesco.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            ViewBag.EstadoCivil = _context.EstadoCivil.Select(c => new SelectListItem() { Text = c.Descripcion, Value = c.Id.ToString() });
            ViewBag.SituacionLaboral = _context.SituacionLaboral.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.Provincias = _context.Provincia.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            // Se hace via AJAX
            //ViewBag.Localidades = _context.Localidad.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            ViewBag.Fuerza = _context.Fuerza.Select(f => new SelectListItem() { Text = f.Nombre, Value = f.Id.ToString() });
            ViewBag.Grado = _context.Grado.Select(g => new SelectListItem() { Text = g.Nombre, Value = g.Id.ToString() });
        }

        [Unsecured]
        public IActionResult SelectListJsonLocalidades(string q)
        {
            var items = _context.Localidad.Where(x => x.Descripcion.Contains(q))
                .Select(x => new
                {
                    Text = $"{x.Descripcion}",
                    Value = x.Id,
                    Subtext = $"{x.ProvinciaNombre}",
                    Icon = "fa fa-plus",
                    Class = ""
                }).Take(50).ToArray();

            return Json(items);
        }

        public IActionResult SelectListJsonLocalidadesDependiente(int provinciaId)
        {
            var items = _context.Localidad
                .Select(x => new
                {
                    Text = $"{x.Descripcion}",
                    Value = x.Id,
                    Provincia = x.IdProvincia
                }).Where(x => x.Provincia == provinciaId).Take(900).ToArray();

            return Json(items);
        }

        //ESTUDIOS Y CAUSAS

        public IActionResult EstudioCausa(int id)
        {
            ViewBag.MenuActivo = "EC";
            EstudioCausaViewModel ec = new EstudioCausaViewModel();
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Estudios).ThenInclude(t => t.Escolaridad).Include(d => d.CausasJudiciales).ThenInclude(d => d.TipoExpediente).Include(d => d.Documentos).ThenInclude(d => d.TipoDocumentoAdjunto).FirstOrDefault();
            ec.DeclaracionJuradaID = dj.ID;
            ec.Estudios = dj.Estudios;
            ec.Causas = dj.CausasJudiciales;
            ec.Documentos = dj.Documentos;

            return View("EstudioCausa/Index", ec);
        }

        public IActionResult _CrearEstudio(int Id)
        {
            ViewBag.Escolaridad = _context.Escolaridad.Where(x => x.Id > 2).Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.DJId = Id;
            return PartialView("EstudioCausa/_CrearEstudio");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearEstudio([Bind("EscolaridadID,Descripcion,Finalizado,DeclaracionJuradaID")] EstudioDDJJ estudio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudio);
                await _context.SaveChangesAsync();
                return RedirectToAction("EstudioCausa", new { id = estudio.DeclaracionJuradaID });
            }
            return View("FamiliaContacto/_CrearContacto", estudio);
        }

        public IActionResult _CrearCausa(int Id)
        {
            ViewBag.TipoExpediente = _context.TipoExpediente.Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.DJId = Id;
            return PartialView("EstudioCausa/_CrearCausa");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _CrearCausa([Bind("Caratula, Expediente, TipoExpedienteID, SituacionJudicial, Juzgado, DeclaracionJuradaID")] CausaJudicialDDJJ causa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(causa);
                await _context.SaveChangesAsync();
                return RedirectToAction("EstudioCausa", new { id = causa.DeclaracionJuradaID });
            }
            return View("FamiliaContacto/_CrearCausa", causa);
        }

        public IActionResult _CrearDocumento(int Id)
        {
            ViewBag.TipoDocumentoAdjunto = _context.TipoDocumentoAdjunto.Select(d => new SelectListItem() { Text = d.Descripcion, Value = d.Id.ToString() });
            ViewBag.DJId = Id;
            return PartialView("EstudioCausa/_CrearDocumento");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> _CrearDocumento([Bind("TipoDocumentoAdjuntoID, Fojas, Observaciones, DeclaracionJuradaID")] Documentacion documento)
        {

            if (ModelState.IsValid)
            {
                _context.Add(documento);
                await _context.SaveChangesAsync();
                return RedirectToAction("EstudioCausa", new { id = documento.DeclaracionJuradaID });
            }
            return View("EstudioCausa/_CrearDocumento", documento);
        }

        [HttpGet]
        public async Task<IActionResult> _CargaAdjunto(int id)
        {
            var documentacion = await _context.Documentacion.FindAsync(id);

            if (documentacion == null) return NotFound();

            return PartialView("EstudioCausa/_CargaAdjunto", documentacion);
        }
        [HttpPost]
        public async Task<IActionResult> _CargaAdjunto(IFormFile img, int id)
        {
            var documentacion = await _context.Documentacion.FindAsync(id);
            
            if (documentacion == null) return NotFound();

            if (img == null)
            {
                AddPageAlerts(PageAlertType.Error, "No se cargo ningún archivo");
            }
            else
            {
                
                // Archivos que están siendo subidos al servidor 
                //var mime = MimeGuesser.GuessMimeType(img.OpenReadStream());
                var ext = MimeGuesser.GuessExtension(img.OpenReadStream());
                long size = img.Length;
                //var ext = Path.GetExtension(img.FileName).ToLowerInvariant();

                if (!permittedExtensions.Contains(ext))
                {
                    // Gestiona los errores de tipo
                     AddPageAlerts(PageAlertType.Error, $"{img.FileName} no Permitido");
                }
                else
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        if (size < 2097152)
                        {
                            await img.CopyToAsync(memoryStream);

                        // Upload the file if less than 2 MB
                        //if (memoryStream.Length < 2097152)
                        //{
                            documentacion.Adjunto = memoryStream.ToArray();
                            documentacion.Tipo = ext;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            // Gestiona los errores de tamaño
                            AddPageAlerts(PageAlertType.Error, $"{img.FileName} supera el limite establecido (2MB).");
                        }
                    }
                }
            }
            return RedirectToAction("EstudioCausa", new { id = documentacion.DeclaracionJuradaID });
        }
        public ActionResult getAdjunto(int id)
        {
            Documentacion documentacion = _context.Documentacion.Find(id);

            if (documentacion.Adjunto != null)
            {
                byte[] byteDoc = documentacion.Adjunto;
                MemoryStream memoryStream = new MemoryStream(byteDoc);
                //Image image = Image.FromStream(memoryStream);
                //memoryStream = new MemoryStream();
                //image.Save(memoryStream, ImageFormat.Jpeg);
                memoryStream.Position = 0;
                if (documentacion.Tipo != "jpeg")
                {
                    auxExt = $"application / {documentacion.Tipo}";
                }
                else
                {
                    auxExt = $"image / {documentacion.Tipo}";
                }
                return File(memoryStream, auxExt);
                //return File(memoryStream, $"{documentacion.Tipo}");
            }

            else

            {
                return RedirectToAction("EstudioCausa", new { id = documentacion.DeclaracionJuradaID });
            }
        }
        public ActionResult delAdjunto(int id)
        {
            Documentacion documentacion = _context.Documentacion.Find(id);

            documentacion.Adjunto = null;
            documentacion.Tipo = null;
            _context.SaveChanges();

            return RedirectToAction("EstudioCausa", new { id = documentacion.DeclaracionJuradaID });
        }
        /*   EDITAR ESTUDIOS */
        [HttpGet]
        public async Task<IActionResult> _EditarEstudio(int id)
        {

            var estudio = await _context.EstudioDDJJ.FindAsync(id);
            ViewBag.Escolaridad = _context.Escolaridad.Where(x => x.Id > 2).Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            ViewBag.DJId = estudio.DeclaracionJuradaID;
            if (estudio == null)
            {
                return NotFound();
            }
            return PartialView("EstudioCausa/_EditarEstudio", estudio);
        }

        [HttpPost]
        public async Task<IActionResult> _EditarEstudio(int id, EstudioDDJJ estudio)
        {
            if (id != estudio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(estudio);
                await _context.SaveChangesAsync();
                return RedirectToAction("EstudioCausa", new { id = estudio.DeclaracionJuradaID });
            }
            return View("DeclaracionJurada/EstudioCausa/Index");
            //return RedirectToAction("Index");
        }

        /*   EDITAR DOCUMENTACION ADJUNTA   */
        [HttpGet]
        public async Task<IActionResult> _EditarDocumento(int id)
        {

            var documento = await _context.Documentacion.FindAsync(id);
            ViewBag.TipoDocumentoAdjunto = _context.TipoDocumentoAdjunto.Select(d => new SelectListItem() { Text = d.Descripcion, Value = d.Id.ToString() });
            ViewBag.DJId = documento.DeclaracionJuradaID;
            if (documento == null)
            {
                return NotFound();
            }
            return PartialView("EstudioCausa/_EditarDocumento", documento);
        }
        [HttpPost]
        public async Task<IActionResult> _EditarDocumento(int id, Documentacion documento)
        {
            if (id != documento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(documento);
                await _context.SaveChangesAsync();
                return RedirectToAction("EstudioCausa", new { id = documento.DeclaracionJuradaID });
            }
            return View("DeclaracionJurada/EstudioCausa/Index");
        }

        /*     EDITAR CAUSA JUDICIAL    */

        [HttpGet]
        public async Task<IActionResult> _EditarCausa(int id)
        {

            var causa = await _context.CausaJudicialDDJJ.FindAsync(id);
            ViewBag.TipoExpediente = _context.TipoExpediente.Select(e => new SelectListItem() { Text = e.Descripcion, Value = e.Id.ToString() });
            ViewBag.DJId = causa.DeclaracionJuradaID;
            if (causa == null)
            {
                return NotFound();
            }
            return PartialView("EstudioCausa/_EditarCausa", causa);
        }
        [HttpPost]
        public async Task<IActionResult> _EditarCausa(int id, CausaJudicialDDJJ causa)
        {
            if (id != causa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(causa);
                await _context.SaveChangesAsync();
                return RedirectToAction("EstudioCausa", new { id = causa.DeclaracionJuradaID });
            }
            return View("DeclaracionJurada/EstudioCausa/Index");
        }
        /*--------------------------Eliminar----------------------------------------- */
        public async Task<IActionResult> DeleteDocumento(int id)
        {
            var documento = await _context.Documentacion.FindAsync(id);
            _context.Documentacion.Remove(documento);
            await _context.SaveChangesAsync();
            return RedirectToAction("EstudioCausa", new { id = documento.DeclaracionJuradaID });
        }
        public async Task<IActionResult> DeleteEstudio(int id)
        {
            var estudio = await _context.EstudioDDJJ.FindAsync(id);
            _context.EstudioDDJJ.Remove(estudio);
            await _context.SaveChangesAsync();
            return RedirectToAction("EstudioCausa", new { id = estudio.DeclaracionJuradaID });
        }
        public async Task<IActionResult> DeleteCausa(int id)
        {
            var causa = await _context.CausaJudicialDDJJ.FindAsync(id);
            _context.CausaJudicialDDJJ.Remove(causa);
            await _context.SaveChangesAsync();
            return RedirectToAction("EstudioCausa", new { id = causa.DeclaracionJuradaID });
        }
        /* Vista previa */

        public IActionResult VistaPrevia(int id)
        {
            ViewBag.MenuActivo = "VP";
            ViewBag.Pais = _context.Pais.Select(p => new SelectListItem() { Text = p.Descripcion, Value = p.Id.ToString() });
            //ViewBag.Provincia = _context.Provincia.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            //ViewBag.Localidad = _context.Localidad.Select(t => new SelectListItem() { Text = t.Descripcion, Value = t.Id.ToString() });
            //ViewBag.Unidad = _context.Unidad.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            //ViewBag.Guarniciones = _context.Guarnicion.Select(l => new SelectListItem() { Text = l.Descripcion, Value = l.Id.ToString() });
            VistaPreviaViewModel vp = new VistaPreviaViewModel();
            vp.EstudioCausaViewModel = new EstudioCausaViewModel();
            vp.FamiliaContactoViewModel = new FamiliaContactoViewModel();
            vp.DomicilioViviendaViewModel = new DomicilioViviendaViewModel();
            vp.DeclaracionJurada = new DeclaracionJurada();

            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Domicilio).ThenInclude(d => d.Provincia).Where(d => d.Domicilio.Provincia.Id == d.Domicilio.ProvinciaId).Include(d => d.Domicilio.Localidad).Where(d => d.Domicilio.Localidad.Id == d.Domicilio.LocalidadId).Include(d => d.Vivienda).ThenInclude(d => d.AlojamientoUnidad).Where(d => d.Vivienda.AlojamientoUnidad.Id == d.Vivienda.AlojamientoUnidadID).Include(d => d.Vivienda.GuarnicionSoluciona).Where(d => d.Vivienda.GuarnicionSoluciona.Id == d.Vivienda.GuarnicionSolucionaID).Include(d => d.Vivienda.GuarnicionViviendaProxima1).Where(d => d.Vivienda.GuarnicionViviendaProxima1.Id == d.Vivienda.GuarnicionViviendaProxima1ID).FirstOrDefault();

            vp.DeclaracionJuradaID = dj.ID;
            vp.DomicilioViviendaViewModel.Domicilio = dj.Domicilio;
            vp.DomicilioViviendaViewModel.Vivienda = dj.Vivienda;



            DeclaracionJurada dj1 = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Estudios).ThenInclude(t => t.Escolaridad).Include(d => d.CausasJudiciales).ThenInclude(d => d.TipoExpediente).Include(d => d.Documentos).ThenInclude(d => d.TipoDocumentoAdjunto).FirstOrDefault();
            vp.DeclaracionJuradaID = dj1.ID;
            vp.EstudioCausaViewModel.Estudios = dj1.Estudios;
            vp.EstudioCausaViewModel.Causas = dj1.CausasJudiciales;
            vp.EstudioCausaViewModel.Documentos = dj1.Documentos;

            DeclaracionJurada dj2 = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d => d.Contactos).ThenInclude(t => t.TipoContacto).Include(g => g.Familiares).ThenInclude(g => g.Genero).Include(g => g.Familiares).ThenInclude(g => g.TipoDocumento).Include(g => g.Familiares).ThenInclude(g => g.Fuerza).Include(g => g.Familiares).ThenInclude(g => g.SituacionLaboral).Include(g => g.Familiares).ThenInclude(g => g.Escolaridad).Include(g => g.Familiares).ThenInclude(g => g.Grado).Include(d => d.Familiares).ThenInclude(f => f.EstadoCivil).Include(d => d.Familiares).ThenInclude(f => f.Parentesco).Include(d => d.Familiares).ThenInclude(c => c.Domicilio).ThenInclude(p => p.Provincia).Where(p =>p.Domicilio.Provincia.Id == p.Domicilio.ProvinciaId).Include(d => d.Familiares).ThenInclude(c => c.Domicilio).ThenInclude(p => p.Localidad).Where(p => p.Domicilio.Localidad.Id == p.Domicilio.LocalidadId).Include(d => d.Familiares).ThenInclude(p => p.LocalidadEmpleador).Include(d => d.Familiares).ThenInclude(p => p.ProvinciaEmpleador).Include(d => d.EstadoCivil).Include(s => s.SituacionFamiliar).Include(u => u.Familiares).ThenInclude(p => p.ProvinciaDefuncion).Include(u => u.Familiares).ThenInclude(p => p.LocalidadDefuncion).FirstOrDefault();
            vp.DeclaracionJuradaID = dj2.ID;
            vp.FamiliaContactoViewModel.Contactos = dj2.Contactos;
            vp.FamiliaContactoViewModel.EstadoCivil = dj2.EstadoCivil;
            vp.FamiliaContactoViewModel.SituacionFamiliar = dj2.SituacionFamiliar;
            vp.FamiliaContactoViewModel.OtraSituacion = dj2.OtraSituacionFamiliar;
            vp.FamiliaContactoViewModel.Familiares = dj2.Familiares;

            DeclaracionJurada dj3 = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            vp.DeclaracionJuradaID = dj3.ID;
            vp.DeclaracionJurada.EstadoID = dj3.EstadoID;

            return View("VistaPrevia/Index", vp);
        }

        [HttpGet]
        public async Task<IActionResult> _DetalleFamiliar(int id)
        {
            var familiar = await _context.Familiar.FindAsync(id);

            if (familiar is null)
            {
                return NotFound();
            }
            armaListasFamiliar();
            ViewBag.DJID = familiar.DeclaracionJuradaID;
            return PartialView("VistaPrevia/_DetalleFamiliar", familiar);
        }

        public IActionResult Elevar(int id)
                {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            //AGREGAR VALIDACIONES

            dj.Estado = EstadoDDJJ.ElevadoPersonal(_context);
            dj.ObservacionActual = "";
            dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionElemento, "Declaracion Jurada elevada al Jefe de Personal", ObtenerUsuario(_userService)), ""));
            _context.SaveChanges();
            AddPageAlerts(PageAlertType.Success, "Se elevo la Declaracion jurada correctamente");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ElevarElemento(int id, string observacion)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            //AGREGAR VALIDACIONES

            dj.Estado = EstadoDDJJ.ElevadoJefeElemento(_context);
            dj.ObservacionActual = observacion;
            dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionElemento, "Declaracion Jurada elevada al Jefe de Elemento - " + observacion, ObtenerUsuario(_userService)), ""));
            _context.SaveChanges();
            AddPageAlerts(PageAlertType.Success, "Se elevo la Declaracion jurada correctamente");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ElevarDGP(int id, string observacion)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            //AGREGAR VALIDACIONES

            dj.Estado = EstadoDDJJ.ElevadoDGP(_context);
            dj.ObservacionActual = observacion;
            dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionDGP, "Declaracion Jurada elevada a la DGPB - "+observacion, ObtenerUsuario(_userService)), ""));
            _context.SaveChanges();
            AddPageAlerts(PageAlertType.Success, "Se elevo la Declaracion jurada correctamente");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult _VerHistorial(int id)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).Include(d=>d.Bitacoras).FirstOrDefault();
            return PartialView("_VerHistorial", dj.Bitacoras);
        }
        public IActionResult _SolicitarModificacion(int id)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            return PartialView("_SolicitarModificacion", dj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SolicitarModificacion(int id, string observacion)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            //AGREGAR VALIDACIONES

            dj.Estado = EstadoDDJJ.ModificacionSolicitada(_context);
            dj.ObservacionActual = observacion;
            dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJElevacionElemento, "Solicitud de Modificacion: " + observacion, ObtenerUsuario(_userService)), ""));
            _context.SaveChanges();
            AddPageAlerts(PageAlertType.Success, "Se solicito la modificacion correctamente");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult _ObservadaPersonal(int id)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            return PartialView("_ObservadaPersonal", dj);
        }

        [HttpPost]
        public IActionResult ObservadaPersonal(int id, string observacion)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            dj.Estado = EstadoDDJJ.ObservadaPersonal(_context);
            dj.ObservacionActual = observacion;
            dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJObservadaPersonal, "Declaracion Jurada Observada observada por el Area de Personal: " + observacion, ObtenerUsuario(_userService)), ""));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult _ObservadaElemento(int id)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            return PartialView("_ObservadaElemento", dj);
        }

        [HttpPost]
        public IActionResult ObservadaElemento(int id, string observacion)
        {
            DeclaracionJurada dj = _context.DeclaracionJurada.Where(d => d.ID == id).FirstOrDefault();
            dj.Estado = EstadoDDJJ.ObservadaElemento(_context);
            dj.ObservacionActual = observacion;
            dj.Bitacoras.Add(BitacoraDDJJ.CrearBitacoraDDJJ(Bitacora.CrearBitacora(TipoBitacora.DDJJObservadaElemento, "Declaracion Jurada Observada por el Elemento: " + observacion, ObtenerUsuario(_userService)), ""));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
