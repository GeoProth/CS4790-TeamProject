#pragma checksum "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fce976304f870e9f17df5848ae580011d75d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Index), @"mvc.1.0.view", @"/Views/Inventory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/Index.cshtml", typeof(AspNetCore.Views_Inventory_Index))]
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
#line 1 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject;

#line default
#line hidden
#line 2 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fce976304f870e9f17df5848ae580011d75d3b", @"/Views/Inventory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee5fd99bc547497ff347ecd2ceb83c83045ba09", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CS4790TeamProject.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 21, true);
            WriteLiteral("\r\n<br />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(72, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fce976304f870e9f17df5848ae580011d75d3b4539", async() => {
                BeginContext(95, 57, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\" style=\"font-size:36px;\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(224, 696, true);
            WriteLiteral(@"
<!-- Nav tabs -->
<ul class=""nav nav-pills"" role=""tablist"" style=""font-weight:bold;"">
    <li><a class=""nav-link active"" href=""#all_tab"" role=""tab"" data-toggle=""tab"">All</a></li>
    <li><a class=""nav-link"" href=""#reorder_tab"" role=""tab"" data-toggle=""tab"">To Reorder</a></li>
    <li><a class=""nav-link"" href=""#assemblies_tab"" role=""tab"" data-toggle=""tab"">Assemblies</a></li>
</ul>

<!-- Tab panes -->
<div class=""tab-content"">
    <div class=""tab-pane active"" id=""all_tab"">
        <br />
        <table id=""table_inventory"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(921, 44, false);
#line 27 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(965, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1045, 47, false);
#line 30 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 80, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th >\r\n                        ");
            EndContext();
            BeginContext(1173, 45, false);
#line 33 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1298, 50, false);
#line 36 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 80, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th >\r\n                        ");
            EndContext();
            BeginContext(1429, 46, false);
#line 39 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1555, 42, false);
#line 42 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1677, 45, false);
#line 45 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1802, 47, false);
#line 48 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1929, 50, false);
#line 51 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2059, 52, false);
#line 54 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2302, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2387, 43, false);
#line 64 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(2430, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2522, 46, false);
#line 67 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2568, 92, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td >\r\n                            ");
            EndContext();
            BeginContext(2661, 44, false);
#line 70 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2797, 49, false);
#line 73 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(2846, 92, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td >\r\n                            ");
            EndContext();
            BeginContext(2939, 45, false);
#line 76 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(2984, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3076, 41, false);
#line 79 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(3117, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3209, 44, false);
#line 82 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(3253, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3345, 46, false);
#line 85 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(3391, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3483, 49, false);
#line 88 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3532, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3624, 51, false);
#line 91 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3675, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3766, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fce976304f870e9f17df5848ae580011d75d3b16994", async() => {
                BeginContext(3815, 4, true);
                WriteLiteral("Edit");
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
#line 94 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                                                   WriteLiteral(item.ItemId);

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
            BeginContext(3823, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(3855, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fce976304f870e9f17df5848ae580011d75d3b19391", async() => {
                BeginContext(3907, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                                                      WriteLiteral(item.ItemId);

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
            BeginContext(3918, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(3950, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fce976304f870e9f17df5848ae580011d75d3b21794", async() => {
                BeginContext(4001, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                                                     WriteLiteral(item.ItemId);

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
            BeginContext(4011, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 99 "C:\Users\Muhlestein\Documents\GitHub\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4090, 307, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""tab-pane"" id=""reorder_tab"">

        Some content for the ""To Reorder"" tab goes here. . . 
    </div>
    <div class=""tab-pane"" id=""assemblies_tab"">
        Some content for the ""Assemblies"" tab goes here. . . 
    </div>


</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CS4790TeamProject.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
