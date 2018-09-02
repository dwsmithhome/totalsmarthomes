#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e008a8e68a8e98c11bb7b7cea71e9ac3d27d937"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Meta__MetaHeadContent), @"mvc.1.0.view", @"/Views/Partials/Meta/_MetaHeadContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/Meta/_MetaHeadContent.cshtml", typeof(AspNetCore.Views_Partials_Meta__MetaHeadContent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e008a8e68a8e98c11bb7b7cea71e9ac3d27d937", @"/Views/Partials/Meta/_MetaHeadContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2e1390cd8c83cc01f942112e65ad5a672614e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Meta__MetaHeadContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<totalsmarthomes.Models.ViewModels.Shared.MetaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
  
    try
    {

#line default
#line hidden
            BeginContext(162, 147, true);
            WriteLiteral("        <meta charset=\"utf-8\">\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1.0, user-scalable=no\">\r\n");
            EndContext();
#line 9 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"

        if (!String.IsNullOrEmpty(Model.GoogleSiteVerification))
        {

#line default
#line hidden
            BeginContext(388, 49, true);
            WriteLiteral("            <meta name=\"google-site-verification\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 437, "\"", 477, 2);
#line 12 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 447, Model.GoogleSiteVerification, 447, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 476, ")", 476, 1, true);
            EndWriteAttribute();
            BeginContext(478, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 13 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        }

        

#line default
#line hidden
            BeginContext(531, 47, true);
            WriteLiteral("        <meta name=\"apple-mobile-web-app-title\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 578, "\"", 599, 1);
#line 16 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 588, Model.Name, 588, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(600, 227, true);
            WriteLiteral(">\r\n        <meta name=\"apple-mobile-web-app-capable\" content=\"yes\">\r\n        <meta name=\"apple-mobile-web-app-status-bar-style\" content=\"black\">\r\n        <meta name=\"SKYPE_TOOLBAR\" content=\"SKYPE_TOOLBAR_PARSER_COMPATIBLE\" />\r\n");
            EndContext();
#line 20 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        if (Model.DoNotIndex)
        {

#line default
#line hidden
            BeginContext(869, 52, true);
            WriteLiteral("            <meta name=\"robots\" content=\"NOINDEX\">\r\n");
            EndContext();
#line 23 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
            return;
        }

#line default
#line hidden
            BeginContext(953, 27, true);
            WriteLiteral("        <meta name=\"author\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 980, "\"", 1001, 1);
#line 25 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 990, Model.Name, 990, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1002, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 26 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        if (!String.IsNullOrEmpty(@Model.MetaDescription))
        {

#line default
#line hidden
            BeginContext(1076, 36, true);
            WriteLiteral("            <meta name=\"description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1112, "\"", 1144, 1);
#line 28 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1122, Model.MetaDescription, 1122, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1145, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 29 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        }
        if (!String.IsNullOrEmpty(Model.MetaKeywords))
        {

#line default
#line hidden
            BeginContext(1228, 33, true);
            WriteLiteral("            <meta name=\"keywords\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1261, "\"", 1290, 1);
#line 32 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1271, Model.MetaKeywords, 1271, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1291, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 33 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        }


        

#line default
#line hidden
            BeginContext(1362, 31, true);
            WriteLiteral("        <meta property=\"og:url\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1393, "\"", 1428, 1);
#line 37 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1403, Model.CurrentContent.Url, 1403, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 38, true);
            WriteLiteral(" />\r\n        <meta property=\"og:title\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1467, "\"", 1489, 1);
#line 38 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1477, Model.Title, 1477, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1490, 42, true);
            WriteLiteral(" />\r\n        <meta property=\"og:site_name\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1532, "\"", 1553, 1);
#line 39 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1542, Model.Name, 1542, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1554, 44, true);
            WriteLiteral(" />\r\n        <meta property=\"og:description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1598, "\"", 1630, 1);
#line 40 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1608, Model.MetaDescription, 1608, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 60, true);
            WriteLiteral(" />\r\n        <meta property=\"og:type\" content=\"article\" />\r\n");
            EndContext();
#line 42 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        if (Model.Image != null)
        {

#line default
#line hidden
            BeginContext(1736, 37, true);
            WriteLiteral("            <meta property=\"og:image\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1773, "\"", 1799, 1);
#line 44 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1783, Model.Image.Url, 1783, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1800, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 45 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"

        }

#line default
#line hidden
            BeginContext(1818, 119, true);
            WriteLiteral("        <meta property=\"og:locale\" content=\"en_GB\" />\r\n        <meta property=\"http://ogp.me/ns/article#published_time\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1937, "\"", 2044, 1);
#line 48 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 1947, Model.CurrentContent.CreateDate.ToString("s", System.Globalization.CultureInfo.InvariantCulture), 1947, 97, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2045, 68, true);
            WriteLiteral(" />\r\n        <meta property=\"http://ogp.me/ns/article#modified_time\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 2113, "\"", 2220, 1);
#line 49 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 2123, Model.CurrentContent.UpdateDate.ToString("s", System.Globalization.CultureInfo.InvariantCulture), 2123, 97, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2221, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 50 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        if (Model.CurrentContent.Parent != null)
        {

#line default
#line hidden
            BeginContext(2287, 61, true);
            WriteLiteral("            <meta property=\"http://ogp.me/ns/article#section\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 2348, "\"", 2391, 1);
#line 52 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 2358, Model.CurrentContent.Parent.Name, 2358, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2392, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 53 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
        }
        if (Model.CurrentContent.HasProperty("endDate"))
        {
            var endDate = Model.CurrentContent.GetPropertyValue<DateTime>("endDate", DateTime.MinValue);
            if (endDate > DateTime.MinValue)
            {

#line default
#line hidden
            BeginContext(2644, 73, true);
            WriteLiteral("                <meta property=\"http://ogp.me/ns/article#expiration_time\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 2717, "\"", 2800, 1);
#line 59 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 2727, endDate.ToString("s", System.Globalization.CultureInfo.InvariantCulture), 2727, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2801, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 60 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
            }
        }

        var canonicalUrl = String.Empty;



        if (Context.Request.Host.Value.ToLower().StartsWith("www"))
        {
            canonicalUrl = string.Concat("http://", Context.Request.Host.Value, Model.CurrentContent.Url);
        }
        else
        {
            canonicalUrl = string.Concat("http://www.", Context.Request.Host.Value, Model.CurrentContent.Url);
        }

#line default
#line hidden
            BeginContext(3229, 29, true);
            WriteLiteral("        <link rel=\"canonical\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3258, "\"", 3278, 1);
#line 75 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
WriteAttributeValue("", 3265, canonicalUrl, 3265, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3279, 20, true);
            WriteLiteral(" />\r\n        <title>");
            EndContext();
            BeginContext(3300, 11, false);
#line 76 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3311, 10, true);
            WriteLiteral("</title>\r\n");
            EndContext();
#line 77 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_MetaHeadContent.cshtml"
    }
    catch (Exception ex)
    {
        ex.Message.ToString();
        //LogHelper.Error(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType, "Error rendering MetaHeadContent for page " + Model.CurrentContent.Id, ex);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<totalsmarthomes.Models.ViewModels.Shared.MetaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591