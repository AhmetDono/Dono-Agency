#pragma checksum "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Agent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c320ad6595fe63dd50accad7f0a29d3a81675b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agent_Index), @"mvc.1.0.view", @"/Views/Agent/Index.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\_ViewImports.cshtml"
using DonoAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\_ViewImports.cshtml"
using DonoAgency.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c320ad6595fe63dd50accad7f0a29d3a81675b7a", @"/Views/Agent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291b87bf00caa755168f772b05df84f292629e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Agent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Agent\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- =======Intro Single ======= -->
<section class=""intro-single"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-lg-8"">
                <div class=""title-single-box"">
                    <h1 class=""title-single"">Our Amazing Agents</h1>
                    <span class=""color-text-a"">Grid Properties</span>
                </div>
            </div>
            <div class=""col-md-12 col-lg-4"">
                <nav aria-label=""breadcrumb"" class=""breadcrumb-box d-flex justify-content-lg-end"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">
                            <a href=""#"">Home</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">
                            Agents Grid
                        </li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</section>
<!-- End Intro Single-->
<");
            WriteLiteral("!-- ======= Agents Grid ======= -->\r\n");
#nullable restore
#line 33 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Agent\Index.cshtml"
Write(await Component.InvokeAsync("_AgentPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End Agents Grid-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591