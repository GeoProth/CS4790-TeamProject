#pragma checksum "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f9b5cd90ef5fa588b2341e6b22c59a489ffee0"
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
#line 1 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject;

#line default
#line hidden
#line 2 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f9b5cd90ef5fa588b2341e6b22c59a489ffee0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee5fd99bc547497ff347ecd2ceb83c83045ba09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 120, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <ul>\r\n        <li class=\"card\" style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 165, "\"", 205, 1);
#line 8 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 172, Url.Action("Index", "Inventory"), 172, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(206, 148, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Inventory</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 354, "\"", 397, 1);
#line 11 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 361, Url.Action("Assemble", "Inventory"), 361, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(398, 145, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Orders</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 543, "\"", 586, 1);
#line 14 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 550, Url.Action("Assemble", "Inventory"), 550, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(587, 148, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Assemble</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\"> \r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 735, "\"", 778, 1);
#line 17 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 742, Url.Action("Assemble", "Inventory"), 742, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(779, 145, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Vendor</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 924, "\"", 967, 1);
#line 20 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 931, Url.Action("Assemble", "Inventory"), 931, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(968, 145, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Alerts</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1113, "\"", 1156, 1);
#line 23 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1120, Url.Action("Assemble", "Inventory"), 1120, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1157, 89, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Reports</span></a>\r\n        </li>\r\n    </ul>\r\n    \r\n</div>\r\n");
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
