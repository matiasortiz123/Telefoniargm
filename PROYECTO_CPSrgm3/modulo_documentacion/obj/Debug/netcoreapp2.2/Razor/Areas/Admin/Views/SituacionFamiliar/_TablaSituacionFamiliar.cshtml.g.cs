#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e7234755b2565827412a4dbfea11d55688bd14a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SituacionFamiliar__TablaSituacionFamiliar), @"mvc.1.0.view", @"/Areas/Admin/Views/SituacionFamiliar/_TablaSituacionFamiliar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SituacionFamiliar/_TablaSituacionFamiliar.cshtml", typeof(AspNetCore.Areas_Admin_Views_SituacionFamiliar__TablaSituacionFamiliar))]
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
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
using Commons.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7234755b2565827412a4dbfea11d55688bd14a", @"/Areas/Admin/Views/SituacionFamiliar/_TablaSituacionFamiliar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbfddb5d17ff57c55b377374de0193b8d8db5ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SituacionFamiliar__TablaSituacionFamiliar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page<modulo_documentacion.Areas.Admin.Models.Basicas.SituacionFamiliar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("update-div", "TablaSituacionFamiliar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Lista de Datos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("confirm", "Este registro ya no podra visualizarse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-update-div", "TablaSituacionFamiliar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Edicion de Situacion Familiar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("function", "editaSituacionFamiliar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/SituacionFamiliar/_Edit/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Nueva Situacion Familiar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("function", "nuevaSituacionLaboral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/SituacionFamiliar/_Create/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(102, 396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a9479", async() => {
                BeginContext(137, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(142, 342, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-search", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a9869", async() => {
                    BeginContext(190, 281, true);
                    WriteLiteral(@"
        <div class=""input-group input-group-sm pull-right"" style=""max-width: 300px;"">
            <a onclick=""nuevaSituacionLaboral()"" class=""btn btn-info btn-sm"">
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
                BeginContext(484, 1, true);
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
            BeginContext(498, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(499, 1302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a12549", async() => {
                BeginContext(522, 200, true);
                WriteLiteral("\n    <table class=\"table table-striped\">\n        <thead>\n            <tr>\n                <th>\n                    Descripcion\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
                EndContext();
#line 22 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
             foreach (var item in Model.Items.OrderBy(x => x.Descripcion))
            {

#line default
#line hidden
                BeginContext(811, 70, true);
                WriteLiteral("                <tr>\n                    <td>\n                        ");
                EndContext();
                BeginContext(882, 46, false);
#line 26 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(928, 76, true);
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
                EndContext();
                BeginContext(1004, 129, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a14212", async() => {
                    BeginContext(1096, 33, true);
                    WriteLiteral("<i class=\"fa fa-file-text-o\"></i>");
                    EndContext();
                }
                );
                __Commons_TagHelpers_AToolipTagHelper = CreateTagHelper<global::Commons.TagHelpers.AToolipTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_AToolipTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1016, "editaSituacionFamiliar(", 1016, 23, true);
#line 29 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
AddHtmlAttributeValue("", 1039, item.Id, 1039, 8, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1047, ")", 1047, 1, true);
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
                BeginContext(1133, 51, true);
                WriteLiteral("\n                        <!--<a onclick=\"Eliminar(\'");
                EndContext();
                BeginContext(1185, 7, false);
#line 30 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
                                             Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1192, 119, true);
                WriteLiteral("\')\" title=\"Eliminar\" class=\"btn btn-info btn-xs btn-danger\"><i class=\"fa fa-trash\"></i></a>-->\n                        ");
                EndContext();
                BeginContext(1311, 385, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a17075", async() => {
                    BeginContext(1611, 81, true);
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
#line 32 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
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
#line 35 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
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
                BeginContext(1696, 49, true);
                WriteLiteral("\n                    </td>\n                </tr>\n");
                EndContext();
#line 41 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
            }

#line default
#line hidden
                BeginContext(1759, 31, true);
                WriteLiteral("        </tbody>\n    </table>\n\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxBodyTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxBodyTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxBodyTagHelper);
#line 12 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
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
            BeginContext(1801, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1802, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-footer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a22808", async() => {
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
            BeginContext(1868, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1869, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a24041", async() => {
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
#line 47 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
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
            BeginContext(2013, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2014, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7234755b2565827412a4dbfea11d55688bd14a26111", async() => {
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
#line 48 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\SituacionFamiliar\_TablaSituacionFamiliar.cshtml"
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
            BeginContext(2154, 138, true);
            WriteLiteral("\n<!--<modal title=\"Eliminar Situacion Familiar\" function=\"Eliminar\" load-url=\"/Admin/SituacionFamiliar/_Delete/\" size=\"Medium\"></modal>-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page<modulo_documentacion.Areas.Admin.Models.Basicas.SituacionFamiliar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
