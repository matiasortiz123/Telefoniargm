#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Albacea\Views\Albacea\GestionAlbacea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac3abcd1d7abf01f1d61def8c48d8ac84170f753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Albacea_Views_Albacea_GestionAlbacea), @"mvc.1.0.view", @"/Areas/Albacea/Views/Albacea/GestionAlbacea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Albacea/Views/Albacea/GestionAlbacea.cshtml", typeof(AspNetCore.Areas_Albacea_Views_Albacea_GestionAlbacea))]
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
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Albacea\Views\_ViewImports.cshtml"
using modulo_documentacion;

#line default
#line hidden
#line 2 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Albacea\Views\_ViewImports.cshtml"
using modulo_documentacion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac3abcd1d7abf01f1d61def8c48d8ac84170f753", @"/Areas/Albacea/Views/Albacea/GestionAlbacea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e642af60db4166f549ee892d260e06d719b105", @"/Areas/Albacea/Views/_ViewImports.cshtml")]
    public class Areas_Albacea_Views_Albacea_GestionAlbacea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Listado de Albeceas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tablaEscolaridad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Albacea/Albacea/_TablaAlbacea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Commons.TagHelpers.Boxes.BoxTagHelper __Commons_TagHelpers_Boxes_BoxTagHelper;
        private global::Commons.TagHelpers.LoadTagHelper __Commons_TagHelpers_LoadTagHelper;
        private global::Commons.TagHelpers.Boxes.BoxHeaderTagHelper __Commons_TagHelpers_Boxes_BoxHeaderTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Albacea\Views\Albacea\GestionAlbacea.cshtml"
  
    ViewData["Title"] = "ALBACEA 2019";
    ViewData["BackArrow"] = "/Home/Index";

#line default
#line hidden
            BeginContext(88, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(89, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3abcd1d7abf01f1d61def8c48d8ac84170f7535048", async() => {
                BeginContext(107, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(112, 144, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("load", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3abcd1d7abf01f1d61def8c48d8ac84170f7535431", async() => {
                    BeginContext(182, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(191, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3abcd1d7abf01f1d61def8c48d8ac84170f7535838", async() => {
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
                    BeginContext(244, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Commons_TagHelpers_LoadTagHelper = CreateTagHelper<global::Commons.TagHelpers.LoadTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_LoadTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Commons_TagHelpers_LoadTagHelper.Url = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(256, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxTagHelper);
#line 6 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Albacea\Views\Albacea\GestionAlbacea.cshtml"
__Commons_TagHelpers_Boxes_BoxTagHelper.Color = global::Commons.TagHelpers.Boxes.BoxColor.Info;

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
            BeginContext(263, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
