#pragma checksum "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73bd6d3232c4d4be5fb187d53fa871e7328d35dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Delete), @"mvc.1.0.view", @"/Views/Inventory/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/Delete.cshtml", typeof(AspNetCore.Views_Inventory_Delete))]
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
#line 1 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject;

#line default
#line hidden
#line 2 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73bd6d3232c4d4be5fb187d53fa871e7328d35dd", @"/Views/Inventory/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70d7d54c44ef77a4a86b82a410f17318020d08d", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CS4790TeamProject.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 174, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Item</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(304, 44, false);
#line 16 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(348, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(412, 40, false);
#line 19 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(452, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(515, 47, false);
#line 22 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(562, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(626, 43, false);
#line 25 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(669, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(732, 45, false);
#line 28 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(777, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(841, 41, false);
#line 31 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(882, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(945, 50, false);
#line 34 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(995, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1059, 46, false);
#line 37 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1168, 46, false);
#line 40 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1278, 42, false);
#line 43 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1383, 42, false);
#line 46 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1489, 38, false);
#line 49 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1590, 45, false);
#line 52 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1699, 41, false);
#line 55 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1803, 47, false);
#line 58 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1914, 43, false);
#line 61 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2020, 50, false);
#line 64 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2070, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2134, 46, false);
#line 67 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2180, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2243, 52, false);
#line 70 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2359, 48, false);
#line 73 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2407, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2445, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73bd6d3232c4d4be5fb187d53fa871e7328d35dd14443", async() => {
                BeginContext(2471, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2481, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73bd6d3232c4d4be5fb187d53fa871e7328d35dd14836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2521, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2604, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73bd6d3232c4d4be5fb187d53fa871e7328d35dd16775", async() => {
                    BeginContext(2626, 12, true);
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
                BeginContext(2642, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2655, 10, true);
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
