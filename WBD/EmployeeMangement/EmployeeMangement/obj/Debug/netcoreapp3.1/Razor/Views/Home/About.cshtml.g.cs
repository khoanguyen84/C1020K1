#pragma checksum "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6065a5657d0e871a2e3ee077578869ca90245a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 2 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\_ViewImports.cshtml"
using EmployeeMangement.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\_ViewImports.cshtml"
using EmployeeMangement.Models.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\_ViewImports.cshtml"
using EmployeeMangement.Models.About;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6065a5657d0e871a2e3ee077578869ca90245a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc340dbae19d68219e43e04944e7809201e8dcb", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebe793ae32f8a1acda33f9f4b26e0b15f3caa51", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table>\r\n");
#nullable restore
#line 3 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\About.cshtml"
     foreach (var person in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>Fullname:</td>\r\n            <td>");
#nullable restore
#line 7 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\About.cshtml"
           Write(person.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Email:</td>\r\n            <td>");
#nullable restore
#line 11 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\About.cshtml"
           Write(person.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Address:</td>\r\n            <td>");
#nullable restore
#line 15 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\About.cshtml"
           Write(person.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 17 "C:\CodeGym\Class\C1020K1\WBD\EmployeeMangement\EmployeeMangement\Views\Home\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591