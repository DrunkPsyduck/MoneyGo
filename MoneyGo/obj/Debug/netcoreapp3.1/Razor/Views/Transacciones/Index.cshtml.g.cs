#pragma checksum "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5682c54bc927019fa418da872bcbe990a753e22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacciones_Index), @"mvc.1.0.view", @"/Views/Transacciones/Index.cshtml")]
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
#line 1 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\_ViewImports.cshtml"
using MoneyGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\_ViewImports.cshtml"
using MoneyGo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5682c54bc927019fa418da872bcbe990a753e22", @"/Views/Transacciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054575370c3dac1b7426f471dfe3ae7f0c5dfdb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Transacciones>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NuevaTransaccion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transacciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("navigation", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"alert alert-primary\">\r\n    Bienvenido ");
#nullable restore
#line 7 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
          Write(ViewData["USUARIO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(",  ");
#nullable restore
#line 7 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                                 Write(ViewData["NOMBRE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
 if (ViewData["CADENA"] != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
Write(ViewData["CADENA"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
 if (TempData["MENSAJE"] != "" && TempData["MENSAJE"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 24 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
   Write(TempData["MENSAJE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 32 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"jumbotron\">\r\n        <h4>Aún no tiene ninguna transacción, ¿desea crear ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5682c54bc927019fa418da872bcbe990a753e227159", async() => {
                WriteLiteral("una?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5682c54bc927019fa418da872bcbe990a753e228756", async() => {
                WriteLiteral("Nueva transaccion");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                                                                      WriteLiteral(ViewData["USUARIO"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>
                    Cantidad
                </th>
                <th>
                    Tipo de ingreso
                </th>
                <th>
                    Concepto
                </th>
                <th>
                    Fecha
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 60 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
             foreach (Transacciones trns in Model)
            {
                var tm = "#myModal" + trns.IdTransaccion;
                var mid = "myModal" + trns.IdTransaccion;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                   Write(trns.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                   Write(trns.TipoTransaccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                   Write(trns.Concepto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                   Write(trns.FechaTransaccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 71 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                                                                                                  Write(tm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            Eliminar\r\n                        </button>\r\n                    </td>\r\n\r\n\r\n\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2333, "\"", 2342, 1);
#nullable restore
#line 78 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
WriteAttributeValue("", 2338, mid, 2338, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <button type=""button"" style=""float: left;"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times; Cerrar</button>
                                    <h4 class=""modal-title"" id=""myModalLabel"">Confirmar eliminación</h4>
                                </div>
                                <div class=""modal-body"">
                                    ¿Seguro que quiere eliminar esta transacción? Una vez eliminada no se podrá recuperar.
                                </div>
                                <div class=""modal-footer"">

                                    ");
#nullable restore
#line 90 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                               Write(Html.ActionLink("Delete", "Delete", new { idtransaccion = trns.IdTransaccion }, new { _class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <button type=""button"" class=""btn btn-Primary"" data-dismiss=""modal"">Cerrar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </tr>
");
#nullable restore
#line 97 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 100 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Transacciones>> Html { get; private set; }
    }
}
#pragma warning restore 1591
