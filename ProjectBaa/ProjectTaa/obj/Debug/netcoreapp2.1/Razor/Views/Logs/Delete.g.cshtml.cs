#pragma checksum "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7efc182f85aa9d10998e35745e5d3530ee0ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logs_Delete), @"mvc.1.0.view", @"/Views/Logs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Logs/Delete.cshtml", typeof(AspNetCore.Views_Logs_Delete))]
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
#line 1 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\_ViewImports.cshtml"
using ProjectTaa;

#line default
#line hidden
#line 2 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\_ViewImports.cshtml"
using ProjectTaa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7efc182f85aa9d10998e35745e5d3530ee0ae1", @"/Views/Logs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f98ba755c73b33e64fe1c36b2ccb9c1305fb95ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Logs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectTaa.Models.Log>
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 164, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Log</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(239, 46, false);
#line 15 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CallerName));

#line default
#line hidden
            EndContext();
            BeginContext(285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(329, 42, false);
#line 18 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CallerName));

#line default
#line hidden
            EndContext();
            BeginContext(371, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(415, 48, false);
#line 21 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(463, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(507, 44, false);
#line 24 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(595, 43, false);
#line 27 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LogDate));

#line default
#line hidden
            EndContext();
            BeginContext(638, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(682, 39, false);
#line 30 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LogDate));

#line default
#line hidden
            EndContext();
            BeginContext(721, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(765, 47, false);
#line 33 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(812, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(856, 43, false);
#line 36 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(943, 41, false);
#line 39 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(984, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1028, 37, false);
#line 42 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1109, 51, false);
#line 45 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LocalGovernment));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1204, 47, false);
#line 48 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LocalGovernment));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1295, 46, false);
#line 51 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StreetName));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1385, 42, false);
#line 54 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StreetName));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1471, 43, false);
#line 57 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1558, 39, false);
#line 60 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1641, 51, false);
#line 63 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CallDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1736, 47, false);
#line 66 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CallDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1827, 51, false);
#line 69 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImportanceLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1922, 47, false);
#line 72 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImportanceLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2007, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120bcee3d37f455a89c70931154430b6", async() => {
                BeginContext(2033, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2043, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a208eb43f7042a5a8504db7fc68979a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\ridhwan.oladejo\Documents\Visual Studio 2017\Projects\ProjectBaa_Version2\ProjectBaa\ProjectTaa\Views\Logs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(2079, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2163, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e33c21df6364e119f2f2816687ab1af", async() => {
                    BeginContext(2185, 12, true);
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
                BeginContext(2201, 6, true);
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
            BeginContext(2214, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectTaa.Models.Log> Html { get; private set; }
    }
}
#pragma warning restore 1591
