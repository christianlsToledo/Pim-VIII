#pragma checksum "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\NovaTarefa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa77167e0b1bead0d6f85fb35cd620a5c674771c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NovaTarefa), @"mvc.1.0.view", @"/Views/Home/NovaTarefa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NovaTarefa.cshtml", typeof(AspNetCore.Views_Home_NovaTarefa))]
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
#line 1 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\NovaTarefa.cshtml"
using ColegioPimIII.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa77167e0b1bead0d6f85fb35cd620a5c674771c", @"/Views/Home/NovaTarefa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90fcad22f67efcbe7fa87ac94f5654c0a6455183", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NovaTarefa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MdlTarefas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 27, true);
            WriteLiteral("<h3>Nova tarefa</h3>\r\n\r\n<p>");
            EndContext();
            BeginContext(76, 14, false);
#line 5 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\NovaTarefa.cshtml"
Write(Model.idTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(90, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(100, 16, false);
#line 6 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\NovaTarefa.cshtml"
Write(Model.nomeTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(116, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(126, 18, false);
#line 7 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\NovaTarefa.cshtml"
Write(Model.dataPostagem);

#line default
#line hidden
            EndContext();
            BeginContext(144, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(154, 17, false);
#line 8 "C:\Users\Familia\Desktop\Unip\Pim VIII\Programa\ColegioPimIII\Views\Home\NovaTarefa.cshtml"
Write(Model.dataEntrega);

#line default
#line hidden
            EndContext();
            BeginContext(171, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MdlTarefas> Html { get; private set; }
    }
}
#pragma warning restore 1591
