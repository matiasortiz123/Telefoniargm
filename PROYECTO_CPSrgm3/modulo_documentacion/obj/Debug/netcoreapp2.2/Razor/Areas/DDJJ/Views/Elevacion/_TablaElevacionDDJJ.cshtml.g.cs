#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ca020e9ef1f5110850a3195569409c6b8bbdeb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DDJJ_Views_Elevacion__TablaElevacionDDJJ), @"mvc.1.0.view", @"/Areas/DDJJ/Views/Elevacion/_TablaElevacionDDJJ.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DDJJ/Views/Elevacion/_TablaElevacionDDJJ.cshtml", typeof(AspNetCore.Areas_DDJJ_Views_Elevacion__TablaElevacionDDJJ))]
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
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\_ViewImports.cshtml"
using modulo_documentacion;

#line default
#line hidden
#line 2 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\_ViewImports.cshtml"
using modulo_documentacion.Models;

#line default
#line hidden
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
using Commons.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ca020e9ef1f5110850a3195569409c6b8bbdeb2", @"/Areas/DDJJ/Views/Elevacion/_TablaElevacionDDJJ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e642af60db4166f549ee892d260e06d719b105", @"/Areas/DDJJ/Views/_ViewImports.cshtml")]
    public class Areas_DDJJ_Views_Elevacion__TablaElevacionDDJJ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<modulo_documentacion.Areas.DDJJ.ViewModels.ElevacionDDJJViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Estado de su ultima Declaracion Jurada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("checkbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Seleccionada"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_domicilio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_CrearDomicilio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeclaracionJurada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxHeaderTagHelper __Commons_TagHelpers_Boxes_BoxHeaderTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxBodyTagHelper __Commons_TagHelpers_Boxes_BoxBodyTagHelper;
        private global::Commons.TagHelpers.AspCheckboxTagHelper __Commons_TagHelpers_AspCheckboxTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(103, 1714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca020e9ef1f5110850a3195569409c6b8bbdeb26692", async() => {
                BeginContext(207, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(212, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca020e9ef1f5110850a3195569409c6b8bbdeb27075", async() => {
                    BeginContext(271, 5, true);
                    WriteLiteral("\n    ");
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
                BeginContext(289, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(294, 1515, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca020e9ef1f5110850a3195569409c6b8bbdeb28512", async() => {
                    BeginContext(317, 437, true);
                    WriteLiteral(@"

        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Sel.</th>
                    <th>Unidad</th>
                    <th>Grado</th>
                    <th>Titular</th>
                    <th>Fecha</th>
                    <th>Estado</th>
                    <th>Motivo</th>
                    <th>Descarga</th>
                </tr>
            </thead>
            <tbody>
");
                    EndContext();
#line 23 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                    BeginContext(817, 53, true);
                    WriteLiteral("                    <tr>\n                        <td>");
                    EndContext();
                    BeginContext(870, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ca020e9ef1f5110850a3195569409c6b8bbdeb29807", async() => {
                    }
                    );
                    __Commons_TagHelpers_AspCheckboxTagHelper = CreateTagHelper<global::Commons.TagHelpers.AspCheckboxTagHelper>();
                    __tagHelperExecutionContext.Add(__Commons_TagHelpers_AspCheckboxTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    BeginWriteTagHelperAttribute();
#line 26 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
                                           WriteLiteral(item.Seleccionada);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Commons_TagHelpers_AspCheckboxTagHelper.Id = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("id", __Commons_TagHelpers_AspCheckboxTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(939, 117, true);
                    WriteLiteral("</td>\n                        <td>Unidad Nro 1 </td>\n                        <td>SM</td>\n                        <td>");
                    EndContext();
                    BeginContext(1057, 42, false);
#line 29 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Titular));

#line default
#line hidden
                    EndContext();
                    BeginContext(1099, 196, true);
                    WriteLiteral("</td>\n                        <td>Fecha</td>\n                        <td>Estado</td>\n                        <td>Motivo</td>\n                        <td>Descarga</td>\n                        <td>\n");
                    EndContext();
                    BeginContext(1610, 71, true);
                    WriteLiteral("                        </td>\n                        <td class=\"hide\">");
                    EndContext();
                    BeginContext(1682, 24, false);
#line 38 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
                                    Write(item.DeclaracionJuradaID);

#line default
#line hidden
                    EndContext();
                    BeginContext(1706, 32, true);
                    WriteLiteral("</td>\n                    </tr>\n");
                    EndContext();
#line 40 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
                }

#line default
#line hidden
                    BeginContext(1756, 42, true);
                    WriteLiteral("            </tbody>\n        </table>\n    ");
                    EndContext();
                }
                );
                __Commons_TagHelpers_Boxes_BoxBodyTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxBodyTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxBodyTagHelper);
#line 7 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\Elevacion\_TablaElevacionDDJJ.cshtml"
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
                BeginContext(1809, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<modulo_documentacion.Areas.DDJJ.ViewModels.ElevacionDDJJViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
