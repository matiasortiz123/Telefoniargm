#pragma checksum "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e80123a9302013fc7c3bae276362b5fa1b5737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AsignarEquipos__ListadoDeAsignacionEquipos), @"mvc.1.0.view", @"/Areas/Admin/Views/AsignarEquipos/_ListadoDeAsignacionEquipos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AsignarEquipos/_ListadoDeAsignacionEquipos.cshtml", typeof(AspNetCore.Areas_Admin_Views_AsignarEquipos__ListadoDeAsignacionEquipos))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\_ViewImports.cshtml"
using modulo_documentacion;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\_ViewImports.cshtml"
using modulo_documentacion.Models;

#line default
#line hidden
#line 1 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
using Commons.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e80123a9302013fc7c3bae276362b5fa1b5737", @"/Areas/Admin/Views/AsignarEquipos/_ListadoDeAsignacionEquipos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbfddb5d17ff57c55b377374de0193b8d8db5ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AsignarEquipos__ListadoDeAsignacionEquipos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page<modulo_documentacion.Areas.Admin.Models.Basicas.Equipo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Listado de Equipos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Asignar equipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", "padding-inline-start", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Listado de Equipos ya asignados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Desasignar equipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("function", "AsignarEquipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/AsignarEquipos/_CreateSeleccion/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("function", "DesasignarEquipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/AsignarEquipos/_Desasignar_Equipos/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Commons.TagHelpers.Boxes.BoxHeaderTagHelper __Commons_TagHelpers_Boxes_BoxHeaderTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxBodyTagHelper __Commons_TagHelpers_Boxes_BoxBodyTagHelper;
        private global::Commons.TagHelpers.AToolipTagHelper __Commons_TagHelpers_AToolipTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxTagHelper __Commons_TagHelpers_Boxes_BoxTagHelper;
        private global::Commons.TagHelpers.ModalTagHelper __Commons_TagHelpers_ModalTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(91, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b57377746", async() => {
                BeginContext(130, 249, true);
                WriteLiteral("\n\n    <div class=\"input-group input-group-sm pull-right\" style=\"max-width: 300px;\">\n        <a onclick=\"nuevoEquipo()\" class=\"btn btn-info btn-sm\">\n            <i class=\"fa fa-plus\"><span class=\"hidden-xs\"> Nuevo</span></i>\n        </a>\n    </div>\n\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxHeaderTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxHeaderTagHelper);
            __Commons_TagHelpers_Boxes_BoxHeaderTagHelper.Title = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(392, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(393, 1893, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b57379356", async() => {
                BeginContext(445, 404, true);
                WriteLiteral(@"
    <table id=""listadoAsignarEquipos"" class=""table table-striped"">
        <thead>
            <tr>
                <th>Imei</th>
                <th>Accesorios</th>
                <th>Gama</th>
                <th>Condicion</th>
                <th>Marca</th>
                <th>Modelo</th>
                <th>Empresa</th>
                <th>Estado de equipo</th>
                <th>Acciones</th>
");
                EndContext();
                BeginContext(918, 52, true);
                WriteLiteral("\n            </tr>\n        </thead>\n        <tbody>\n");
                EndContext();
#line 32 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
             foreach (var item in Model.Items)
            {
                //Si el equipo es diferente de true , significa que el equipo no esta asignado
                

#line default
#line hidden
#line 35 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                 if (item.Editable != true)
                {

#line default
#line hidden
                BeginContext(1188, 65, true);
                WriteLiteral("                    <tr>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1254, 39, false);
#line 38 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Imei));

#line default
#line hidden
                EndContext();
                BeginContext(1293, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1340, 45, false);
#line 39 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Accesorios));

#line default
#line hidden
                EndContext();
                BeginContext(1385, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1432, 39, false);
#line 40 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Gama));

#line default
#line hidden
                EndContext();
                BeginContext(1471, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1518, 44, false);
#line 41 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Condicion));

#line default
#line hidden
                EndContext();
                BeginContext(1562, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1609, 52, false);
#line 42 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Marca.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(1661, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1708, 53, false);
#line 43 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Modelo.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(1761, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1808, 49, false);
#line 44 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Empresa.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(1857, 46, true);
                WriteLiteral("</td>\n                        <td scope=\"col\">");
                EndContext();
                BeginContext(1904, 54, false);
#line 45 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EstadoEquipo.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(1958, 63, true);
                WriteLiteral("</td>\n                        <td>\n                            ");
                EndContext();
                BeginContext(2021, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573715124", async() => {
                    BeginContext(2114, 27, true);
                    WriteLiteral("<i class=\"fa fa-users\"></i>");
                    EndContext();
                }
                );
                __Commons_TagHelpers_AToolipTagHelper = CreateTagHelper<global::Commons.TagHelpers.AToolipTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_AToolipTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2033, "AsignarEquipo(\'", 2033, 15, true);
#line 47 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
AddHtmlAttributeValue("", 2048, item.Id, 2048, 8, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 2056, "\')", 2056, 2, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Commons_TagHelpers_AToolipTagHelper.Title = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2145, 57, true);
                WriteLiteral("\n                        </td>\n                    </tr>\n");
                EndContext();
#line 50 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                }

#line default
#line hidden
#line 50 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                            
            }

#line default
#line hidden
                BeginContext(2245, 30, true);
                WriteLiteral("        </tbody>\n    </table>\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxBodyTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxBodyTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxBodyTagHelper);
#line 13 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_Boxes_BoxBodyTagHelper.Table = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("table", __Commons_TagHelpers_Boxes_BoxBodyTagHelper.Table, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Commons_TagHelpers_Boxes_BoxBodyTagHelper.Style = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2286, 24, true);
            WriteLiteral("\n\n<br />\n<hr />\n<br />\n\n");
            EndContext();
            BeginContext(2310, 2160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573719287", async() => {
                BeginContext(2331, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(2337, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573719674", async() => {
                }
                );
                __Commons_TagHelpers_Boxes_BoxHeaderTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxHeaderTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxHeaderTagHelper);
                __Commons_TagHelpers_Boxes_BoxHeaderTagHelper.Title = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2402, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(2408, 2054, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573720987", async() => {
                    BeginContext(2460, 455, true);
                    WriteLiteral(@"
        <table id=""listadoDesasignarEquipos"" class=""table table-striped"">
            <thead>
                <tr>
                    <th>Imei</th>
                    <th>Accesorios</th>
                    <th>Gama</th>
                    <th>Condicion</th>
                    <th>Marca</th>
                    <th>Modelo</th>
                    <th>Empresa</th>
                    <th>Estado de equipo</th>
                    <th>Acciones</th>
");
                    EndContext();
                    BeginContext(2994, 64, true);
                    WriteLiteral("\n                </tr>\n            </thead>\n            <tbody>\n");
                    EndContext();
#line 83 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                 foreach (var item in Model.Items)
                {
                    //Si el equipo es diferente de true , significa que el equipo no esta asignado
                    

#line default
#line hidden
#line 86 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                     if (item.Editable != false)
                    {

#line default
#line hidden
                    BeginContext(3297, 73, true);
                    WriteLiteral("                        <tr>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3371, 39, false);
#line 89 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Imei));

#line default
#line hidden
                    EndContext();
                    BeginContext(3410, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3461, 45, false);
#line 90 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Accesorios));

#line default
#line hidden
                    EndContext();
                    BeginContext(3506, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3557, 39, false);
#line 91 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Gama));

#line default
#line hidden
                    EndContext();
                    BeginContext(3596, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3647, 44, false);
#line 92 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Condicion));

#line default
#line hidden
                    EndContext();
                    BeginContext(3691, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3742, 52, false);
#line 93 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Marca.Descripcion));

#line default
#line hidden
                    EndContext();
                    BeginContext(3794, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3845, 53, false);
#line 94 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Modelo.Descripcion));

#line default
#line hidden
                    EndContext();
                    BeginContext(3898, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(3949, 49, false);
#line 95 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Empresa.Nombre));

#line default
#line hidden
                    EndContext();
                    BeginContext(3998, 50, true);
                    WriteLiteral("</td>\n                            <td scope=\"col\">");
                    EndContext();
                    BeginContext(4049, 54, false);
#line 96 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.EstadoEquipo.Estado));

#line default
#line hidden
                    EndContext();
                    BeginContext(4103, 71, true);
                    WriteLiteral("</td>\n                            <td>\n                                ");
                    EndContext();
                    BeginContext(4174, 128, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573727126", async() => {
                        BeginContext(4273, 25, true);
                        WriteLiteral("<i class=\"fa fa-ban\"></i>");
                        EndContext();
                    }
                    );
                    __Commons_TagHelpers_AToolipTagHelper = CreateTagHelper<global::Commons.TagHelpers.AToolipTagHelper>();
                    __tagHelperExecutionContext.Add(__Commons_TagHelpers_AToolipTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 4186, "DesasignarEquipo(\'", 4186, 18, true);
#line 98 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
AddHtmlAttributeValue("", 4204, item.Id, 4204, 8, false);

#line default
#line hidden
                    AddHtmlAttributeValue("", 4212, "\')", 4212, 2, true);
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    __Commons_TagHelpers_AToolipTagHelper.Title = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4302, 65, true);
                    WriteLiteral("\n                            </td>\n                        </tr>\n");
                    EndContext();
#line 101 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                     }

#line default
#line hidden
#line 101 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                      
                 }

#line default
#line hidden
                    BeginContext(4409, 42, true);
                    WriteLiteral("            </tbody>\n        </table>\n    ");
                    EndContext();
                }
                );
                __Commons_TagHelpers_Boxes_BoxBodyTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxBodyTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxBodyTagHelper);
#line 64 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_Boxes_BoxBodyTagHelper.Table = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("table", __Commons_TagHelpers_Boxes_BoxBodyTagHelper.Table, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Commons_TagHelpers_Boxes_BoxBodyTagHelper.Style = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4462, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxTagHelper);
#line 60 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_Boxes_BoxTagHelper.Color = global::Commons.TagHelpers.Boxes.BoxColor.Warning;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("color", __Commons_TagHelpers_Boxes_BoxTagHelper.Color, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4470, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            BeginContext(4852, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573732703", async() => {
            }
            );
            __Commons_TagHelpers_ModalTagHelper = CreateTagHelper<global::Commons.TagHelpers.ModalTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_ModalTagHelper);
            __Commons_TagHelpers_ModalTagHelper.Title = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 113 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_ModalTagHelper.Callback = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("callback-modal", __Commons_TagHelpers_ModalTagHelper.Callback, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Commons_TagHelpers_ModalTagHelper.Function = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Commons_TagHelpers_ModalTagHelper.Url = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 113 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_ModalTagHelper.Sizes = global::Commons.TagHelpers.ModalSizes.Medium;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("size", __Commons_TagHelpers_ModalTagHelper.Sizes, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5002, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(5003, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e80123a9302013fc7c3bae276362b5fa1b573735155", async() => {
            }
            );
            __Commons_TagHelpers_ModalTagHelper = CreateTagHelper<global::Commons.TagHelpers.ModalTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_ModalTagHelper);
            __Commons_TagHelpers_ModalTagHelper.Title = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 114 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_ModalTagHelper.Callback = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("callback-modal", __Commons_TagHelpers_ModalTagHelper.Callback, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Commons_TagHelpers_ModalTagHelper.Function = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Commons_TagHelpers_ModalTagHelper.Url = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 114 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
__Commons_TagHelpers_ModalTagHelper.Sizes = global::Commons.TagHelpers.ModalSizes.Medium;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("size", __Commons_TagHelpers_ModalTagHelper.Sizes, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5162, 295, true);
            WriteLiteral(@"

<script>
    $(document).ready(function () {

        $('#listadoAsignarEquipos').DataTable({
            ""columnDefs"": [{
                ""searchable"": false,
                ""orderable"": false,
                //""targets"": 3
            }],
            ""language"": {
                'url': '");
            EndContext();
            BeginContext(5458, 29, false);
#line 126 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                   Write(Url.Content("~/lib/arg.json"));

#line default
#line hidden
            EndContext();
            BeginContext(5487, 279, true);
            WriteLiteral(@"'
            }
        });

        $('#listadoDesasignarEquipos').DataTable({
            ""columnDefs"": [{
                ""searchable"": false,
                ""orderable"": false,
                //""targets"": 3
            }],
            ""language"": {
                'url': '");
            EndContext();
            BeginContext(5767, 29, false);
#line 137 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\AsignarEquipos\_ListadoDeAsignacionEquipos.cshtml"
                   Write(Url.Content("~/lib/arg.json"));

#line default
#line hidden
            EndContext();
            BeginContext(5796, 49, true);
            WriteLiteral("\'\n            }\n        });\n\n    });\n\n\n\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page<modulo_documentacion.Areas.Admin.Models.Basicas.Equipo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
