#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarDocumento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc797e6e2987d1e170f65c53e4f7391bf166b087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DDJJ_Views_DeclaracionJurada_EstudioCausa__EditarDocumento), @"mvc.1.0.view", @"/Areas/DDJJ/Views/DeclaracionJurada/EstudioCausa/_EditarDocumento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DDJJ/Views/DeclaracionJurada/EstudioCausa/_EditarDocumento.cshtml", typeof(AspNetCore.Areas_DDJJ_Views_DeclaracionJurada_EstudioCausa__EditarDocumento))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc797e6e2987d1e170f65c53e4f7391bf166b087", @"/Areas/DDJJ/Views/DeclaracionJurada/EstudioCausa/_EditarDocumento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e642af60db4166f549ee892d260e06d719b105", @"/Areas/DDJJ/Views/_ViewImports.cshtml")]
    public class Areas_DDJJ_Views_DeclaracionJurada_EstudioCausa__EditarDocumento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<modulo_documentacion.Areas.DDJJ.Models.Documentacion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "TipoDocumentoAdjuntoId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_EditarDocumento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeclaracionJurada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Commons.TagHelpers.SelectTagHelper __Commons_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 1266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc797e6e2987d1e170f65c53e4f7391bf166b0876887", async() => {
                BeginContext(170, 161, true);
                WriteLiteral("\n    <div class=\"form-group\">\n        <label for=\"TipoDocumentoAdjuntoId\" class=\"col-sm-2 control-label\">Tipo</label>\n        <div class=\"col-sm-4\">\n            ");
                EndContext();
                BeginContext(331, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc797e6e2987d1e170f65c53e4f7391bf166b0877440", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Commons_TagHelpers_SelectTagHelper = CreateTagHelper<global::Commons.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_SelectTagHelper);
#line 7 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarDocumento.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.TipoDocumentoAdjunto;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 7 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarDocumento.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TipoDocumentoAdjuntoID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(481, 186, true);
                WriteLiteral("\n        </div>\n        <label for=\"Caratula\" class=\"col-sm-2 control-label\">Fojas</label>\n        <div class=\"col-sm-4\">\n            <input type=\"text\" class=\"form-control\" name=\"Fojas\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 667, "\"", 687, 1);
#line 11 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarDocumento.cshtml"
WriteAttributeValue("", 675, Model.Fojas, 675, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(688, 244, true);
                WriteLiteral(">\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <label for=\"Caratula\" class=\"col-sm-2 control-label\">Observaciones</label>\n        <div class=\"col-sm-10\">\n            <input type=\"text\" class=\"form-control\" name=\"Observaciones\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 932, "\"", 960, 1);
#line 17 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarDocumento.cshtml"
WriteAttributeValue("", 940, Model.Observaciones, 940, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(961, 121, true);
                WriteLiteral(" placeholder=\"Observaciones del documento\">\n        </div>\n    </div>\n    <input type=\"hidden\" name=\"DeclaracionJuradaID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1082, "\"", 1103, 1);
#line 20 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarDocumento.cshtml"
WriteAttributeValue("", 1090, ViewBag.DJId, 1090, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1104, 41, true);
                WriteLiteral(" />\n    <div class=\"box-footer\">\n        ");
                EndContext();
                BeginContext(1145, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc797e6e2987d1e170f65c53e4f7391bf166b08712431", async() => {
                    BeginContext(1191, 8, true);
                    WriteLiteral("Cancelar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
                BeginContext(1203, 117, true);
                WriteLiteral("\n        <button type=\"submit\" class=\"btn btn-info pull-right\">Agregar</button>\n    </div>\n    <!-- /.box-footer -->\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<modulo_documentacion.Areas.DDJJ.Models.Documentacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
