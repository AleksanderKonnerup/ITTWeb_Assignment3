#pragma checksum "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb437265ed9452c1a151dfef9a769425f61bb2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComponentCategories_List), @"mvc.1.0.view", @"/Views/ComponentCategories/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComponentCategories/List.cshtml", typeof(AspNetCore.Views_ComponentCategories_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb437265ed9452c1a151dfef9a769425f61bb2b9", @"/Views/ComponentCategories/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18dc5cc3ff149281ec2a403af9b6f16f4618d252", @"/Views/_ViewImports.cshtml")]
    public class Views_ComponentCategories_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment3.ViewModels.ComponentTypeListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(100, 75, true);
            WriteLiteral("\r\n<h2>List of Component Types</h2>\r\n\r\n<div>\r\n    <h4>Component Types</h4>\r\n");
            EndContext();
#line 11 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
     foreach (var componentType in Model.ComponentTypesList)
    {

#line default
#line hidden
            BeginContext(244, 92, true);
            WriteLiteral("        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                Name: ");
            EndContext();
            BeginContext(337, 45, false);
#line 16 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
                 Write(Html.DisplayName(componentType.ComponentName));

#line default
#line hidden
            EndContext();
            BeginContext(382, 65, true);
            WriteLiteral(";\r\n            </dt>\r\n            <dd>\r\n                Details: ");
            EndContext();
            BeginContext(448, 45, false);
#line 19 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
                    Write(Html.DisplayName(componentType.ComponentInfo));

#line default
#line hidden
            EndContext();
            BeginContext(493, 64, true);
            WriteLiteral(";\r\n            </dd>\r\n            <dd>\r\n                Status: ");
            EndContext();
            BeginContext(558, 49, false);
#line 22 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
                   Write(Html.DisplayName(componentType.Status.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(607, 56, true);
            WriteLiteral(";\r\n            </dd>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(664, 96, false);
#line 25 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
           Write(Html.ActionLink("Edit Component Type", "Edit", "ComponentTypes", @componentType.ComponentTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(760, 36, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
            EndContext();
#line 28 "D:\OneDrive\7. Semester\ITWEB\Assignment3\ITTWeb_Assignment3\Assignment3\Views\ComponentCategories\List.cshtml"
    }

#line default
#line hidden
            BeginContext(803, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(822, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d2135db79f74c4fb46181dc40812288", async() => {
                BeginContext(844, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(860, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment3.ViewModels.ComponentTypeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
