#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_FavIcon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4513654d799c4de996226d3bd0e12bf974c26662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Meta__FavIcon), @"mvc.1.0.view", @"/Views/Partials/Meta/_FavIcon.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/Meta/_FavIcon.cshtml", typeof(AspNetCore.Views_Partials_Meta__FavIcon))]
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
using StoreFront;

#line default
#line hidden
#line 2 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/_ViewImports.cshtml"
using StoreFront.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4513654d799c4de996226d3bd0e12bf974c26662", @"/Views/Partials/Meta/_FavIcon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15f91252ed8ea7bca016743f14e4e2019886138", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Meta__FavIcon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Model.ViewModel.Shared.MetaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_FavIcon.cshtml"
  
    if (Model.FavIcon != null)
    {

#line default
#line hidden
            BeginContext(126, 33, true);
            WriteLiteral("        <link rel=\"shortcut icon\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 159, "\"", 180, 1);
#line 6 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_FavIcon.cshtml"
WriteAttributeValue("", 166, Model.FavIcon, 166, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(181, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 7 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Partials/Meta/_FavIcon.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.Model.ViewModel.Shared.MetaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591