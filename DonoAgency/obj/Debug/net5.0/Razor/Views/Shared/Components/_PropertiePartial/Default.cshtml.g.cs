#pragma checksum "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "605e3fb7f6dfa6cc35705f2f23eec0a2623b444b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PropertiePartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PropertiePartial/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605e3fb7f6dfa6cc35705f2f23eec0a2623b444b", @"/Views/Shared/Components/_PropertiePartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291b87bf00caa755168f772b05df84f292629e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__PropertiePartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Propertie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- ======= Property Grid ======= -->\r\n<section class=\"property-grid grid\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"grid-option\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605e3fb7f6dfa6cc35705f2f23eec0a2623b444b4873", async() => {
                WriteLiteral("\r\n                        <select class=\"custom-select\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605e3fb7f6dfa6cc35705f2f23eec0a2623b444b5219", async() => {
                    WriteLiteral("All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605e3fb7f6dfa6cc35705f2f23eec0a2623b444b6581", async() => {
                    WriteLiteral("New to Old");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605e3fb7f6dfa6cc35705f2f23eec0a2623b444b7836", async() => {
                    WriteLiteral("For Rent");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605e3fb7f6dfa6cc35705f2f23eec0a2623b444b9089", async() => {
                    WriteLiteral("For Sale");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"card-box-a card-shadow\">\r\n                        <div class=\"img-box-a\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 951, "\"", 981, 1);
#nullable restore
#line 24 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
WriteAttributeValue("", 957, item.PropertieMainPhoto, 957, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 982, "\"", 988, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-a img-fluid"">
                        </div>
                        <div class=""card-overlay"">
                            <div class=""card-overlay-a-content"">
                                <div class=""card-header-a"">
                                    <h2 class=""card-title-a"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1332, "\"", 1383, 2);
            WriteAttributeValue("", 1339, "/Propertie/PropertieSingle/", 1339, 27, true);
#nullable restore
#line 30 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
WriteAttributeValue("", 1366, item.PropertieID, 1366, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 31 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
                                       Write(item.PropertieName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </h2>
                                </div>
                                <div class=""card-body-a"">
                                    <div class=""price-box d-flex"">
                                        <span class=""price-a"">rent | $ ");
#nullable restore
#line 37 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
                                                                  Write(item.PropertiePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1890, "\"", 1941, 2);
            WriteAttributeValue("", 1897, "/Propertie/PropertieSingle/", 1897, 27, true);
#nullable restore
#line 39 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
WriteAttributeValue("", 1924, item.PropertieID, 1924, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""link-a"">
                                        Click here to view
                                        <span class=""bi bi-chevron-right""></span>
                                    </a>
                                </div>
                                <div class=""card-footer-a"">
                                    <ul class=""card-info d-flex justify-content-around"">
                                        <li>
                                            <h4 class=""card-info-title"">Area</h4>
                                            <span>
                                                ");
#nullable restore
#line 49 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
                                           Write(item.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                <sup>2</sup>
                                            </span>
                                        </li>
                                        <li>
                                            <h4 class=""card-info-title"">Beds</h4>
                                            <span>");
#nullable restore
#line 55 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
                                             Write(item.Bed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </li>\r\n                                        <li>\r\n                                            <h4 class=\"card-info-title\">Baths</h4>\r\n                                            <span>");
#nullable restore
#line 59 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
                                             Write(item.Bath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </li>\r\n                                        <li>\r\n                                            <h4 class=\"card-info-title\">Garages</h4>\r\n                                            <span>");
#nullable restore
#line 63 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
                                             Write(item.Garage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 71 "C:\Users\ahmet\Desktop\DonoAgencyCopy - Kopya\DonoAgency\Views\Shared\Components\_PropertiePartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row"">
            <div class=""col-sm-12"">
                <nav class=""pagination-a"">
                    <ul class=""pagination justify-content-end"">
                        <li class=""page-item disabled"">
                            <a class=""page-link"" href=""#"" tabindex=""-1"">
                                <span class=""bi bi-chevron-left""></span>
                            </a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">1</a>
                        </li>
                        <li class=""page-item active"">
                            <a class=""page-link"" href=""#"">2</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">3</a>
                        </li>
                        <li class=""page-item next"">
                            <a class=""page-link"" href=""#"">
             ");
            WriteLiteral(@"                   <span class=""bi bi-chevron-right""></span>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</section><!-- End Property Grid Single-->");
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
