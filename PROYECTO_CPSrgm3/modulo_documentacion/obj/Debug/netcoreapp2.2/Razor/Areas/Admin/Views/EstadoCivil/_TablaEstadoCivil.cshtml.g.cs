#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EstadoCivil__TablaEstadoCivil), @"mvc.1.0.view", @"/Areas/Admin/Views/EstadoCivil/_TablaEstadoCivil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/EstadoCivil/_TablaEstadoCivil.cshtml", typeof(AspNetCore.Areas_Admin_Views_EstadoCivil__TablaEstadoCivil))]
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
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\_ViewImports.cshtml"
using modulo_documentacion;

#line default
#line hidden
#line 2 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\_ViewImports.cshtml"
using modulo_documentacion.Models;

#line default
#line hidden
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
using Commons.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee50199099feeb84d40dd7e4d8aec8d3c7b0294b", @"/Areas/Admin/Views/EstadoCivil/_TablaEstadoCivil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbfddb5d17ff57c55b377374de0193b8d8db5ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EstadoCivil__TablaEstadoCivil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page<modulo_documentacion.Areas.Admin.Models.Basicas.EstadoCivil>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("update-div", "TablaEstadoCivil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Lista de Datos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("confirm", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-update-div", "TablaEstadoCivil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Edicion de Estado Civil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("function", "editaEstadoCivil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/EstadoCivil/_Edit/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Nuevo Estado Civil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("function", "NuevoEstadoCivil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/EstadoCivil/_Create/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Commons.TagHelpers.Boxes.BoxSearchTagHelper __Commons_TagHelpers_Boxes_BoxSearchTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxBodyTagHelper __Commons_TagHelpers_Boxes_BoxBodyTagHelper;
        private global::Commons.TagHelpers.AToolipTagHelper __Commons_TagHelpers_AToolipTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Commons.TagHelpers.AConfirmTagHelper __Commons_TagHelpers_AConfirmTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxFooterTagHelper __Commons_TagHelpers_Boxes_BoxFooterTagHelper;
        private global::Commons.TagHelpers.ModalTagHelper __Commons_TagHelpers_ModalTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b9291", async() => {
                BeginContext(131, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(136, 331, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-search", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b9681", async() => {
                    BeginContext(178, 276, true);
                    WriteLiteral(@"
        <div class=""input-group input-group-sm pull-right"" style=""max-width: 300px;"">
            <a onclick=""NuevoEstadoCivil()"" class=""btn btn-info btn-sm"">
                <i class=""fa fa-plus""><span class=""hidden-xs""> Nuevo</span></i>
            </a>
        </div>
    ");
                    EndContext();
                }
                );
                __Commons_TagHelpers_Boxes_BoxSearchTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxSearchTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxSearchTagHelper);
                __Commons_TagHelpers_Boxes_BoxSearchTagHelper.PagesDiv = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(467, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxHeaderTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxHeaderTagHelper);
            __Commons_TagHelpers_Boxes_BoxHeaderTagHelper.Title = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(482, 1337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b12356", async() => {
                BeginContext(505, 279, true);
                WriteLiteral(@"
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>
                    Descripción
                </th>
                <th>
                    Editar/Eliminar
                </th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 25 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
             foreach (var item in Model.Items.OrderBy(x => x.Descripcion))
            {

#line default
#line hidden
                BeginContext(873, 70, true);
                WriteLiteral("                <tr>\n                    <td>\n                        ");
                EndContext();
                BeginContext(944, 46, false);
#line 29 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(990, 76, true);
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
                EndContext();
                BeginContext(1066, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b14065", async() => {
                    BeginContext(1152, 33, true);
                    WriteLiteral("<i class=\"fa fa-file-text-o\"></i>");
                    EndContext();
                }
                );
                __Commons_TagHelpers_AToolipTagHelper = CreateTagHelper<global::Commons.TagHelpers.AToolipTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_AToolipTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1078, "editaEstadoCivil(", 1078, 17, true);
#line 32 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
AddHtmlAttributeValue("", 1095, item.Id, 1095, 8, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1103, ")", 1103, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Commons_TagHelpers_AToolipTagHelper.Title = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1189, 51, true);
                WriteLiteral("\n                        <!--<a onclick=\"Eliminar(\'");
                EndContext();
                BeginContext(1241, 7, false);
#line 33 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
                                             Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1248, 119, true);
                WriteLiteral("\')\" title=\"Eliminar\" class=\"btn btn-info btn-xs btn-danger\"><i class=\"fa fa-trash\"></i></a>-->\n                        ");
                EndContext();
                BeginContext(1367, 347, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b16898", async() => {
                    BeginContext(1629, 81, true);
                    WriteLiteral("\n                            <i class=\"fa fa-trash\"></i>\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Commons_TagHelpers_AToolipTagHelper = CreateTagHelper<global::Commons.TagHelpers.AToolipTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_AToolipTagHelper);
                __Commons_TagHelpers_AConfirmTagHelper = CreateTagHelper<global::Commons.TagHelpers.AConfirmTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_AConfirmTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 35 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
                             WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Commons_TagHelpers_AToolipTagHelper.Title = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Commons_TagHelpers_AConfirmTagHelper.ConfirmText = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 38 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
__Commons_TagHelpers_AConfirmTagHelper.Color = global::Commons.TagHelpers.UiColor.Danger;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("confirm-icon", __Commons_TagHelpers_AConfirmTagHelper.Color, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1714, 49, true);
                WriteLiteral("\n                    </td>\n                </tr>\n");
                EndContext();
#line 44 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
            }

#line default
#line hidden
                BeginContext(1777, 31, true);
                WriteLiteral("        </tbody>\n    </table>\n\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxBodyTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxBodyTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxBodyTagHelper);
#line 12 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
__Commons_TagHelpers_Boxes_BoxBodyTagHelper.Table = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("table", __Commons_TagHelpers_Boxes_BoxBodyTagHelper.Table, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1819, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1820, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-footer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b22583", async() => {
            }
            );
            __Commons_TagHelpers_Boxes_BoxFooterTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxFooterTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxFooterTagHelper);
            __Commons_TagHelpers_Boxes_BoxFooterTagHelper.PagesDiv = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1880, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1881, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b23816", async() => {
            }
            );
            __Commons_TagHelpers_ModalTagHelper = CreateTagHelper<global::Commons.TagHelpers.ModalTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_ModalTagHelper);
            __Commons_TagHelpers_ModalTagHelper.Title = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Commons_TagHelpers_ModalTagHelper.Function = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Commons_TagHelpers_ModalTagHelper.Url = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 50 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
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
            BeginContext(2007, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2008, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50199099feeb84d40dd7e4d8aec8d3c7b0294b25874", async() => {
            }
            );
            __Commons_TagHelpers_ModalTagHelper = CreateTagHelper<global::Commons.TagHelpers.ModalTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_ModalTagHelper);
            __Commons_TagHelpers_ModalTagHelper.Title = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Commons_TagHelpers_ModalTagHelper.Function = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Commons_TagHelpers_ModalTagHelper.Url = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#line 51 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\EstadoCivil\_TablaEstadoCivil.cshtml"
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
            BeginContext(2131, 127, true);
            WriteLiteral("\n<!--<modal title=\"Eliminar Estado Civil\" function=\"Eliminar\" load-url=\"/Admin/EstadoCivil/_Delete/\" size=\"Medium\"></modal>-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page<modulo_documentacion.Areas.Admin.Models.Basicas.EstadoCivil>> Html { get; private set; }
    }
}
#pragma warning restore 1591
