#pragma checksum "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e11d7ed3e8feab0d07cfc3bbbbbe2e2d94d240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MemberListAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MemberListAdmin/Index.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\_ViewImports.cshtml"
using DonoAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\_ViewImports.cshtml"
using DonoAgency.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e11d7ed3e8feab0d07cfc3bbbbbe2e2d94d240", @"/Areas/Admin/Views/MemberListAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd5077569979c490f974462cc7993077c73e2e1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MemberListAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<hr class=""my-5"" />

<!-- Contextual Classes -->

<div class=""card"">
    <h5 class=""card-header"">User Role List</h5>
    <div style=""
        position: absolute;
        right: 10%;
        top: 30px;
            "">
    </div>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>User Name</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                </tr>
            </thead>
");
#nullable restore
#line 30 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tbody class=""table-border-bottom-0"">
                    <tr class=""table-dark"">
                        <td>
                            <ul class=""list-unstyled users-list m-0 avatar-group d-flex align-items-center"">
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1269, "\"", 1289, 1);
#nullable restore
#line 40 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
WriteAttributeValue("", 1275, item.ImageUrl, 1275, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" class=\"rounded-circle\" />\r\n                                </li>\r\n                            </ul>\r\n                        </td>\r\n                        <td><strong>");
#nullable restore
#line 44 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
                       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <div>
                                <a class=""btn btn-info"" href=""#""> View Profile </a>
                            </div>
                        </td>
                        <td>
                            <div>
                                <a class=""btn btn-danger"" href=""#""> Delete User </a>
                            </div>
                        </td>
                    </tr>
                </tbody>
");
#nullable restore
#line 59 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\MemberListAdmin\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n<!--/ Contextual Classes -->\r\n\r\n<hr class=\"my-5\" />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591