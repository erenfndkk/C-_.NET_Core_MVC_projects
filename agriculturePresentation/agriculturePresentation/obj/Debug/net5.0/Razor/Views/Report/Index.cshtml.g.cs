#pragma checksum "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ddf93cc4038e6a3fd7965e1008b8901b3f470c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Index), @"mvc.1.0.view", @"/Views/Report/Index.cshtml")]
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
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\_ViewImports.cshtml"
using agriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\_ViewImports.cshtml"
using agriculturePresentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ddf93cc4038e6a3fd7965e1008b8901b3f470c", @"/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a8b9f500f20bb3a6e489280d80bfc717cf9691", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Report\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Excel Raporları</h1>
<br />
<div class=""form-control"">
<a href=""/Report/StaticReport/"" class=""btn btn-outline-info"">Static Rapor</a>
</div>
<br />
<div class=""form-control"">
<a href=""/Report/ContactReport/"" class=""btn btn-outline-primary"">Mesaj Rapor</a>
</div>
<br />
<div class=""form-control"">
<a href=""/Report/AnnouncementReport/"" class=""btn btn-outline-info"">Duyuru Rapor</a>

</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591