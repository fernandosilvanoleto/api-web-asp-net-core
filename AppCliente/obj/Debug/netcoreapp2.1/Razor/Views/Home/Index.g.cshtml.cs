#pragma checksum "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823f73bdd43522c3785ddfa70d7544fba1bdc246"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823f73bdd43522c3785ddfa70d7544fba1bdc246", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c14a035d59a1d0c7dbde02427ac4e2b59569e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClienteModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 239, true);
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <td>#</td>\r\n            <td>#</td>\r\n            <td>Código</td>\r\n            <td>Nome</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 13 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.ListaClientes)
        {

#line default
#line hidden
            BeginContext(325, 61, true);
            WriteLiteral("        <tr>\r\n            <td><button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 386, "\"", 426, 3);
            WriteAttributeValue("", 396, "registrar(", 396, 10, true);
#line 16 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
WriteAttributeValue("", 406, item.Id.ToString(), 406, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 425, ")", 425, 1, true);
            EndWriteAttribute();
            BeginContext(427, 69, true);
            WriteLiteral(">Editar</button></td>\r\n            <td><button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 496, "\"", 534, 3);
            WriteAttributeValue("", 506, "excluir(", 506, 8, true);
#line 17 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
WriteAttributeValue("", 514, item.Id.ToString(), 514, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 533, ")", 533, 1, true);
            EndWriteAttribute();
            BeginContext(535, 40, true);
            WriteLiteral(">Excluir</button></td>\r\n            <td>");
            EndContext();
            BeginContext(576, 18, false);
#line 18 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
           Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(594, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(618, 20, false);
#line 19 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
           Write(item.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(638, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(662, 21, false);
#line 20 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
           Write(item.Email.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(683, 38, true);
            WriteLiteral("</td>\r\n        </tr>                \r\n");
            EndContext();
#line 22 "G:\Programação_Udemy\C#\api-web-asp-net-core\AppCliente\Views\Home\Index.cshtml"
        }        

#line default
#line hidden
            BeginContext(740, 449, true);
            WriteLiteral(@"        </tbody>
    </table>

<button class=""btn btn-block btn-primary"" onclick=""registrar()"">Registrar Cliente</button>

<script>
    function registrar(id) {
        if (id == null) {
            id = """";
        }
        window.location.href = window.location.origin = ""/Home/Registrar/"" + id;
        }
    function excluir(id) {
        window.location.href = window.location.origin = ""/Home/Excluir/"" + id;
        }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClienteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
