#pragma checksum "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4a39ae5e79bb53e0a42e5de90eb1ca0d080f5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Details), @"mvc.1.0.view", @"/Views/Inventory/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/Details.cshtml", typeof(AspNetCore.Views_Inventory_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a39ae5e79bb53e0a42e5de90eb1ca0d080f5ce", @"/Views/Inventory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee5fd99bc547497ff347ecd2ceb83c83045ba09", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CS4790TeamProject.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Item</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(258, 44, false);
#line 15 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(302, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(366, 40, false);
#line 18 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(406, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(469, 47, false);
#line 21 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(516, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(580, 43, false);
#line 24 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(623, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(686, 45, false);
#line 27 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(731, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(795, 41, false);
#line 30 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(836, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(899, 50, false);
#line 33 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(949, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1013, 46, false);
#line 36 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1122, 46, false);
#line 39 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1232, 42, false);
#line 42 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1337, 42, false);
#line 45 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1443, 38, false);
#line 48 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1544, 45, false);
#line 51 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1653, 41, false);
#line 54 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1757, 47, false);
#line 57 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1868, 43, false);
#line 60 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1974, 50, false);
#line 63 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2088, 46, false);
#line 66 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2197, 52, false);
#line 69 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2249, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2313, 48, false);
#line 72 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2361, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2408, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4a39ae5e79bb53e0a42e5de90eb1ca0d080f5ce13221", async() => {
                BeginContext(2458, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
                           WriteLiteral(Model.ItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2466, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2474, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4a39ae5e79bb53e0a42e5de90eb1ca0d080f5ce15564", async() => {
                BeginContext(2496, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2512, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CS4790TeamProject.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591