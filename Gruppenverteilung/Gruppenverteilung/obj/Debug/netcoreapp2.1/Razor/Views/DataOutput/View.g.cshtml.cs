#pragma checksum "C:\Users\Denni\Documents\GitHub\Gruppeneinteilung\Gruppenverteilung\Gruppenverteilung\Views\DataOutput\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ddde97c159d769de1b9716ace2149bb2f6fbd59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataOutput_View), @"mvc.1.0.view", @"/Views/DataOutput/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataOutput/View.cshtml", typeof(AspNetCore.Views_DataOutput_View))]
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
#line 1 "C:\Users\Denni\Documents\GitHub\Gruppeneinteilung\Gruppenverteilung\Gruppenverteilung\Views\_ViewImports.cshtml"
using Gruppenverteilung;

#line default
#line hidden
#line 2 "C:\Users\Denni\Documents\GitHub\Gruppeneinteilung\Gruppenverteilung\Gruppenverteilung\Views\_ViewImports.cshtml"
using Gruppenverteilung.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ddde97c159d769de1b9716ace2149bb2f6fbd59", @"/Views/DataOutput/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2924baee82dfda2b34f022fa72a8a5d05db907", @"/Views/_ViewImports.cshtml")]
    public class Views_DataOutput_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gruppenverteilung.Models.DataOutputModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Denni\Documents\GitHub\Gruppeneinteilung\Gruppenverteilung\Gruppenverteilung\Views\DataOutput\View.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 27, true);
            WriteLiteral("\r\n<h2>DataOutputView</h2>\r\n");
            EndContext();
            BeginContext(166, 52, false);
#line 9 "C:\Users\Denni\Documents\GitHub\Gruppeneinteilung\Gruppenverteilung\Gruppenverteilung\Views\DataOutput\View.cshtml"
Write(Html.LabelFor(m => m.GruppenName, Model.GruppenName));

#line default
#line hidden
            EndContext();
            BeginContext(218, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(240, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "C:\Users\Denni\Documents\GitHub\Gruppeneinteilung\Gruppenverteilung\Gruppenverteilung\Views\DataOutput\View.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gruppenverteilung.Models.DataOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591