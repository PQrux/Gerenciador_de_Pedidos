#pragma checksum "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e40ee7c4196cc3ad134948c3128504a0550a764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidoes_Copas), @"mvc.1.0.view", @"/Views/Pedidoes/Copas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidoes/Copas.cshtml", typeof(AspNetCore.Views_Pedidoes_Copas))]
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
#line 1 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\_ViewImports.cshtml"
using GerenciadorDePedidos;

#line default
#line hidden
#line 2 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\_ViewImports.cshtml"
using GerenciadorDePedidos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e40ee7c4196cc3ad134948c3128504a0550a764", @"/Views/Pedidoes/Copas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484853d773332855caf0f6989ef353e9428f8f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidoes_Copas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorDePedidos.Models.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalheCopa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
  
    ViewData["Title"] = "Copas";
    int i = 0;

#line default
#line hidden
            BeginContext(115, 103, true);
            WriteLiteral("\r\n<h2>Copa</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(219, 44, false);
#line 14 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPedido));

#line default
#line hidden
            EndContext();
            BeginContext(263, 180, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Solicitante\r\n            </th>\r\n            <th>\r\n                Mesa\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(444, 46, false);
#line 23 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(490, 126, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Estado do Pedido\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(617, 46, false);
#line 29 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
           Write(Html.DisplayNameFor(model => model.DataPedido));

#line default
#line hidden
            EndContext();
            BeginContext(663, 232, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Nome do Produto\r\n            </th>\r\n            <th>\r\n                Estado de Atendimento\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
         foreach (var item in Model)
      {

#line default
#line hidden
            BeginContext(942, 72, true);
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1015, 43, false);
#line 45 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1138, 85, false);
#line 48 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SolicitanteIdSolicitanteNavigation.NomeSolicitante));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1303, 80, false);
#line 51 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SolicitanteIdSolicitanteNavigation.MesaIdMesa));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1463, 45, false);
#line 54 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1588, 47, false);
#line 57 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EstadoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1715, 45, false);
#line 60 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1760, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1840, 73, false);
#line 63 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProdutoIdProdutoNavigation.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1993, 87, false);
#line 66 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SolicitanteIdSolicitanteNavigation.EstadoAtendimento));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2159, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4605404000c49f89483d3506a4c1949", async() => {
                BeginContext(2217, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
                                                      WriteLiteral(item.IdPedido);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2229, 136, true);
            WriteLiteral(" |\r\n                        <!--<a asp-action=\"Delete\" asp-route-id=\"\">Delete</a>-->\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 73 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\Copas.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(2394, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorDePedidos.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591