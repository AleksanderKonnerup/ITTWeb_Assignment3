#pragma checksum "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68c0857156c6c21eb423aa5f006a6e063101467"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_ComponentsIndex), @"mvc.1.0.view", @"/Views/Components/ComponentsIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/ComponentsIndex.cshtml", typeof(AspNetCore.Views_Components_ComponentsIndex))]
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
#line 1 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\_ViewImports.cshtml"
using Assignment3;

#line default
#line hidden
#line 2 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\_ViewImports.cshtml"
using Assignment3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68c0857156c6c21eb423aa5f006a6e063101467", @"/Views/Components/ComponentsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18dc5cc3ff149281ec2a403af9b6f16f4618d252", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_ComponentsIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment3.Models.Component>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a380bd0fd49453f9aff8dde51710817", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 51, false);
#line 16 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.ComponentTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 51, false);
#line 19 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.ComponentNumber));

#line default
#line hidden
            EndContext();
            BeginContext(410, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(466, 44, false);
#line 22 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNo));

#line default
#line hidden
            EndContext();
            BeginContext(510, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(566, 42, false);
#line 25 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(608, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(664, 48, false);
#line 28 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.AdminComment));

#line default
#line hidden
            EndContext();
            BeginContext(712, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(768, 47, false);
#line 31 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.UserComment));

#line default
#line hidden
            EndContext();
            BeginContext(815, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(871, 60, false);
#line 34 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentLoanInformationId));

#line default
#line hidden
            EndContext();
            BeginContext(931, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1049, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1098, 50, false);
#line 43 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComponentTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1204, 50, false);
#line 46 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComponentNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1310, 43, false);
#line 49 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNo));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1409, 41, false);
#line 52 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1506, 47, false);
#line 55 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdminComment));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1609, 46, false);
#line 58 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserComment));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1711, 59, false);
#line 61 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurrentLoanInformationId));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1825, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "226bdee176574e87892471cb08a8a95f", async() => {
                BeginContext(1879, 4, true);
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
#line 64 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
                                       WriteLiteral(item.ComponentId);

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
            BeginContext(1887, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1907, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b974aa27a0e949d6a04f2208bad63f6a", async() => {
                BeginContext(1963, 6, true);
                WriteLiteral("Delete");
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
#line 65 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
                                         WriteLiteral(item.ComponentId);

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
            BeginContext(1973, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\Components\ComponentsIndex.cshtml"
}

#line default
#line hidden
            BeginContext(2012, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment3.Models.Component>> Html { get; private set; }
    }
}
#pragma warning restore 1591
