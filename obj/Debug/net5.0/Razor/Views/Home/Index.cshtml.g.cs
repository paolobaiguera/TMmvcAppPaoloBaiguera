#pragma checksum "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9970c364666810813cc5d138fc74543e1649ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/_ViewImports.cshtml"
using TMmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/_ViewImports.cshtml"
using TMmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9970c364666810813cc5d138fc74543e1649ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec03a9d61d6d3fb45514b989c773357dde3f472", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<TMmvc.Models.IActivity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Elenco Attività</h1>\n    <div class=\".container-fluid\">\n    <table class = \"table\">\n");
#nullable restore
#line 10 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
         foreach(Activity a in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 13 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
               Write(a.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 14 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
               Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td>");
#nullable restore
#line 15 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
               Write(a.State.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\n                <td>");
#nullable restore
#line 16 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
               Write(a.Start.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 17 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
               Write(a.End.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                \n            </tr>\n");
#nullable restore
#line 20 "/Users/paolobaiguera/Desktop/azureacademy/TMmvc/Views/Home/Index.cshtml"
        }       

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        \n    </table>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<TMmvc.Models.IActivity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
