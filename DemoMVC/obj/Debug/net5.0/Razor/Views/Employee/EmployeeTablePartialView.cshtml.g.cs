#pragma checksum "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4855481daac1f7289a3fb57d7a0b36de562f6a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeTablePartialView), @"mvc.1.0.view", @"/Views/Employee/EmployeeTablePartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4855481daac1f7289a3fb57d7a0b36de562f6a78", @"/Views/Employee/EmployeeTablePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006f3be6ec11f6f8cac410d8e992647e1f50fc12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_EmployeeTablePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonViewPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <table id=\"EmpTable\" class=\"table table-hover table-striped\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 6 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
               Write(Html.DisplayNameFor(e => e.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 7 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
               Write(Html.DisplayNameFor(e => e.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 8 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
               Write(Html.DisplayNameFor(e => e.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 9 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
               Write(Html.DisplayNameFor(e => e.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 10 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
               Write(Html.DisplayNameFor(e => e.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 11 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
               Write(Html.DisplayNameFor(e => e.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody class=\"tBody\">\r\n");
#nullable restore
#line 19 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                      <td class=\"tName\">");
#nullable restore
#line 22 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
                                   Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td class=\"tAddress\">");
#nullable restore
#line 23 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
                                      Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td class=\"tEmail\">");
#nullable restore
#line 24 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
                                    Write(Html.DisplayFor(M=> employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td class=\"tSalary\">");
#nullable restore
#line 25 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
                                     Write(Html.DisplayFor(M => employee.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td class=\"tDepartment\">");
#nullable restore
#line 26 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
                                         Write(employee.Department?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td class=\"tHiredate\">");
#nullable restore
#line 27 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
                                       Write(employee.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4855481daac1f7289a3fb57d7a0b36de562f6a788535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = employee.Id.ToString();

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
            WriteLiteral("\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 32 "E:\route course\.net\C#\WebDemoMVC Solution\DemoMVC\Views\Employee\EmployeeTablePartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
