#pragma checksum "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d50f879a201b7acddc2866cd5da82a9bd5edc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d50f879a201b7acddc2866cd5da82a9bd5edc6", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd5077569979c490f974462cc7993077c73e2e1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
  
    ViewData["Title"] = "UserRoleList";
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
                    <th>Actions</th>
                </tr>
            </thead>
");
#nullable restore
#line 29 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody class=\"table-border-bottom-0\">\r\n                    <tr class=\"table-dark\">\r\n                        <td><strong>");
#nullable restore
#line 33 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>\r\n                            <div>\r\n                                <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 982, "\"", 1025, 2);
            WriteAttributeValue("", 989, "/Admin/AdminRole/AssignRole/", 989, 28, true);
#nullable restore
#line 36 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
WriteAttributeValue("", 1017, item.Id, 1017, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Assign Role </a>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 41 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
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