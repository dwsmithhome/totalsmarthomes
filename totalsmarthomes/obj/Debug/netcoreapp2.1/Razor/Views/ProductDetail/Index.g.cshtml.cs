#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d551d87b25041c10a6384788248200ac936a119f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Index), @"mvc.1.0.view", @"/Views/ProductDetail/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductDetail/Index.cshtml", typeof(AspNetCore.Views_ProductDetail_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d551d87b25041c10a6384788248200ac936a119f", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15f91252ed8ea7bca016743f14e4e2019886138", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Model.ViewModel.ProductDetail.ProductDetailPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
  
    Layout = "../Shared/_PageMaster.cshtml";

#line default
#line hidden
            BeginContext(131, 22, true);
            WriteLiteral("\r\n\r\n<h2 class=\"title\">");
            EndContext();
            BeginContext(154, 19, false);
#line 8 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
             Write(Model.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(173, 183, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    \r\n    <div class=\"col-lg-6\">\r\n\r\n\r\n        <div class=\"fotorama\" data-nav=\"thumbs\" data-allowfullscreen=\"native\" data-keyboard=\"true\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 356, "\"", 440, 5);
            WriteAttributeValue("", 362, "/Images/Product/", 362, 16, true);
#line 16 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
WriteAttributeValue("", 378, Model.Product.ProductCode, 378, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 404, "/", 404, 1, true);
            WriteAttributeValue("", 405, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                   
                BeginContext(408, 25, false);
#line 16 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
                                                              Write(Model.Product.ProductCode);

#line default
#line hidden
                EndContext();
                                                                                                             
                PopWriter();
            }
            ), 405, 29, false);
            WriteAttributeValue("", 434, "_1.jpg", 434, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 441, "\"", 467, 1);
#line 16 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
WriteAttributeValue("", 447, Model.Product.Title, 447, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(468, 19, true);
            WriteLiteral(">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 487, "\"", 571, 5);
            WriteAttributeValue("", 493, "/Images/Product/", 493, 16, true);
#line 17 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
WriteAttributeValue("", 509, Model.Product.ProductCode, 509, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 535, "/", 535, 1, true);
            WriteAttributeValue("", 536, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                   
                BeginContext(539, 25, false);
#line 17 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
                                                              Write(Model.Product.ProductCode);

#line default
#line hidden
                EndContext();
                                                                                                             
                PopWriter();
            }
            ), 536, 29, false);
            WriteAttributeValue("", 565, "_2.jpg", 565, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 572, "\"", 598, 1);
#line 17 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
WriteAttributeValue("", 578, Model.Product.Title, 578, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(599, 19, true);
            WriteLiteral(">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 618, "\"", 702, 5);
            WriteAttributeValue("", 624, "/Images/Product/", 624, 16, true);
#line 18 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
WriteAttributeValue("", 640, Model.Product.ProductCode, 640, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 666, "/", 666, 1, true);
            WriteAttributeValue("", 667, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                   
                BeginContext(670, 25, false);
#line 18 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
                                                              Write(Model.Product.ProductCode);

#line default
#line hidden
                EndContext();
                                                                                                             
                PopWriter();
            }
            ), 667, 29, false);
            WriteAttributeValue("", 696, "_3.jpg", 696, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 703, "\"", 729, 1);
#line 18 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
WriteAttributeValue("", 709, Model.Product.Title, 709, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(730, 125, true);
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-6 filterrow\">\r\n        <div class=\"productDescription\">\r\n            ");
            EndContext();
            BeginContext(856, 25, false);
#line 24 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
       Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(881, 44, true);
            WriteLiteral("\r\n            </div>\r\n        <br /><br />\r\n");
            EndContext();
