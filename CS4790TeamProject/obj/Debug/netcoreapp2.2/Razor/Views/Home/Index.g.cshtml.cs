#pragma checksum "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87bf48e62a2ab43829531d0716f5105583cd8ea1"
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
#line 1 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject;

#line default
#line hidden
#line 2 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bf48e62a2ab43829531d0716f5105583cd8ea1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70d7d54c44ef77a4a86b82a410f17318020d08d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 120, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <ul>\r\n        <li class=\"card\" style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 165, "\"", 205, 1);
#line 8 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 172, Url.Action("Index", "Inventory"), 172, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(206, 148, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Inventory</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 354, "\"", 399, 1);
#line 11 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 361, Url.Action("Index", "PurchaseOrders"), 361, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 145, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Orders</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 545, "\"", 584, 1);
#line 14 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 552, Url.Action("Index", "Assembly"), 552, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(585, 148, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Assemble</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\"> \r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 733, "\"", 771, 1);
#line 17 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 740, Url.Action("Index", "Vendors"), 740, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(772, 145, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Vendor</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 917, "\"", 960, 1);
#line 20 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 924, Url.Action("Assemble", "Inventory"), 924, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(961, 145, true);
            WriteLiteral(" style=\"padding:50px;\"><span>Alerts</span></a>\r\n        </li>\r\n        <li class=\"card\"  style=\"margin:10px;\">\r\n            <a class=\"indexItems\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1149, 1);
#line 23 "C:\Users\reddt\source\repos\CS4790-TeamProject\CS4790TeamProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1113, Url.Action("Assemble", "Inventory"), 1113, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1150, 89, true);
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
