#pragma checksum "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8871f48a36526b8e54b594ab142ac7c6639485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Register/Index.cshtml", typeof(AspNetCore.Views_Register_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8871f48a36526b8e54b594ab142ac7c6639485", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15f91252ed8ea7bca016743f14e4e2019886138", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Model.ViewModel.Register.RegisterPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
  
    Layout = "../Shared/_PageMaster.cshtml";

#line default
#line hidden
            BeginContext(121, 598, true);
            WriteLiteral(@"<script src=""/js/crafty_postcode.class.js""></script>
<script type=""text/javascript"">
var cp_obj = CraftyPostcodeCreate();
cp_obj.set(""access_token"", ""xxxxx-xxxxx-xxxxx-xxxxx""); // your token here
cp_obj.set(""result_elem_id"", ""crafty_postcode_result_display"");
cp_obj.set(""form"", ""address"");
cp_obj.set(""elem_company"", ""companyname"");
cp_obj.set(""elem_street1"", ""Address1"");
cp_obj.set(""elem_street2"", ""Address2"");
cp_obj.set(""elem_street3"", ""Address3"");
cp_obj.set(""elem_town"", ""Town"");
cp_obj.set(""elem_postcode"", ""Postcode"");





</script>

<h2 class=""title"">Register</h2>

");
            EndContext();
#line 27 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
 using (Html.BeginForm("Register", "Register", FormMethod.Post, new { @id = "address", @name = "address" }))
{

#line default
#line hidden
            BeginContext(832, 659, true);
            WriteLiteral(@"    <div class=""row align-bottom"">
        <div class=""col-lg-12"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""text-info text-right col-lg-12  col-md-7 col-sm-7 col-xs-12  registration-requiredfields align-bottom pull-right"">
                        All fields are required
                    </div>
                </div>
            </div>
            <div class=""row registrationrow"">
                <div class=""col-lg-12"">
                    <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"" for=""Firstname"">First Name</label>
                    ");
            EndContext();
            BeginContext(1492, 344, false);
#line 41 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.TextBoxFor(x => x.ForeName,
   new
   {
       @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
       placeholder = "First name",
       maxlength = 50,
       title = "Please enter your first name",
       data_toggle = "tooltip"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(1861, 159, false);
#line 51 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.ForeName, "Please enter your first name",
   new
   {
       @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-4"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(2020, 298, true);
            WriteLiteral(@"

                </div>
            </div>

            <div class=""row registrationrow"">
                <div class=""col-lg-12"">
                    <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"" for=""Firstname"">Last Name</label>
                    ");
            EndContext();
            BeginContext(2319, 341, false);
#line 63 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.TextBoxFor(x => x.SurName,
   new
   {
       @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
       placeholder = "Last name",
       maxlength = 50,
       title = "Please enter your last name",
       data_toggle = "tooltip"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(2660, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(2685, 158, false);
#line 73 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.ForeName, "Please enter your last name",
   new
   {
       @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-4"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(2843, 296, true);
            WriteLiteral(@"

                </div>
            </div>


            <div class=""row registrationrow"">
                <div class=""col-lg-12"">
                    <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"" for=""Firstname"">Email</label>
                    ");
            EndContext();
            BeginContext(3140, 334, false);
#line 86 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.TextBoxFor(x => x.Email,
   new
   {
       @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
       placeholder = "Email",
       maxlength = 50,
       title = "Please enter email address",
       data_toggle = "tooltip"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(3474, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(3499, 151, false);
#line 96 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Email, "Please enter your email",
   new
   {
       @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-4"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(3650, 303, true);
            WriteLiteral(@"

                </div>
            </div>



            <div class=""row registrationrow"">
                <div class=""col-lg-12"">

                    <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"" for=""Firstname"">Postcode</label>
                    ");
            EndContext();
            BeginContext(3954, 325, false);
#line 111 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.TextBoxFor(x => x.Postcode,
   new
   {
       @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-3 registration-textfield pull-left",
       placeholder = "Postcode",
       maxlength = 50,
       title = "Postcode",
       data_toggle = "tooltip",

   }));

#line default
#line hidden
            EndContext();
            BeginContext(4279, 192, true);
            WriteLiteral("\r\n\r\n                    <button type=\"button\" onclick=\"cp_obj.doLookup();DisplayAddress()\" class=\"btn btn-secondary registration findAddress \">Find Address</button><br />\r\n                    ");
            EndContext();
            BeginContext(4472, 175, false);
#line 123 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Postcode, "You must enter a postcode and select an address.",
new
{
@class = "error col-xs-12 col-sm-12 col-md-12 col-lg-9 offset-lg-3"
}));

#line default
#line hidden
            EndContext();
            BeginContext(4647, 792, true);
            WriteLiteral(@"

                    <input type=""hidden"" name=""companyname"" /><br />



                </div>
            </div>



            <div id=""Address"" style=""display:none;"">
                <div class=""row registrationrow"">
                    <div class=""col-lg-12"">
                        <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left""></label>
                        <span id=""crafty_postcode_result_display"">&nbsp;</span><br />
                    </div>
                </div>
                <div class=""row registrationrow"">
                    <div class=""col-lg-12"">
                        <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"">Invoice Address</label>
                        ");
            EndContext();
            BeginContext(5440, 295, false);
#line 148 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Address1,
new
{
 @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
 placeholder = "",
 maxlength = 50,
 title = "",
 data_toggle = "tooltip",
 @readonly = "readonly"

}));

#line default
#line hidden
            EndContext();
            BeginContext(5735, 27, true);
            WriteLiteral("\r\n                         ");
            EndContext();
            BeginContext(5763, 94, false);
#line 159 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                    Write(Html.ValidationMessageFor(x => x.Address1, "You must enter a postcode and select an address."));

#line default
#line hidden
            EndContext();
            BeginContext(5857, 293, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""row registrationrow"">
                    <div class=""col-lg-12"">
                        <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left""></label>
                        ");
            EndContext();
            BeginContext(6151, 281, false);
#line 165 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Address2,
new
{
@class = "registration-form-control  input-lg primary-input  col-xs-12 col-sm-10 col-md-10 col-lg-3 registration-textfield pull-left",
placeholder = "",
maxlength = 50,
title = "",
data_toggle = "tooltip",
@readonly = "readonly"

}));

#line default
#line hidden
            EndContext();
            BeginContext(6432, 298, true);
            WriteLiteral(@"


                    </div>
                </div>
                <div class=""row  registrationrow"">
                    <div class=""col-lg-12"">
                        <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left""></label>
                        ");
            EndContext();
            BeginContext(6731, 279, false);
#line 183 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Address3,
new
{
@class = "registration-form-control  input-lg primary-input  col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
placeholder = "",
maxlength = 50,
title = "",
data_toggle = "tooltip",
@readonly = "readonly"
}));

#line default
#line hidden
            EndContext();
            BeginContext(7010, 295, true);
            WriteLiteral(@"

                    </div>
                </div>
                <div class=""row registrationrow"">
                    <div class=""col-lg-12"">
                        <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left""></label>
                        ");
            EndContext();
            BeginContext(7306, 285, false);
#line 199 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Town,
new
{
@class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
placeholder = "",
maxlength = 50,
title = "",
data_toggle = "tooltip",
@readonly = "readonly"

}));

#line default
#line hidden
            EndContext();
            BeginContext(7591, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(7618, 90, false);
#line 210 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Town, "You must enter a postcode and select an address."));

#line default
#line hidden
            EndContext();
            BeginContext(7708, 305, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row registrationrow"">
                <div class=""col-lg-12"">
                    <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"">Password</label>
                    ");
            EndContext();
            BeginContext(8014, 287, false);
#line 217 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.PasswordFor(x => x.Password,
new
{
 @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
 placeholder = "Password",
 maxlength = 50,
 title = "Password",
 data_toggle = "tooltip",

}));

#line default
#line hidden
            EndContext();
            BeginContext(8301, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(8324, 154, false);
#line 227 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
               Write(Html.ValidationMessageFor(x => x.Email, "Please enter your Password",
   new
   {
       @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-4"
   }));

#line default
#line hidden
            EndContext();
            BeginContext(8478, 724, true);
            WriteLiteral(@"


                </div>
            </div>
            <div class=""row registrationrow"">
                <div class=""col-lg-12"">
                    <div class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left piSpacer""></div>
                    <div class=""col-lg-9"">
                        <span id=""passwordstrengthindicator""></span>
                    </div>

                    </div>
                </div>
                    <div class=""row registrationrow"">
                        <div class=""col-lg-12"">
                            <label class=""control-label registrationLabel col-lg-3 col-sm-3 col-xs-12 pull-left"">Repeat Password</label>
                            ");
            EndContext();
            BeginContext(9203, 362, false);
#line 248 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                       Write(Html.PasswordFor(x => x.RepeatPassword,
     new
     {
         @class = "registration-form-control  input-lg primary-input required col-xs-12 col-sm-10 col-md-10 col-lg-4 registration-textfield pull-left",
         placeholder = "Repeat Password",
         maxlength = 50,
         title = "Repeat Password",
         data_toggle = "tooltip",

     }));

#line default
#line hidden
            EndContext();
            BeginContext(9565, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(9596, 189, false);
#line 258 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Email, "Please re-enter your password",
           new
           {
               @class = "error col-xs-12 col-sm-12 col-md-12 col-lg-4"
           }));

#line default
#line hidden
            EndContext();
            BeginContext(9785, 565, true);
            WriteLiteral(@"

                        </div>
                    </div>

                    <div class=""row registrationrow"">
                        <div class=""col-lg-12"">

                            <button type=""submit"" class=""btn btn-secondary registration login-submit pull-right"">
                                Register
                                <span class=""glyphicon glyphicon-chevron-right""></span>
                            </button>

                        </div>
                    </div>

                </div>
            </div>
");
            EndContext();
#line 280 "/Users/Dave/Projects/totalsmarthomes/totalsmarthomes/Views/Register/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(10365, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.Model.ViewModel.Register.RegisterPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
