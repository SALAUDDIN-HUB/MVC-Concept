#pragma checksum "E:\C#\EmployeeMvc\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603bc139a6c2617ac88a8bca3781b81f70ea992f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "E:\C#\EmployeeMvc\Views\_ViewImports.cshtml"
using EmployeeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\EmployeeMvc\Views\_ViewImports.cshtml"
using EmployeeMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603bc139a6c2617ac88a8bca3781b81f70ea992f", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b770d7af0d50ad67cca59f44be4c685c2b368c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\C#\EmployeeMvc\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<h1>Welcome ");
#nullable restore
#line 8 "E:\C#\EmployeeMvc\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "E:\C#\EmployeeMvc\Views\Employee\Details.cshtml"
Write(Html.ActionLink("LOgOUT", "Login", "Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
