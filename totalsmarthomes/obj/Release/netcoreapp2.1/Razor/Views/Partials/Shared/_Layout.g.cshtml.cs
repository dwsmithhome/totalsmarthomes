#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c132f28d0943dc37fb111eb6356b42da37f6d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Shared__Layout), @"mvc.1.0.view", @"/Views/Partials/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Partials_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c132f28d0943dc37fb111eb6356b42da37f6d8", @"/Views/Partials/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2e1390cd8c83cc01f942112e65ad5a672614e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efff2469f3d44826b27273d9080af99f", async() => {
                BeginContext(31, 119, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                EndContext();
                BeginContext(151, 13, false);
#line 6 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(164, 35, true);
                WriteLiteral(" - My ASP.NET Application</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(293, 1319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf8a4af3ac84c629de6696ad1080ce2", async() => {
                BeginContext(299, 449, true);
                WriteLiteral(@"
    <div class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                ");
                EndContext();
                BeginContext(749, 104, false);
#line 19 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
           Write(Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" }));

#line default
#line hidden
                EndContext();
                BeginContext(853, 143, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li>");
                EndContext();
                BeginContext(997, 40, false);
#line 23 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
                   Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1037, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(1069, 41, false);
#line 24 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
                   Write(Html.ActionLink("About", "About", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1110, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(1142, 45, false);
#line 25 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
                   Write(Html.ActionLink("Contact", "Contact", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1187, 128, true);
                WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container body-content\">\r\n        ");
                EndContext();
                BeginContext(1316, 12, false);
#line 31 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1328, 58, true);
                WriteLiteral("\r\n        <hr />\r\n        <footer>\r\n            <p>&copy; ");
                EndContext();
                BeginContext(1387, 17, false);
#line 34 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Shared/_Layout.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(1404, 64, true);
                WriteLiteral(" - My ASP.NET Application</p>\r\n        </footer>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1612, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
