#pragma checksum "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01b17ce6a63a61df7d0b4323e40de8e46464290d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b17ce6a63a61df7d0b4323e40de8e46464290d", @"/Views/Transacciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054575370c3dac1b7426f471dfe3ae7f0c5dfdb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Transacciones>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transacciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#exampleModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NuevaTransaccion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ingreso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Gasto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("navigation", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
  
    int numeropagina = 1;
    int registros = (int)ViewData["NUMEROREGISTROS"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-primary\" id=\"inicio\">\r\n    Bienvenido ");
#nullable restore
#line 12 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
          Write(ViewData["USUARIO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
 if (ViewData["CADENA"] != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
Write(ViewData["CADENA"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
 if (TempData["MENSAJE"] != "" && TempData["MENSAJE"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 29 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
   Write(TempData["MENSAJE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\" id=\"msg\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"jumbotron\">\r\n\r\n\r\n    <ul class=\"list-group list-group-horizontal\">\r\n");
#nullable restore
#line 42 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
         for (int i = 1; i <= registros; i+=4)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b17ce6a63a61df7d0b4323e40de8e46464290d9571", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 49 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                   Write(numeropagina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-posicion", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["posicion"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-posicion", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["posicion"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 52 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
           
            numeropagina += 1;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n\r\n    <div class=\"mb-2\">\r\n        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n            Nueva transaccion\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
            WriteLiteral("        <h4>Aún no tiene ninguna transacción, ¿desea crear ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b17ce6a63a61df7d0b4323e40de8e46464290d13099", async() => {
                WriteLiteral("una?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 68 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"

    }
    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-bordered table-hover"">
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
#line 93 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                     foreach (Transacciones trns in Model)
                    {
                        var tm = "#myModal" + trns.IdTransaccion;
                        var mid = "myModal" + trns.IdTransaccion;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        \r\n                        <td>");
#nullable restore
#line 100 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                       Write(trns.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 101 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                       Write(trns.TipoTransaccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 102 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                       Write(trns.Concepto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 103 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                       Write(trns.FechaTransaccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button type=\"button\" class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 105 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                                                                                                      Write(tm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                Eliminar\r\n                            </button>\r\n                        </td>\r\n\r\n\r\n\r\n                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 3321, "\"", 3330, 1);
#nullable restore
#line 112 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
WriteAttributeValue("", 3326, mid, 3326, 4, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b17ce6a63a61df7d0b4323e40de8e46464290d19122", async() => {
                WriteLiteral("\r\n                                            <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 4353, "\"", 4380, 1);
#nullable restore
#line 124 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
WriteAttributeValue("", 4361, trns.IdTransaccion, 4361, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"idtransaccion\" hidden />\r\n                                            <button type=\"submit\" class=\"btn btn-danger\">Eliminar</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                                        <button type=""button"" class=""btn btn-Primary"" data-dismiss=""modal"">Cerrar</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </tr>
");
#nullable restore
#line 135 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 139 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>






<!-- Modal nueva transacción -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Nueva transacción</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b17ce6a63a61df7d0b4323e40de8e46464290d22946", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <input name=\"IdUsuario\"");
                BeginWriteAttribute("value", " value=\"", 5922, "\"", 5945, 1);
#nullable restore
#line 160 "C:\Users\mario\Documents\0-Master\MoneyGo\MoneyGo\MoneyGo\Views\Transacciones\Index.cshtml"
WriteAttributeValue("", 5930, ViewData["ID"], 5930, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" readonly />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Cantidad: </label>
                        <input type=""number"" name=""Cantidad"" class=""form-control"" /> €
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Tipo de transacción</label>
                        <select name=""TipoTransaccion"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b17ce6a63a61df7d0b4323e40de8e46464290d24310", async() => {
                    WriteLiteral("Ingreso");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b17ce6a63a61df7d0b4323e40de8e46464290d25563", async() => {
                    WriteLiteral("Gasto");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>

                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">Concepto</label>
                        <input name=""Concepto"" class=""form-control"" />
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                    
                        <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        window.setTimeout(function () {
            $(""#inicio"").fadeTo(500, 0).slideUp(500, function () {
                $(this).remove();
            });
        }, 2000);

        window.setTimeout(function () {
            $(""#msg"").fadeTo(500, 0).slideUp(500, function () {
                $(this).remove();
            });
        }, 5000);
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Transacciones>> Html { get; private set; }
    }
}
#pragma warning restore 1591
