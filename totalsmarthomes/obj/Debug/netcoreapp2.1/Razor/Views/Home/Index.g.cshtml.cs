#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84569bda4b7b5fecf86862698dff20b12ba30245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84569bda4b7b5fecf86862698dff20b12ba30245", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2e1390cd8c83cc01f942112e65ad5a672614e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
  
    Layout = "../Shared/_PageMaster.cshtml";

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
 if (Model.MainBanner != null)
{
    if (Model.MainBanner.BannerBackgroundImage != null && Model.MainBanner.BannerBackgroundImage.Url != null)
    {
        var styleCss = "background-image:url('" + Model.MainBanner.BannerBackgroundImage.Url + "');";
        var pagelink = Model.MainBanner.CtaPageLink;
        var titleText = Model.MainBanner.BannerAltText;


#line default
#line hidden
            BeginContext(444, 73, true);
            WriteLiteral("<div class=\"col-lg-12 col-md-12 col-sm-12 hidden-xs home-page-top-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 517, "\"", 534, 1);
#line 14 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 525, styleCss, 525, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Title", " Title=\"", 535, "\"", 553, 1);
#line 14 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 543, titleText, 543, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(554, 82, true);
            WriteLiteral(">\r\n    <div class=\"col-lg-offset-6 col-md-offset-6 col-sm-offset-6\">\r\n        <h1>");
            EndContext();
            BeginContext(637, 30, false);
#line 16 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
       Write(Model.MainBanner.BannerCaption);

#line default
#line hidden
            EndContext();
            BeginContext(667, 15, true);
            WriteLiteral("</h1>\r\n        ");
            EndContext();
            BeginContext(683, 38, false);
#line 17 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
   Write(Html.Raw(Model.MainBanner.CaptionText));

#line default
#line hidden
            EndContext();
            BeginContext(721, 36, true);
            WriteLiteral("\r\n        <div class=\"pull-right\">\r\n");
            EndContext();
#line 19 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
             if (!String.IsNullOrEmpty(Model.MainBanner.CtaButtonText))
            {

#line default
#line hidden
            BeginContext(845, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 859, "\"", 879, 1);
#line 21 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 866, pagelink.Url, 866, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 880, "\"", 902, 1);
#line 21 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 888, pagelink.Name, 888, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(903, 53, true);
            WriteLiteral(" class=\"btn btn-cta\" role=\"button\">\r\n                ");
            EndContext();
            BeginContext(957, 30, false);
#line 22 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
           Write(Model.MainBanner.CtaButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(987, 112, true);
            WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\r\n            </a>\r\n");
            EndContext();
#line 25 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1114, 82, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"clearfix hidden-xs\">&nbsp;</div>\r\n");
            EndContext();
#line 30 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
    }
}


#line default
#line hidden
            BeginContext(1229, 54, true);
            WriteLiteral("<h2 class=\"text-center hidden-lg hidden-md hidden-sm\">");
            EndContext();
            BeginContext(1284, 32, false);
#line 34 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                                                 Write(Model.MobileBanner.BannerCaption);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 35 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
 if (Model.MobileBanner != null)
{
    if (Model.MobileBanner.BannerBackgroundImage != null && Model.MobileBanner.BannerBackgroundImage.Url != null)
    {
        var styleCss = "background-image:url('" + Model.MobileBanner.BannerBackgroundImage.Url + "');";
        var pagelink = Model.MobileBanner.CtaPageLink;
        var titleText = Model.MobileBanner.BannerAltText;


#line default
#line hidden
            BeginContext(1704, 73, true);
            WriteLiteral("<div class=\"col-xs-12 hidden-lg hidden-md hidden-sm home-page-top-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1777, "\"", 1794, 1);
#line 43 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 1785, styleCss, 1785, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Title", " Title=\"", 1795, "\"", 1813, 1);
#line 43 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 1803, titleText, 1803, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1814, 7, true);
            WriteLiteral(">\r\n    ");
            EndContext();
            BeginContext(1822, 40, false);
#line 44 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
Write(Html.Raw(Model.MobileBanner.CaptionText));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
     if (!String.IsNullOrEmpty(Model.MobileBanner.CtaButtonText))
    {

#line default
#line hidden
            BeginContext(1938, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1944, "\"", 1964, 1);
#line 47 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 1951, pagelink.Url, 1951, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1965, "\"", 1987, 1);
#line 47 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 1973, pagelink.Name, 1973, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1988, 58, true);
            WriteLiteral(" class=\"btn btn-cta center-block\" role=\"button\">\r\n        ");
            EndContext();
            BeginContext(2047, 32, false);
#line 48 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
   Write(Model.MobileBanner.CtaButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(2079, 96, true);
            WriteLiteral("\r\n        <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\r\n    </a>\r\n");
            EndContext();
#line 51 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2182, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 53 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2197, 30, true);
            WriteLiteral("<div class=\"clearfix\"></div>\r\n");
            EndContext();
#line 55 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
}


#line default
#line hidden
#line 58 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
 if (Model.SecondaryBanners != null)
{
    var count = 1;

#line default
#line hidden
            BeginContext(2323, 29, true);
            WriteLiteral("<div class=\"row hidden-xs\">\r\n");
            EndContext();
#line 62 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
     foreach (var banner in Model.SecondaryBanners)
    {
    if (banner.BannerBackgroundImage != null && banner.BannerBackgroundImage.Url != null)
    {
    var styleCss = "background-image:url('" + banner.BannerBackgroundImage.Url + "');";
    var pagelink = Model.MobileBanner.CtaPageLink;
    var titleText = Model.MobileBanner.BannerAltText;


#line default
#line hidden
            BeginContext(2708, 127, true);
            WriteLiteral("    <div class=\"col-lg-6 col-md-6 col-sm-6 hidden-xs\">\r\n        <div class=\"col-lg-12 col-md-12 col-sm-12 home-page-sub-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2835, "\"", 2852, 1);
#line 71 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 2843, styleCss, 2843, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Title", " Title=\"", 2853, "\"", 2882, 1);
#line 71 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 2861, banner.BannerAltText, 2861, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2883, 170, true);
            WriteLiteral(">\r\n            <div class=\"col-lg-offset-7 col-md-offset-5 col-sm-offset-4 pull-right\">\r\n                <div class=\"home-page-sub-banner-text\">\r\n                    <h2>");
            EndContext();
            BeginContext(3054, 30, false);
#line 74 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                   Write(Html.Raw(banner.BannerCaption));

#line default
#line hidden
            EndContext();
            BeginContext(3084, 50, true);
            WriteLiteral("</h2>\r\n                    <div class=\"hidden-sm\">");
            EndContext();
            BeginContext(3135, 35, false);
#line 75 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                                      Write(Html.Raw(banner.CaptionTextLgAndMd));

#line default
#line hidden
            EndContext();
            BeginContext(3170, 61, true);
            WriteLiteral("</div>\r\n                    <div class=\"hidden-lg hidden-md\">");
            EndContext();
            BeginContext(3232, 30, false);
#line 76 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                                                Write(Html.Raw(banner.CaptionTextSm));

#line default
#line hidden
            EndContext();
            BeginContext(3262, 68, true);
            WriteLiteral("</div>\r\n                    <div class=\"cta-secondary pull-right\">\r\n");
            EndContext();
#line 78 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                         if (!String.IsNullOrEmpty(banner.CtaButtonText))
                        {

#line default
#line hidden
            BeginContext(3432, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3458, "\"", 3478, 1);
#line 80 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 3465, pagelink.Url, 3465, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3479, "\"", 3501, 1);
#line 80 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 3487, pagelink.Name, 3487, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3502, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(3534, 20, false);
#line 81 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                       Write(banner.CtaButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(3554, 136, true);
            WriteLiteral("\r\n                            <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\r\n                        </a>\r\n");
            EndContext();
#line 84 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3717, 100, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 90 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
    if (count % 2 == 0)
    {

#line default
#line hidden
            BeginContext(3849, 40, true);
            WriteLiteral("    <div class=\"clearfix\">&nbsp;</div>\r\n");
            EndContext();
#line 93 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
    }
    count++;
    }
    }

#line default
#line hidden
            BeginContext(3924, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 98 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
}


#line default
#line hidden
#line 101 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
 if (Model.SecondaryMobileBanners != null)
{

#line default
#line hidden
            BeginContext(4004, 47, true);
            WriteLiteral("<div class=\"clearfix visible-xs\">&nbsp;</div>\r\n");
            EndContext();
#line 104 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
    foreach (var banner in Model.SecondaryMobileBanners)
    {
        if (banner.BannerBackgroundImage != null && banner.BannerBackgroundImage.Url != null)
        {
            var styleCss = "background-image:url('" + banner.BannerBackgroundImage.Url + "');";
            var className = banner.TextToLeft ? "pull-left" : "pull-right";
            var pagelink = Model.MobileBanner.CtaPageLink;


#line default
#line hidden
            BeginContext(4458, 73, true);
            WriteLiteral("<div class=\"col-sm-12 hidden-lg hidden-md hidden-sm home-page-sub-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4531, "\"", 4548, 1);
#line 112 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 4539, styleCss, 4539, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Title", " Title=\"", 4549, "\"", 4578, 1);
#line 112 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 4557, banner.BannerAltText, 4557, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4579, 11, true);
            WriteLiteral(">\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4590, "\"", 4617, 2);
            WriteAttributeValue("", 4598, "col-xs-6", 4598, 8, true);
#line 113 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue(" ", 4606, className, 4607, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4618, 15, true);
            WriteLiteral(">\r\n        <h2>");
            EndContext();
            BeginContext(4634, 30, false);
#line 114 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
       Write(Html.Raw(banner.BannerCaption));

#line default
#line hidden
            EndContext();
            BeginContext(4664, 44, true);
            WriteLiteral("</h2>\r\n        <div class=\"cta-secondary\">\r\n");
            EndContext();
#line 116 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
             if (!String.IsNullOrEmpty(banner.CtaButtonText))
            {

#line default
#line hidden
            BeginContext(4786, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4800, "\"", 4820, 1);
#line 118 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 4807, pagelink.Url, 4807, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4821, "\"", 4843, 1);
#line 118 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
WriteAttributeValue("", 4829, pagelink.Name, 4829, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4844, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(4864, 20, false);
#line 119 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
           Write(banner.CtaButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(4884, 112, true);
            WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\r\n            </a>\r\n");
            EndContext();
#line 122 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5011, 83, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"clearfix visible-xs\">&nbsp;</div>\r\n");
            EndContext();
#line 127 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Home/Index.cshtml"
        }
    }
}

#line default
#line hidden
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
