#pragma checksum "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c23dfa887f37e42b35bc197bfac7d813182c61a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#nullable restore
#line 1 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\_ViewImports.cshtml"
using DemoDAL.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23dfa887f37e42b35bc197bfac7d813182c61a4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006f3be6ec11f6f8cac410d8e992647e1f50fc12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-3 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonViewPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mb-4\">All Users</h1>\r\n\r\n<div class=\"m-auto\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c23dfa887f37e42b35bc197bfac7d813182c61a45181", async() => {
                WriteLiteral(@"
    <div class=""row w-100"">
        <div class=""col-md-10"">
            <input id=""Search"" placeholder=""Search For Email"" name=""email"" class=""form-control"" />
        </div>

        <div class=""col-md-2"">
            <input type=""submit"" value=""Search"" class=""btn btn-warning btn-block""/>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table id=\"EmpTable\" class=\"table table-hover table-striped\">\r\n\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 33 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u => u.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 34 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u => u.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 35 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u => u.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 36 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u => u.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 37 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u => u.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Details</th>\r\n                    <th>Update</th>\r\n                    <th>Delete</th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 45 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                          <td>");
#nullable restore
#line 48 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                         Write(Html.DisplayFor(M=>user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td>");
#nullable restore
#line 49 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                         Write(Html.DisplayFor(M=>user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td>");
#nullable restore
#line 50 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                         Write(Html.DisplayFor(M=> user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td>");
#nullable restore
#line 51 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                         Write(Html.DisplayFor(M=> user.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td>");
#nullable restore
#line 52 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
                         Write(string.Join(" ",user.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c23dfa887f37e42b35bc197bfac7d813182c61a410802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 54 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = user.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 57 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n");
#nullable restore
#line 61 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"py-2 h3 alert alert-success\">There is No Users :(</div>\r\n");
#nullable restore
#line 66 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591