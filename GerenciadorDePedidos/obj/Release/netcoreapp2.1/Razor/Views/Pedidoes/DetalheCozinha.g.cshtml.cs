#pragma checksum "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6eaf9957be3d7e1fd38faccfc9b495863e2a466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidoes_DetalheCozinha), @"mvc.1.0.view", @"/Views/Pedidoes/DetalheCozinha.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidoes/DetalheCozinha.cshtml", typeof(AspNetCore.Views_Pedidoes_DetalheCozinha))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eaf9957be3d7e1fd38faccfc9b495863e2a466", @"/Views/Pedidoes/DetalheCozinha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484853d773332855caf0f6989ef353e9428f8f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidoes_DetalheCozinha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GerenciadorDePedidos.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cozinhas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
  
    ViewData["Title"] = "DetalheCozinha";

#line default
#line hidden
            BeginContext(95, 128, true);
            WriteLiteral("\r\n<h2>Detalhe Cozinha</h2>\r\n\r\n<div>\r\n    <h4>Pedido</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(224, 46, false);
#line 14 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(314, 42, false);
#line 17 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 48, false);
#line 20 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(492, 44, false);
#line 23 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayFor(model => model.EstadoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(580, 46, false);
#line 26 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayNameFor(model => model.DataPedido));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 42, false);
#line 29 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayFor(model => model.DataPedido));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(756, 62, false);
#line 32 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayNameFor(model => model.ProdutoIdProdutoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(818, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(862, 70, false);
#line 35 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayFor(model => model.ProdutoIdProdutoNavigation.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(932, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(976, 70, false);
#line 38 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayNameFor(model => model.SolicitanteIdSolicitanteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1090, 84, false);
#line 41 "C:\Users\gui\source\repos\GerenciadorDePedidos\GerenciadorDePedidos\Views\Pedidoes\DetalheCozinha.cshtml"
       Write(Html.DisplayFor(model => model.SolicitanteIdSolicitanteNavigation.EstadoAtendimento));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 53, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    \r\n    ");
            EndContext();
            BeginContext(1227, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec08dd7b061d4d8790dfbcc8481e2378", async() => {
                BeginContext(1252, 14, true);
                WriteLiteral("Voltar à lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1270, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GerenciadorDePedidos.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
