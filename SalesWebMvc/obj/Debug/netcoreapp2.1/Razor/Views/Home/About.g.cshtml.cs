#pragma checksum "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773441a40f245bd1ee539cf7cee44913ed01630a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773441a40f245bd1ee539cf7cee44913ed01630a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 22, true);
            WriteLiteral("</h3>\r\n\r\n\r\n<p>Student ");
            EndContext();
            BeginContext(117, 19, false);
#line 8 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
      Write(ViewData["Student"]);

#line default
#line hidden
            EndContext();
            BeginContext(136, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(146, 17, false);
#line 9 "D:\Bruno Serafim\Curso Udemy CSharp Completo 2024\ProjetosCSharp\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(163, 158, true);
            WriteLiteral("</p>\r\n\r\n<address>\r\n    <strong>\r\n        More Information: <a href=\"https://bcserafim.infinityfreeapp.com/index.html\">BCSERAFIM</a>\r\n    </strong>\r\n</address>");
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
