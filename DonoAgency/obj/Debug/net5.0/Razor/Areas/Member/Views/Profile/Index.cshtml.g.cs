#pragma checksum "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a5e9b7b67ff898b22dbc6d21d343aa38f7a1f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Profile_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Profile/Index.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\_ViewImports.cshtml"
using DonoAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\_ViewImports.cshtml"
using DonoAgency.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5e9b7b67ff898b22dbc6d21d343aa38f7a1f4f", @"/Areas/Member/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd5077569979c490f974462cc7993077c73e2e1", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 border-radius-lg shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""page-header min-height-300 border-radius-xl mt-4"" style=""background-image: url('/soft-ui-dashboard/assets/img/curved-images/curved0.jpg'); background-position-y: 50%;"">
        <span class=""mask bg-gradient-primary opacity-6""></span>
    </div>
    <div class=""card card-body blur shadow-blur mx-4 mt-n6 overflow-hidden"">
        <div class=""row gx-4"">
            <div class=""col-auto"">
                <div class=""avatar avatar-xl position-relative"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a5e9b7b67ff898b22dbc6d21d343aa38f7a1f4f4964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 692, "~/userimages/", 692, 13, true);
#nullable restore
#line 15 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml"
AddHtmlAttributeValue("", 705, ViewBag.img, 705, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-auto my-auto\">\r\n                <div class=\"h-100\">\r\n                    <h5 class=\"mb-1\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml"
                   Write(ViewBag.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h5>
                    <p class=""mb-0 font-weight-bold text-sm"">
                        Member
                    </p>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 my-sm-auto ms-sm-auto me-sm-0 mx-auto mt-3"">
                <div class=""nav-wrapper position-relative end-0"">
                    <ul class=""nav nav-pills nav-fill p-1 bg-transparent"" role=""tablist"">
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container-fluid py-4"">
    <div class=""row"">
        <div class=""col-12 col-xl-4"">
            <div class=""card h-100"">
                <div class=""card-header pb-0 p-3"">
                    <div class=""row"">
                        <div class=""col-md-8 d-flex align-items-center"">
                            <h6 class=""mb-0"">Profile Information</h6>
                        </div>
                    </div>
                </div>
                <div ");
            WriteLiteral(@"class=""card-body p-3"">
                    <hr class=""horizontal gray-light my-4"">
                    <ul class=""list-group"">
                        <li class=""list-group-item border-0 ps-0 pt-0 text-sm""><strong class=""text-dark"">Full Name:</strong> &nbsp; ");
#nullable restore
#line 51 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml"
                                                                                                                               Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Mobile:</strong> &nbsp; ");
#nullable restore
#line 52 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml"
                                                                                                                       Write(ViewBag.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Email:</strong> &nbsp; ");
#nullable restore
#line 53 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Areas\Member\Views\Profile\Index.cshtml"
                                                                                                                      Write(ViewBag.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        <li class=""list-group-item border-0 ps-0 text-sm""><strong class=""text-dark"">Location:</strong> &nbsp; Ülke gelicek</li>
                        <li class=""list-group-item border-0 ps-0 pb-0"">
                            <strong class=""text-dark text-sm"">Social:</strong> &nbsp;
                            <a class=""btn btn-facebook btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                                <i class=""fab fa-facebook fa-lg""></i>
                            </a>
                            <a class=""btn btn-twitter btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                                <i class=""fab fa-twitter fa-lg""></i>
                            </a>
                            <a class=""btn btn-instagram btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                                <i class=""fab fa-instagram fa-lg""></i>
                            </a>
                        </li>
                    </ul>
            ");
            WriteLiteral("    </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