#line 27 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
         using (Html.BeginForm("Add", "ProductDetail", FormMethod.Post))
{
        

#line default
#line hidden
            BeginContext(1011, 232, false);
#line 29 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
   Write(Html.DropDownListFor(x => x.Quantity, Model.QuantityList, new { @style = "width:70px !important; height:40px !important;line-height: 1;background: url(https://www.totalsmarthomes.com/Images/down.jpg) 90% / 19% no-repeat #ffffff;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 40, false);
#line 30 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
   Write(Html.HiddenFor(x => x.Product.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 81, true);
            WriteLiteral("        <br />\r\n        <br />\r\n        <div>\r\n\r\n            <h5 class=\"price\"> £");
            EndContext();
            BeginContext(1378, 28, false);
#line 35 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
                           Write(Model.Price.ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 3403, true);
            WriteLiteral(@" </h5>

            <button type=""submit"" class=""btn btn-secondary registration"">
                Add to basket
                <span class=""glyphicon glyphicon-chevron-right""></span>
            </button>

            <div id=""tabs"" class=""tabs container"">
                <ul class=""nav nav-tabs"">
                    <li class=""active"">
                        <a href=""#tabs-1"" data-toggle=""tab"" class=""nav-link"">
                            Product Details
                        </a>
                    </li>
                    <li><a href=""#tabs-2"" data-toggle=""tab"" class=""nav-link "">Specification</a></li>
                    <li><a href=""#tabs-3"" data-toggle=""tab"" class=""nav-link "">Aenean lacinia</a></li>
                </ul>
                <div id=""tabs-1"" class=""tabPanel"">
                    <p>Proin elit arcu, rutrum commodo, vehicula tempus, commodo a, risus. Curabitur nec arcu. Donec sollicitudin mi sit amet mauris. Nam elementum quam ullamcorper ante. Etiam aliquet massa et lor");
            WriteLiteral(@"em. Mauris dapibus lacus auctor risus. Aenean tempor ullamcorper leo. Vivamus sed magna quis ligula eleifend adipiscing. Duis orci. Aliquam sodales tortor vitae ipsum. Aliquam nulla. Duis aliquam molestie erat. Ut et mauris vel pede varius sollicitudin. Sed ut dolor nec orci tincidunt interdum. Phasellus ipsum. Nunc tristique tempus lectus.</p>
                </div>
                <div id=""tabs-2"" class=""tabPanel"">

                    <p>Morbi tincidunt, dui sit amet facilisis feugiat, odio metus gravida ante, ut pharetra massa metus id nunc. Duis scelerisque molestie turpis. Sed fringilla, massa eget luctus malesuada, metus eros molestie lectus, ut tempus eros massa ut dolor. Aenean aliquet fringilla sem. Suspendisse sed ligula in ligula suscipit aliquam. Praesent in eros vestibulum mi adipiscing adipiscing. Morbi facilisis. Curabitur ornare consequat nunc. Aenean vel metus. Ut posuere viverra nulla. Aliquam erat volutpat. Pellentesque convallis. Maecenas feugiat, tellus pellentesque pretium posuere, ");
            WriteLiteral(@"felis lorem euismod felis, eu ornare leo nisi vel felis. Mauris consectetur tortor et purus.</p>
                </div>
                <div id=""tabs-3"" class=""tabPanel"">
                    <p>Mauris eleifend est et turpis. Duis id erat. Suspendisse potenti. Aliquam vulputate, pede vel vehicula accumsan, mi neque rutrum erat, eu congue orci lorem eget lorem. Vestibulum non ante. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce sodales. Quisque eu urna vel enim commodo pellentesque. Praesent eu risus hendrerit ligula tempus pretium. Curabitur lorem enim, pretium nec, feugiat nec, luctus a, lacus.</p>
                    <p>Duis cursus. Maecenas ligula eros, blandit nec, pharetra at, semper at, magna. Nullam ac lacus. Nulla facilisi. Praesent viverra justo vitae neque. Praesent blandit adipiscing velit. Suspendisse potenti. Donec mattis, pede vel pharetra blandit, magna ligula faucibus eros, id euismod lacus dolor eget odio. Nam scelerisque. Donec non libero");
            WriteLiteral(@" sed nulla mattis commodo. Ut sagittis. Donec nisi lectus, feugiat porttitor, tempor ac, tempor vitae, pede. Aenean vehicula velit eu tellus interdum rutrum. Maecenas commodo. Pellentesque nec elit. Fusce in lacus. Vivamus a libero vitae lectus hendrerit hendrerit.</p>
                </div>
            </div>
        </div>
");
            EndContext();
#line 65 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/ProductDetail/Index.cshtml"
}

#line default
#line hidden
            BeginContext(4812, 22, true);
            WriteLiteral("        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.Model.ViewModel.ProductDetail.ProductDetailPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591