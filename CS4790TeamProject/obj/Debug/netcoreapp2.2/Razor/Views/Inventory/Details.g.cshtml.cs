#pragma checksum "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300234bd2349903e43b67efb3710c00185edb4cd"
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
#line 3 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300234bd2349903e43b67efb3710c00185edb4cd", @"/Views/Inventory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70d7d54c44ef77a4a86b82a410f17318020d08d", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CS4790TeamProject.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(130, 125, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Item</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(256, 44, false);
#line 15 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(300, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(362, 40, false);
#line 18 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(402, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(463, 47, false);
#line 21 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(510, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(572, 43, false);
#line 24 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(615, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(676, 45, false);
#line 27 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(721, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(783, 41, false);
#line 30 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(824, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(885, 50, false);
#line 33 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(935, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(997, 46, false);
#line 36 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1104, 46, false);
#line 39 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1212, 42, false);
#line 42 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1315, 42, false);
#line 45 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1419, 38, false);
#line 48 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1518, 45, false);
#line 51 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1625, 41, false);
#line 54 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1727, 47, false);
#line 57 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1836, 43, false);
#line 60 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1940, 50, false);
#line 63 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2052, 46, false);
#line 66 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2098, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2159, 52, false);
#line 69 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2273, 48, false);
#line 72 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2321, 59, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2380, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300234bd2349903e43b67efb3710c00185edb4cd13675", async() => {
                BeginContext(2430, 4, true);
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
#line 79 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
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
            BeginContext(2438, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2446, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300234bd2349903e43b67efb3710c00185edb4cd16018", async() => {
                BeginContext(2498, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "J:\Git Repositories\GeoProth\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Details.cshtml"
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
            BeginContext(2508, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2516, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300234bd2349903e43b67efb3710c00185edb4cd18365", async() => {
                BeginContext(2538, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2554, 10, true);
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
