#pragma checksum "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\_VerHistorial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56b8d8ac5fcfc2a565b7d68eaf4074d0fe94635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DDJJ_Views_DeclaracionJurada__VerHistorial), @"mvc.1.0.view", @"/Areas/DDJJ/Views/DeclaracionJurada/_VerHistorial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DDJJ/Views/DeclaracionJurada/_VerHistorial.cshtml", typeof(AspNetCore.Areas_DDJJ_Views_DeclaracionJurada__VerHistorial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56b8d8ac5fcfc2a565b7d68eaf4074d0fe94635", @"/Areas/DDJJ/Views/DeclaracionJurada/_VerHistorial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e642af60db4166f549ee892d260e06d719b105", @"/Areas/DDJJ/Views/_ViewImports.cshtml")]
    public class Areas_DDJJ_Views_DeclaracionJurada__VerHistorial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<modulo_documentacion.Areas.DDJJ.Models.BitacoraDDJJ>>
    {
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
        private global::Commons.TagHelpers.Boxes.BoxBodyTagHelper __Commons_TagHelpers_Boxes_BoxBodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 682, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("box-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56b8d8ac5fcfc2a565b7d68eaf4074d0fe946353652", async() => {
                BeginContext(89, 265, true);
                WriteLiteral(@"
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>
                    Fecha
                </th>
                <th>
                    Detalle
                </th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 16 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\_VerHistorial.cshtml"
             foreach (var item in Model.OrderBy(x => x.FechaHora))
            {

#line default
#line hidden
                BeginContext(435, 70, true);
                WriteLiteral("                <tr>\n                    <td>\n                        ");
                EndContext();
                BeginContext(506, 14, false);
#line 20 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\_VerHistorial.cshtml"
                   Write(item.FechaHora);

#line default
#line hidden
                EndContext();
                BeginContext(520, 76, true);
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
                EndContext();
                BeginContext(597, 46, false);
#line 23 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\_VerHistorial.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(643, 49, true);
                WriteLiteral("\n                    </td>\n                </tr>\n");
                EndContext();
#line 26 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\_VerHistorial.cshtml"
            }

#line default
#line hidden
                BeginContext(706, 31, true);
                WriteLiteral("        </tbody>\n    </table>\n\n");
                EndContext();
            }
            );
            __Commons_TagHelpers_Boxes_BoxBodyTagHelper = CreateTagHelper<global::Commons.TagHelpers.Boxes.BoxBodyTagHelper>();
            __tagHelperExecutionContext.Add(__Commons_TagHelpers_Boxes_BoxBodyTagHelper);
#line 3 "C:\Users\CPS-DLLO#11\Desktop\RGMNUEVO\Telefonia-RGM-main\Telefonia-RGM-main\PROYECTO_CPSrgm3\modulo_documentacion\Areas\DDJJ\Views\DeclaracionJurada\_VerHistorial.cshtml"
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
            BeginContext(748, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<modulo_documentacion.Areas.DDJJ.Models.BitacoraDDJJ>> Html { get; private set; }
    }
}
#pragma warning restore 1591
