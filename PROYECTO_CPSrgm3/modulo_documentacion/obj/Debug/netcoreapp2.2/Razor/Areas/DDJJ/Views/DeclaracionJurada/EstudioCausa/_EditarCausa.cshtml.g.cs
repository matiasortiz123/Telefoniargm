#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59118b9fae7bb2d3930eaea201a3220ca74979d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DDJJ_Views_DeclaracionJurada_EstudioCausa__EditarCausa), @"mvc.1.0.view", @"/Areas/DDJJ/Views/DeclaracionJurada/EstudioCausa/_EditarCausa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DDJJ/Views/DeclaracionJurada/EstudioCausa/_EditarCausa.cshtml", typeof(AspNetCore.Areas_DDJJ_Views_DeclaracionJurada_EstudioCausa__EditarCausa))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59118b9fae7bb2d3930eaea201a3220ca74979d6", @"/Areas/DDJJ/Views/DeclaracionJurada/EstudioCausa/_EditarCausa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e642af60db4166f549ee892d260e06d719b105", @"/Areas/DDJJ/Views/_ViewImports.cshtml")]
    public class Areas_DDJJ_Views_DeclaracionJurada_EstudioCausa__EditarCausa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<modulo_documentacion.Areas.DDJJ.Models.CausaJudicialDDJJ>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "TipoExpedienteId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_EditarCausa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeclaracionJurada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Documentacion.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(65, 1898, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59118b9fae7bb2d3930eaea201a3220ca74979d67370", async() => {
                BeginContext(170, 164, true);
                WriteLiteral("\n    <div class=\"form-group\">\n        <label for=\"TipoExpedienteId\" class=\"col-sm-2 control-label\">Tipo</label>\n        <div class=\"dropdown col-sm-4\">\n            ");
                EndContext();
                BeginContext(334, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59118b9fae7bb2d3930eaea201a3220ca74979d67926", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Commons_TagHelpers_SelectTagHelper = CreateTagHelper<global::Commons.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_SelectTagHelper);
#line 7 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.TipoExpediente;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 7 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TipoExpedienteID);

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
                BeginContext(466, 196, true);
                WriteLiteral("\n        </div>\n        <label for=\"Caratula\" class=\"col-sm-2 control-label\">Expediente</label>\n        <div class=\"col-sm-4\">\n            <input type=\"text\" class=\"form-control\" name=\"Expediente\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 662, "\"", 687, 1);
#line 11 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
WriteAttributeValue("", 670, Model.Expediente, 670, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(688, 266, true);
                WriteLiteral(@" placeholder=""Nro de Expediente"">
        </div>
    </div>
    <div class=""form-group"">
        <label for=""Caratula"" class=""col-sm-2 control-label"">Caratula</label>
        <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Caratula""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 954, "\"", 977, 1);
#line 17 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
WriteAttributeValue("", 962, Model.Caratula, 962, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(978, 322, true);
                WriteLiteral(@" placeholder=""Caratula del expediente"">
        </div>
    </div>
    <div class=""form-group"">
        <label for=""SituacionJudicial"" id=""SituacionJudicial"" class=""col-sm-2 control-label"">Situacion Judicial</label>
        <div class=""col-sm-4"">
            <input type=""text"" class=""form-control"" name=""SituacionJudicial""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1300, "\"", 1332, 1);
#line 23 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
WriteAttributeValue("", 1308, Model.SituacionJudicial, 1308, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1333, 247, true);
                WriteLiteral(" placeholder=\"Descripcion de la situacion\">\n        </div>\n        <label for=\"Juzgado\"  id=\"Juzgado\"  class=\"col-sm-2 control-label\">Juzgado</label>\n        <div class=\"col-sm-4\">\n            <input type=\"text\" class=\"form-control\" name=\"Juzgado\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1580, "\"", 1602, 1);
#line 27 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
WriteAttributeValue("", 1588, Model.Juzgado, 1588, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1603, 115, true);
                WriteLiteral(" placeholder=\"Juzgado interviniente\">\n        </div>\n    </div>\n    <input type=\"hidden\" name=\"DeclaracionJuradaID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1718, "\"", 1739, 1);
#line 30 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\EstudioCausa\_EditarCausa.cshtml"
WriteAttributeValue("", 1726, ViewBag.DJId, 1726, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1740, 41, true);
                WriteLiteral(" />\n    <div class=\"box-footer\">\n        ");
                EndContext();
                BeginContext(1781, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59118b9fae7bb2d3930eaea201a3220ca74979d614570", async() => {
                    BeginContext(1827, 8, true);
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
                BeginContext(1839, 117, true);
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
            BeginContext(1963, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1964, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59118b9fae7bb2d3930eaea201a3220ca74979d617993", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<modulo_documentacion.Areas.DDJJ.Models.CausaJudicialDDJJ> Html { get; private set; }
    }
}
#pragma warning restore 1591
