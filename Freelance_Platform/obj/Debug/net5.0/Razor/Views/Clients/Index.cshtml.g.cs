#pragma checksum "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba6746e2265e578a15a822dce12ebcc68e718b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
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
#line 1 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\_ViewImports.cshtml"
using Freelance_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\_ViewImports.cshtml"
using Freelance_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba6746e2265e578a15a822dce12ebcc68e718b9", @"/Views/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d52ed823970db9c0bea74bbbc7277ac988f37e", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
  
    ViewData["Title"] = "List of Clients";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 14 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 915, "\"", 944, 1);
#nullable restore
#line 30 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
WriteAttributeValue("", 921, item.ProfilePictureURL, 921, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"item.FullName\" style=\"max-width:150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 33 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 36 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary"">
                                <i class=""bi bi-pencil-square""></i>Edit
                            </a>
                            <a class=""btn btn-outline-info"">
                                <i class=""bi bi-eye""></i>Details
                            </a>
                            <a class=""btn btn-danger"">
                                <i class=""bi bi-trash""></i>Delete
                            </a>
                        </td>
                    </tr>
");
#nullable restore
#line 50 "C:\Users\lamou\source\repos\Freelance_Platform\Freelance_Platform\Views\Clients\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
