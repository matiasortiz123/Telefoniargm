#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bca2ef65e54e593b5b406b03bc663c2b922714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AsignarEquipo_Index), @"mvc.1.0.view", @"/Views/AsignarEquipo/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\_ViewImports.cshtml"
using TelefoniaCargas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\_ViewImports.cshtml"
using TelefoniaCargas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62bca2ef65e54e593b5b406b03bc663c2b922714", @"/Views/AsignarEquipo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e8f4eeda2c6febdb94ffbea49ae3e2757e54b72", @"/Views/_ViewImports.cshtml")]
    public class Views_AsignarEquipo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TelefoniaCargas.Models.Persona_Dependencia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net-bs4/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AsignarEquipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarUsuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Asignar equipo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm bi bi-brush-fill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net-bs4/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62bca2ef65e54e593b5b406b03bc663c2b9227146923", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"<div class=""content-wrapper"">
    <div class=""container-fluid p-4"">
        <div class=""row"">
            <div class=""col-sm-10"">
                <h3>Lista de personas para agragar los equipos</h3>
            </div>
            <div class=""col-sm-2"">
                <a class=""btn btn-success float-right text-white"" data-toggle=""modal"" data-target=""#myModalInicial"" onclick=""CrearEquipo()""> <i class=""fas fa-plus""></i> Agregar equipo</a>
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-md-12"">
");
#nullable restore
#line 21 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\" id=\"tablaUsuarios\" width=\"100%\" cellspacing=\"0\">\n        <thead class=\"thead-dark\">\n            <tr>\n                <th scope=\"col\">");
#nullable restore
#line 26 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.Persona.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"col\">");
#nullable restore
#line 27 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.Persona.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"col\">");
#nullable restore
#line 28 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.Dependencia.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"col\">");
#nullable restore
#line 29 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.Dependencia.Unidad.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"col\">Acciones</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 34 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 37 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
   Write(item.Persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 38 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
   Write(item.Persona.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 39 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
   Write(item.Dependencia.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 40 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
   Write(item.Dependencia.Unidad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62bca2ef65e54e593b5b406b03bc663c2b92271411985", async() => {
                WriteLiteral("\n            Asignar\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </td>\n</tr>");
#nullable restore
#line 47 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table> ");
#nullable restore
#line 49 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
             }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center text-danger ml-3\">No hay registros guardados</p>");
#nullable restore
#line 52 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\AsignarEquipo\Index.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>


<!-- Modal 1 crear-->
<div class=""modal fade"" id=""myModalInicial"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Crear nuevo equipo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""cuerpoModalInicial""></div>
        </div>
    </div>
</div>

<!-- Modal 1-->
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modificar equipo</h5>
                <button type=""button"" class=""cl");
            WriteLiteral(@"ose"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""cuerpoModal""></div>
        </div>
    </div>
</div>

<!-- Modal 2-->
<div class=""modal fade"" id=""myModal2"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Detalle del equipo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""cuerpoModal2""></div>
        </div>
    </div>
</div>

<!-- Modal 3-->
<div class=""modal fade"" id=""myModal3"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div");
            WriteLiteral(@" class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar equipo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""cuerpoModal3""></div>
        </div>
    </div>
</div>


<!-- Script modal 1-->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function AsignarEquipo() {
            $.ajax({
                method: ""GET"",
                url: ""AsignarEquipos/_Create"",
            }).done(function (data) {
                $(""#cuerpoModalInicial"").html(data);
                $(""#myModalInicial"").show();
            });
        }

    </script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62bca2ef65e54e593b5b406b03bc663c2b92271417606", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62bca2ef65e54e593b5b406b03bc663c2b92271418704", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            $('#tablaUsuarios').DataTable(
                {
                    language: {
                        ""processing"": ""Procesando..."",
                        ""lengthMenu"": ""Mostrar MENU registros"",
                        ""zeroRecords"": ""No se encontraron resultados"",
                        ""emptyTable"": ""Ningún dato disponible en esta tabla"",
                        ""info"": ""Mostrando registros del START al END de un total de TOTAL registros"",
                        ""infoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                        ""infoFiltered"": ""(filtrado de un total de MAX registros)"",
                        ""search"": ""Buscar:"",
                        ""infoThousands"": "","",
                        ""loadingRecords"": ""Cargando..."",
                        ""paginate"": {
                            ""first"": ""Primero"",
                            ""last"": ""Último"",
                            ""next"": ""Siguien");
                WriteLiteral(@"te"",
                            ""previous"": ""Anterior""
                        },
                        ""aria"": {
                            ""sortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                            ""sortDescending"": "": Activar para ordenar la columna de manera descendente""
                        },
                        ""buttons"": {
                            ""copy"": ""Copiar"",
                            ""colvis"": ""Visibilidad"",
                            ""collection"": ""Colección"",
                            ""colvisRestore"": ""Restaurar visibilidad"",
                            ""copyKeys"": ""Presione ctrl o u2318 + C para copiar los datos de la tabla al portapapeles del sistema. <br \/> <br \/> Para cancelar, haga clic en este mensaje o presione escape."",
                            ""copySuccess"": {
                                ""1"": ""Copiada 1 fila al portapapeles"",
                                ""_"": ""Copiadas %d fila al portapapeles""
                ");
                WriteLiteral(@"            },
                            ""copyTitle"": ""Copiar al portapapeles"",
                            ""csv"": ""CSV"",
                            ""excel"": ""Excel"",
                            ""pageLength"": {
                                ""-1"": ""Mostrar todas las filas"",
                                ""1"": ""Mostrar 1 fila"",
                                ""_"": ""Mostrar %d filas""
                            },
                            ""pdf"": ""PDF"",
                            ""print"": ""Imprimir""
                        },
                        ""autoFill"": {
                            ""cancel"": ""Cancelar"",
                            ""fill"": ""Rellene todas las celdas con <i>%d<\/i>"",
                            ""fillHorizontal"": ""Rellenar celdas horizontalmente"",
                            ""fillVertical"": ""Rellenar celdas verticalmentemente""
                        },
                        ""decimal"": "","",
                        ""searchBuilder"": {
                            ""add"": ""Añadir cond");
                WriteLiteral(@"ición"",
                            ""button"": {
                                ""0"": ""Constructor de búsqueda"",
                                ""_"": ""Constructor de búsqueda (%d)""
                            },
                            ""clearAll"": ""Borrar todo"",
                            ""condition"": ""Condición"",
                            ""conditions"": {
                                ""date"": {
                                    ""after"": ""Despues"",
                                    ""before"": ""Antes"",
                                    ""between"": ""Entre"",
                                    ""empty"": ""Vacío"",
                                    ""equals"": ""Igual a"",
                                    ""not"": ""No"",
                                    ""notBetween"": ""No entre"",
                                    ""notEmpty"": ""No Vacio""
                                },
                                ""moment"": {
                                    ""after"": ""Despues"",
                                   ");
                WriteLiteral(@" ""before"": ""Antes"",
                                    ""between"": ""Entre"",
                                    ""empty"": ""Vacío"",
                                    ""equals"": ""Igual a"",
                                    ""not"": ""No"",
                                    ""notBetween"": ""No entre"",
                                    ""notEmpty"": ""No vacio""
                                },
                                ""number"": {
                                    ""between"": ""Entre"",
                                    ""empty"": ""Vacio"",
                                    ""equals"": ""Igual a"",
                                    ""gt"": ""Mayor a"",
                                    ""gte"": ""Mayor o igual a"",
                                    ""lt"": ""Menor que"",
                                    ""lte"": ""Menor o igual que"",
                                    ""not"": ""No"",
                                    ""notBetween"": ""No entre"",
                                    ""notEmpty"": ""No vacío""
                 ");
                WriteLiteral(@"               },
                                ""string"": {
                                    ""contains"": ""Contiene"",
                                    ""empty"": ""Vacío"",
                                    ""endsWith"": ""Termina en"",
                                    ""equals"": ""Igual a"",
                                    ""not"": ""No"",
                                    ""notEmpty"": ""No Vacio"",
                                    ""startsWith"": ""Empieza con""
                                }
                            },
                            ""data"": ""Data"",
                            ""deleteTitle"": ""Eliminar regla de filtrado"",
                            ""leftTitle"": ""Criterios anulados"",
                            ""logicAnd"": ""Y"",
                            ""logicOr"": ""O"",
                            ""rightTitle"": ""Criterios de sangría"",
                            ""title"": {
                                ""0"": ""Constructor de búsqueda"",
                                ""_"": ""Constructor de ");
                WriteLiteral(@"búsqueda (%d)""
                            },
                            ""value"": ""Valor""
                        },
                        ""searchPanes"": {
                            ""clearMessage"": ""Borrar todo"",
                            ""collapse"": {
                                ""0"": ""Paneles de búsqueda"",
                                ""_"": ""Paneles de búsqueda (%d)""
                            },
                            ""count"": ""{total}"",
                            ""countFiltered"": ""{shown} ({total})"",
                            ""emptyPanes"": ""Sin paneles de búsqueda"",
                            ""loadMessage"": ""Cargando paneles de búsqueda"",
                            ""title"": ""Filtros Activos - %d""
                        },
                        ""select"": {
                            ""1"": ""%d fila seleccionada"",
                            ""_"": ""%d filas seleccionadas"",
                            ""cells"": {
                                ""1"": ""1 celda seleccionada"",
            ");
                WriteLiteral(@"                    ""_"": ""$d celdas seleccionadas""
                            },
                            ""columns"": {
                                ""1"": ""1 columna seleccionada"",
                                ""_"": ""%d columnas seleccionadas""
                            }
                        },
                        ""thousands"": "".""
                    }
                }
            );
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TelefoniaCargas.Models.Persona_Dependencia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
