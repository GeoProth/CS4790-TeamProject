#pragma checksum "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6718ea2f2bdec88d002a9e2f08f4eda01cf451db"
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
#line 1 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject;

#line default
#line hidden
#line 2 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\_ViewImports.cshtml"
using CS4790TeamProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6718ea2f2bdec88d002a9e2f08f4eda01cf451db", @"/Views/Inventory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee5fd99bc547497ff347ecd2ceb83c83045ba09", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CS4790TeamProject.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("create-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reorder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(72, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6718ea2f2bdec88d002a9e2f08f4eda01cf451db5207", async() => {
                BeginContext(114, 57, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\" style=\"font-size:36px;\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(175, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(251, 753, true);
            WriteLiteral(@"
<!-- Nav tabs -->
<ul class=""nav nav-pills"" role=""tablist"" style=""font-weight:bold;"">
    <li><a id=""inventory-tab"" class=""nav-link active"" href=""#all_tab"" role=""tab"" data-toggle=""tab"">All</a></li>
    <li><a id=""inventory-tab"" class=""nav-link"" href=""#reorder_tab"" role=""tab"" data-toggle=""tab"">To Reorder</a></li>
    <li><a id=""inventory-tab"" class=""nav-link"" href=""#assemblies_tab"" role=""tab"" data-toggle=""tab"">Assemblies</a></li>
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
            BeginContext(1005, 44, false);
#line 27 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1129, 47, false);
#line 30 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1256, 45, false);
#line 33 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1381, 50, false);
#line 36 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1511, 46, false);
#line 39 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1637, 42, false);
#line 42 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1759, 45, false);
#line 45 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1884, 47, false);
#line 48 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(1931, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2011, 50, false);
#line 51 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2141, 52, false);
#line 54 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2384, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2469, 43, false);
#line 64 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2604, 46, false);
#line 67 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2742, 44, false);
#line 70 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2878, 49, false);
#line 73 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListRetailCost));

#line default
#line hidden
            EndContext();
            BeginContext(2927, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3019, 45, false);
#line 76 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(3064, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3156, 41, false);
#line 79 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MaxQty));

#line default
#line hidden
            EndContext();
            BeginContext(3197, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3289, 44, false);
#line 82 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MeasureID));

#line default
#line hidden
            EndContext();
            BeginContext(3333, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3425, 46, false);
#line 85 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MeasureAmnt));

#line default
#line hidden
            EndContext();
            BeginContext(3471, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3563, 49, false);
#line 88 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3612, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3704, 51, false);
#line 91 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3755, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3846, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6718ea2f2bdec88d002a9e2f08f4eda01cf451db17912", async() => {
                BeginContext(3895, 4, true);
                WriteLiteral("Edit");
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
#line 94 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
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
            BeginContext(3903, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(3935, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6718ea2f2bdec88d002a9e2f08f4eda01cf451db20314", async() => {
                BeginContext(3987, 7, true);
                WriteLiteral("Details");
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
#line 95 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
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
            BeginContext(3998, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(4030, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6718ea2f2bdec88d002a9e2f08f4eda01cf451db22722", async() => {
                BeginContext(4081, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
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
            BeginContext(4091, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 99 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4170, 307, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""tab-pane"" id=""reorder_tab"">
        <br />
        <table id=""table_inventory2"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(4478, 44, false);
#line 109 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(4522, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(4602, 45, false);
#line 112 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(4647, 168, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        In transit\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(4816, 46, false);
#line 118 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(4862, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 124 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(5053, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5138, 43, false);
#line 128 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(5181, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5273, 44, false);
#line 131 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OnhandQty));

#line default
#line hidden
            EndContext();
            BeginContext(5317, 126, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td></td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5444, 45, false);
#line 135 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReorderQty));

#line default
#line hidden
            EndContext();
            BeginContext(5489, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5580, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6718ea2f2bdec88d002a9e2f08f4eda01cf451db29287", async() => {
                BeginContext(5632, 7, true);
                WriteLiteral("Reorder");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 138 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
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
            BeginContext(5643, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 141 "C:\Users\gprot\Desktop\CS4790\TeamProject\CS4790-TeamProject\CS4790TeamProject\Views\Inventory\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5722, 767, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""tab-pane"" id=""assemblies_tab"">
        <table id=""table_inventory3"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>On Hand</th>
                    <th>In Transit</th>
                    <th>Reorder Part</th>
                    <th>Reorder</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </tbody>
        </table>
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
