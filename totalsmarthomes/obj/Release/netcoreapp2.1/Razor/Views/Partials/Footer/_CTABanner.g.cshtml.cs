#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Footer/_CTABanner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31eb2da6ed769724b75a560712eb7e69a2efb4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Footer__CTABanner), @"mvc.1.0.view", @"/Views/Partials/Footer/_CTABanner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/Footer/_CTABanner.cshtml", typeof(AspNetCore.Views_Partials_Footer__CTABanner))]
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
#line 1 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/_ViewImports.cshtml"
using totalsmarthomes;

#line default
#line hidden
#line 2 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/_ViewImports.cshtml"
using totalsmarthomes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31eb2da6ed769724b75a560712eb7e69a2efb4a", @"/Views/Partials/Footer/_CTABanner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2e1390cd8c83cc01f942112e65ad5a672614e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Footer__CTABanner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<totalsmarthomes.Models.ViewModels.Shared.FooterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(115, 115, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"text-center\">\r\n");
            EndContext();
#line 8 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Footer/_CTABanner.cshtml"
             if (Model.GenericProperties.FooterCallToAction)
            {
                if (!String.IsNullOrEmpty(Model.FooterCtaButton.CtaButtonText))
                {

#line default
#line hidden
            BeginContext(407, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 429, "\"", 462, 1);
#line 12 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Footer/_CTABanner.cshtml"
WriteAttributeValue("", 436, Model.FooterCtaButton.Url, 436, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 463, "\"", 498, 1);
#line 12 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Footer/_CTABanner.cshtml"
WriteAttributeValue("", 471, Model.FooterCtaButton.Name, 471, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(499, 61, true);
            WriteLiteral(" class=\"btn btn-cta\" role=\"button\">\r\n                        ");
            EndContext();
            BeginContext(561, 35, false);
#line 13 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Footer/_CTABanner.cshtml"
                   Write(Model.FooterCtaButton.CtaButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(596, 119, true);
            WriteLiteral("\r\n                        <span class=\"glyphicon glyphicon-play\" aria-hidden=\"true\"></span>\r\n                    </a>\r\n");
            EndContext();
#line 16 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Footer/_CTABanner.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(749, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<totalsmarthomes.Models.ViewModels.Shared.FooterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
