#pragma checksum "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\Planes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a9f1de4a27cbd212b29086988531de5d93c73b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Planes_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Planes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Planes/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Planes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a9f1de4a27cbd212b29086988531de5d93c73b", @"/Areas/Admin/Views/Planes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbfddb5d17ff57c55b377374de0193b8d8db5ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Planes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tablaEquipos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-url", "/Admin/Planes/_ListadoDePlanes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\Planes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(85, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a9f1de4a27cbd212b29086988531de5d93c73b4396", async() => {
                BeginContext(104, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(109, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("load", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a9f1de4a27cbd212b29086988531de5d93c73b4778", async() => {
                    BeginContext(175, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Commons_TagHelpers_LoadTagHelper = CreateTagHelper<global::Commons.TagHelpers.LoadTagHelper>();
                __tagHelperExecutionContext.Add(__Commons_TagHelpers_LoadTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Commons_TagHelpers_LoadTagHelper.Url = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(187, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxTagHelper);
#line 7 "C:\Users\user\Desktop\PROYECTO_CPSrgm3\modulo_documentacion\Areas\Admin\Views\Planes\Index.cshtml"
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
