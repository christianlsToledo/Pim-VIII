#pragma checksum "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\EditaLista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ac4ea12fd33336377da4ad8162a3a39a6502ef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditaLista), @"mvc.1.0.view", @"/Views/Home/EditaLista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditaLista.cshtml", typeof(AspNetCore.Views_Home_EditaLista))]
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
#line 1 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\_ViewImports.cshtml"
using ColegioPimIII;

#line default
#line hidden
#line 2 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\_ViewImports.cshtml"
using ColegioPimIII.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac4ea12fd33336377da4ad8162a3a39a6502ef3", @"/Views/Home/EditaLista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90fcad22f67efcbe7fa87ac94f5654c0a6455183", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditaLista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\EditaLista.cshtml"
  
    ViewData["Title"] = "Edita Lista";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(52, 22, false);
#line 4 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\EditaLista.cshtml"
Write(ViewData["tblTarefas"]);

#line default
#line hidden
            EndContext();
            BeginContext(74, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(86, 19, false);
#line 5 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\EditaLista.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 45, true);
            WriteLiteral("</h3>\r\n<h3>Edi????o de tarefas cadastradas</h3>");
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
