#pragma checksum "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff09ed01536a2233464801ef1c3a1172deb3ad4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\_ViewImports.cshtml"
using Fornecedores.UI;

#line default
#line hidden
#line 2 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\_ViewImports.cshtml"
using Fornecedores.UI.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff09ed01536a2233464801ef1c3a1172deb3ad4f", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde5546c9f33fa7386801d3983208b6bf9708f91", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = Model == null ? "Ocorreu um erro" : Model.Mensagem;


#line default
#line hidden
#line 6 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(133, 147, true);
            WriteLiteral("    <div>\r\n        <h2>Opps! Ocorreu um erro, mas não se preucupe. Nosso time será avisado e iremos corrigir o problema em breve</h2>\r\n    </div>\r\n");
            EndContext();
#line 11 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(292, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(301, 22, false);
#line 14 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml"
   Write(Html.Raw(Model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(323, 35, true);
            WriteLiteral("</h1>\r\n    <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(359, 24, false);
#line 15 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml"
                       Write(Html.Raw(Model.Mensagem));

#line default
#line hidden
            EndContext();
            BeginContext(383, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 16 "D:\Meus Documentos\GitHub\EduardoPires\NetCoreMvc\geraldsmon\AppFornecedoresCorp\src\Fornecedores.UI\Views\Shared\Error.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
