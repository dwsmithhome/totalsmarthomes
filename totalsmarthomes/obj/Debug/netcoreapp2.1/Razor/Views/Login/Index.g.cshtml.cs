#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26733bbc60618a7fe31ea2ab54cd6c19bb6d6d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26733bbc60618a7fe31ea2ab54cd6c19bb6d6d33", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15f91252ed8ea7bca016743f14e4e2019886138", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Model.ViewModel.Login.LoginPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PasswordReset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary registration login-submit pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"
  
    Layout = "../Shared/_PageMaster.cshtml";


#line default
#line hidden
            BeginContext(117, 44, true);
            WriteLiteral("<h2 class=\"title\">Login or Register</h2>\r\n\r\n");
            EndContext();
#line 9 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"
 using (Html.BeginForm("Login", "Login", new { ReturnUrl = Context.Request.Query["ReturnUrl"] }, FormMethod.Post))
{


#line default
#line hidden
            BeginContext(282, 251, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n\r\n            <div class=\"row form-row\">\r\n                <label class=\"control-label registrationLabel col-lg-4 col-sm-3 col-xs-12 pull-left\" for=\"Firstname\">Email</label>\r\n\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(534, 787, false);
#line 20 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"
           Write(Html.TextBoxFor(c => c.Email,
                                                            new
                                                            {
                                                                @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-7 registration-textfield pull-left",
                                                                placeholder = "Email",
                                                                maxlength = 50,
                                                                title = "Please enter your email",
                                                                data_toggle = "tooltip"
                                                            }));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(1342, 491, false);
#line 30 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"
           Write(Html.ValidationMessageFor(c => c.Email, "Please enter your username",
                                                                                       new
                                                                                       {
                                                                                           @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-12"
                                                                                       }));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 227, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n            </div>\r\n            <div class=\"row form-row\">\r\n                <label class=\"control-label registrationLabel col-lg-4 col-sm-3 col-xs-12 pull-left\" for=\"Firstname\">Password</label>\r\n\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(2061, 557, false);
#line 45 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"
           Write(Html.PasswordFor(c => c.Password,
                              new
                              {
                                  @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-7 registration-textfield pull-left",
                                  placeholder = "Password",
                                  maxlength = 50,
                                  title = "Please enter your password",
                                  data_toggle = "tooltip"
                              }));

#line default
#line hidden
            EndContext();
            BeginContext(2618, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(2639, 266, false);
#line 55 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"
           Write(Html.ValidationMessageFor(c => c.Password, "Please enter your password",
                              new
                              {
                                  @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-12"
                              }));

#line default
#line hidden
            EndContext();
            BeginContext(2905, 194, true);
            WriteLiteral("\r\n\r\n            </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n\r\n                        <div class=\"col-lg-7 offset-lg-4\">\r\n                            ");
            EndContext();
            BeginContext(3099, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f084d2edf6f542e897d4cf374be4aaa3", async() => {
                BeginContext(3152, 82, true);
                WriteLiteral("\r\n                                Forgotten Password\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3238, 759, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>

            <div class=""row form-row"">
                <div class=""col-lg-11"">
                    <button type=""submit"" class=""btn btn-secondary registration login-submit pull-right"">
                        Log in
                        <span class=""glyphicon glyphicon-chevron-right""></span>
                    </button>
                </div>
            </div>


        </div>
        <div class=""col-lg-6 registerblock"">
            <div class=""row form-row"">
                <div class=""col-lg-11"">
                    If You do not already have an account please click below to get started.
                    <br /><br />
                    ");
            EndContext();
            BeginContext(3997, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185149fcc22d4cc2aefe067413b6eadb", async() => {
                BeginContext(4108, 137, true);
                WriteLiteral("\r\n                        Register\r\n                        <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4249, 78, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            </div>\r\n    </div>\r\n");
            EndContext();
#line 97 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Login/Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.Model.ViewModel.Login.LoginPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
