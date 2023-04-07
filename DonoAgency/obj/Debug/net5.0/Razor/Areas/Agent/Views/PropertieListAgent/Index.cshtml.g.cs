#pragma checksum "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a26e79d026d964c59612ca0e8d846702798c5ba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Agent_Views_PropertieListAgent_Index), @"mvc.1.0.view", @"/Areas/Agent/Views/PropertieListAgent/Index.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\_ViewImports.cshtml"
using DonoAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\_ViewImports.cshtml"
using DonoAgency.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a26e79d026d964c59612ca0e8d846702798c5ba3", @"/Areas/Agent/Views/PropertieListAgent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd5077569979c490f974462cc7993077c73e2e1", @"/Areas/Agent/Views/_ViewImports.cshtml")]
    public class Areas_Agent_Views_PropertieListAgent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Propertie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AgentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr class=""my-5"" />

<!-- Contextual Classes -->

<div class=""card"">
    <h5 class=""card-header"">All Properties</h5>
    <div style=""
        position: absolute;
        right: 10%;
        top: 30px;
            "">
        <a href=""/Agent/PropertieListAgent/AddPropertie"" class=""btn btn-info"">Add New Propertie</a>
    </div>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Propertie Name</th>
                    <th>Agent</th>
                    <th>Agent Photo</th>
                    <th>Status</th>
                    <th>Actions</th>
                </tr>
            </thead>
");
#nullable restore
#line 31 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody class=\"table-border-bottom-0\">\r\n                    <tr class=\"table-dark\">\r\n                        <td><strong>");
#nullable restore
#line 35 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
                               Write(item.PropertieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
                       Write(item.Agent.AgentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <ul class=""list-unstyled users-list m-0 avatar-group d-flex align-items-center"">
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Lilian Fuller"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1633, "\"", 1661, 1);
#nullable restore
#line 44 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
WriteAttributeValue("", 1639, item.Agent.AgentPhoto, 1639, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" class=\"rounded-circle\" />\r\n                                </li>\r\n                            </ul>\r\n                        </td>\r\n                        <td><span class=\"badge bg-label-success me-1\">");
#nullable restore
#line 48 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
                                                                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td>\r\n                            <div>\r\n                                <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2024, "\"", 2075, 2);
            WriteAttributeValue("", 2031, "/Propertie/PropertieSingle/", 2031, 27, true);
#nullable restore
#line 51 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
WriteAttributeValue("", 2058, item.PropertieID, 2058, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> View In Site </a>\r\n                                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 2155, "\"", 2221, 2);
            WriteAttributeValue("", 2162, "/Agent/PropertieListAgent/UpdatePropertie/", 2162, 42, true);
#nullable restore
#line 52 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
WriteAttributeValue("", 2204, item.PropertieID, 2204, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Edit </a>\r\n                                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2292, "\"", 2358, 2);
            WriteAttributeValue("", 2299, "/Agent/PropertieListAgent/DeletePropertie/", 2299, 42, true);
#nullable restore
#line 53 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
WriteAttributeValue("", 2341, item.PropertieID, 2341, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Delete </a>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 58 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Agent\Views\PropertieListAgent\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n<!--/ Contextual Classes -->\r\n\r\n<hr class=\"my-5\" />\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Propertie>> Html { get; private set; }
    }
}
#pragma warning restore 1591