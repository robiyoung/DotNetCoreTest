#pragma checksum "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e18f6fe0ff95836c668a5b2159aa5e05d2c8d69b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18f6fe0ff95836c668a5b2159aa5e05d2c8d69b", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(103, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(110, 17, false);
#line 7 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(216, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a884590547fb43c48ea52631aff94b3f", async() => {
                BeginContext(268, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 483, "", 510, 1);
#line 15 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 490, ViewData["minDate"], 490, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(510, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 714, "", 741, 1);
#line 19 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 721, ViewData["maxDate"], 721, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(741, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(880, 138, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1019, 43, false);
#line 29 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1278, 38, false);
#line 36 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1396, 40, false);
#line 39 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1516, 42, false);
#line 42 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1638, 53, false);
#line 45 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1771, 42, false);
#line 48 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1893, 42, false);
#line 51 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 56 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2095, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2180, 37, false);
#line 60 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2217, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2309, 39, false);
#line 63 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2440, 46, false);
#line 66 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2486, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2578, 57, false);
#line 69 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2635, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2727, 41, false);
#line 72 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2768, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2860, 41, false);
#line 75 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2901, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 78 "C:\tmp\CSharp\DotNetCoreTest\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2980, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
