#pragma checksum "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5981254f7609a32690aa664305c3733878f1b901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Excluir), @"mvc.1.0.view", @"/Views/Home/Excluir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Excluir.cshtml", typeof(AspNetCore.Views_Home_Excluir))]
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
#line 1 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\_ViewImports.cshtml"
using AppCliente;

#line default
#line hidden
#line 2 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\_ViewImports.cshtml"
using AppCliente.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5981254f7609a32690aa664305c3733878f1b901", @"/Views/Home/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c14a035d59a1d0c7dbde02427ac4e2b59569e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Excluir.cshtml"
  
    ViewData["Title"] = "Excluir";

#line default
#line hidden
            BeginContext(45, 371, true);
            WriteLiteral(@"
<h2>Excluir Cliente</h2>

<h3>Deseja realmente excluir o Cliente selecionado?</h3>
<button class=""btn btn-danger"" onclick=""Excluir(1)"">Sim</button>
<button class=""btn btn-default"" onclick=""Excluir(0)"">Não</button>

<script>
    function Excluir(id) {
        if (id == 1) {
            window.location.href = window.location.origin = ""/Home/ExcluirCliente/"" + ");
            EndContext();
            BeginContext(417, 22, false);
#line 15 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Excluir.cshtml"
                                                                                 Write(ViewData["Cliente_Id"]);

#line default
#line hidden
            EndContext();
            BeginContext(439, 126, true);
            WriteLiteral(";\r\n        } else {\r\n            window.location.href = window.location.origin = \"/Home/Index\";\r\n        }\r\n    }\r\n</script>\r\n");
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