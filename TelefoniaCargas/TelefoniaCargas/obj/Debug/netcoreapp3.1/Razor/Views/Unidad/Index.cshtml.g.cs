#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2d12b689cd97c6ca689e1f872abaee35fe3f69c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Unidad_Index), @"mvc.1.0.view", @"/Views/Unidad/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d12b689cd97c6ca689e1f872abaee35fe3f69c", @"/Views/Unidad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e8f4eeda2c6febdb94ffbea49ae3e2757e54b72", @"/Views/_ViewImports.cshtml")]
    public class Views_Unidad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TelefoniaCargas.Models.Unidad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net-bs4/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""container-fluid p-4"">
        <div class=""row"">
            <div class=""col-sm-10"">
                <h3>Lista de Unidades</h3>
            </div>
            <div class=""col-sm-2"">
                <a class=""btn btn-success float-right text-white"" data-toggle=""modal"" data-target=""#myModalInicial"" onclick=""CrearUnidad()""> <i class=""fas fa-plus""></i> Agregar </a>
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-md-12"">
");
#nullable restore
#line 18 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\" id=\"tablaUsuarios\" width=\"100%\" cellspacing=\"0\">\n        <thead class=\"thead-dark\">\n            <tr>\n                <th scope=\"col\">");
#nullable restore
#line 23 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"col\">Acciones</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 28 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 31 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        <a href=\"#\" title=\"Editar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1161, "\"", 1193, 3);
            WriteAttributeValue("", 1171, "EditarUnidad(", 1171, 13, true);
#nullable restore
#line 33 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
WriteAttributeValue("", 1184, item.Id, 1184, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1192, ")", 1192, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-info btn-sm bi bi-brush-fill"" data-toggle=""modal"" data-target=""#myModal"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-brush-fill"" viewBox=""0 0 16 16"">
                <path d=""M15.825.12a.5.5 0 0 1 .132.584c-1.53 3.43-4.743 8.17-7.095 10.64a6.067 6.067 0 0 1-2.373 1.534c-.018.227-.06.538-.16.868-.201.659-.667 1.479-1.708 1.74a8.117 8.117 0 0 1-3.078.132 3.658 3.658 0 0 1-.563-.135 1.382 1.382 0 0 1-.465-.247.714.714 0 0 1-.204-.288.622.622 0 0 1 .004-.443c.095-.245.316-.38.461-.452.393-.197.625-.453.867-.826.094-.144.184-.297.287-.472l.117-.198c.151-.255.326-.54.546-.848.528-.739 1.2-.925 1.746-.896.126.007.243.025.348.048.062-.172.142-.38.238-.608.261-.619.658-1.419 1.187-2.069 2.175-2.67 6.18-6.206 9.117-8.104a.5.5 0 0 1 .596.04z"" />
            </svg>
        </a>

        <a href=""#"" title=""Detalle""");
            BeginWriteAttribute("onclick", " onclick=\"", 2102, "\"", 2135, 3);
            WriteAttributeValue("", 2112, "DetalleUnidad(", 2112, 14, true);
#nullable restore
#line 39 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
WriteAttributeValue("", 2126, item.Id, 2126, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2134, ")", 2134, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-success btn-sm bi bi-eye-fill"" data-toggle=""modal"" data-target=""#myModal2"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-eye-fill"" viewBox=""0 0 16 16"">
                <path d=""M10.5 8a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0z"" />
                <path d=""M0 8s3-5.5 8-5.5S16 8 16 8s-3 5.5-8 5.5S0 8 0 8zm8 3.5a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7z"" />
            </svg>
        </a>

        <a href=""#"" title=""Delete""");
            BeginWriteAttribute("onclick", " onclick=\"", 2643, "\"", 2677, 3);
            WriteAttributeValue("", 2653, "EliminarUnidad(", 2653, 15, true);
#nullable restore
#line 46 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
WriteAttributeValue("", 2668, item.Id, 2668, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2676, ")", 2676, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-danger btn-sm bi bi-trash"" data-toggle=""modal"" data-target=""#myModal3"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
                <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"" />
            </svg>
        </a>

    </td>
</tr>
");
#nullable restore
#line 55 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table> ");
#nullable restore
#line 57 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
             }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-center text-danger ml-3\">No hay registros guardados</p>");
#nullable restore
#line 60 "C:\Users\CPS-DLLO#11\Desktop\DUFI-main\TelefoniaCargas\TelefoniaCargas\Views\Unidad\Index.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div> <!-- Modal 1 crear-->
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
</div> <!-- Modal 1-->
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modificar equipo</h5>
                <button type=""button"" class=""close");
            WriteLiteral(@""" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""cuerpoModal""></div>
        </div>
    </div>
</div> <!-- Modal 2-->
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
</div> <!-- Modal 3-->
<div class=""modal fade"" id=""myModal3"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div clas");
            WriteLiteral(@"s=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar dependencia</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""cuerpoModal3""></div>
        </div>
    </div>
</div> <!-- Script modal 1-->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function CrearUnidad() {
            $.ajax({
                method: ""GET"",
                url: ""Unidad/_Create"",
            }).done(function (data) {
                $(""#cuerpoModalInicial"").html(data);
                $(""#myModalInicial"").show();
            });
        }

        function EditarUnidad(numero) {
            $.ajax({
                method: ""GET"",
                url: ""Unidad/_Edit"",
                data: { id: numero }
            }).done(function (data) {
                $(""#cuerpoModal"").html(data);
                $(""#myModal"").show();
            });
        }

        function DetalleUnidad(numero) {
            $.ajax({
                method: ""GET"",
                url: ""Unidad/_Detalle"",
                data: { id: numero }
            }).done(function (data) {
                $(""#cuerpoModal2"").html(data);
                $(""#myModal2"").show();
            });
        }

        function EliminarUnidad(numero) {
            $.ajax({
                method:");
                WriteLiteral(" \"GET\",\n                url: \"Unidad/_Delete\",\n                data: { id: numero }\n            }).done(function (data) {\n                $(\"#cuerpoModal3\").html(data);\n                $(\"#myModal3\").show();\n            });\n        }</script>\n\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2d12b689cd97c6ca689e1f872abaee35fe3f69c14928", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2d12b689cd97c6ca689e1f872abaee35fe3f69c16026", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                        ""lengthMenu"": ""Mostrar _MENU_ registros"",
                        ""zeroRecords"": ""No se encontraron resultados"",
                        ""emptyTable"": ""Ningún dato disponible en esta tabla"",
                        ""info"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
                        ""infoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                        ""infoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
                        ""search"": ""Buscar:"",
                        ""infoThousands"": "","",
                        ""loadingRecords"": ""Cargando..."",
                        ""paginate"": {
                            ""first"": ""Primero"",
                            ""last"": ""Último"",
                            ""next"": ""Si");
                WriteLiteral(@"guiente"",
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
                WriteLiteral(@"                 },
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
                            ""add"": ""Añadir");
                WriteLiteral(@" condición"",
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
                WriteLiteral(@"      ""before"": ""Antes"",
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
                WriteLiteral(@"                    },
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
                                ""_"": ""Constructo");
                WriteLiteral(@"r de búsqueda (%d)""
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
                WriteLiteral(@"                         ""_"": ""$d celdas seleccionadas""
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
        });</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TelefoniaCargas.Models.Unidad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
