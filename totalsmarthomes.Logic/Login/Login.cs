using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Login;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.Login;
using StoreFront.Service.Base;
using StoreFront.Service.Security;

namespace StoreFront.Service.Login
{
    public class Login : BasePage, IPage<LoginPageViewModel, LoginPageModel>
    {

        public ISAL<Model.APIModel.Customer.Security> _securitySAL;
        public IHttpContextAccessor _httpContextAccessor;
        public IActionSAL<BasketTransfer> _basketTransferSAL;

        public Login(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor,
                     ISAL<Model.APIModel.Customer.Security> securitySAL, IActionSAL<BasketTransfer> basketTransferSAL) : base(page, basketService, httpContextAccessor)
        {
            _securitySAL = securitySAL;
            _basketTransferSAL = basketTransferSAL;
            _httpContextAccessor = httpContextAccessor;
        }

        public LoginPageViewModel Load(params SearchParameter[] list)
        {

            var loginPageModel = new LoginPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new LoginPageViewModel(loginPageModel);
        }

        public LoginPageViewModel Load(BaseModel model)
        {
            return new LoginPageViewModel((LoginPageModel)model);
        }

        public DataResponse Process(LoginPageModel model)
        {
            var security = _securitySAL.Search(new List<SearchParameter>{
                new  SearchParameter{
                    Name = "Username",
                    Value = Encryption.EncryptString(model.Email)
                },
                new  SearchParameter{
                    Name = "Password",
                    Value = Encryption.EncryptString(model.Password)
                }
            });

            if (security != null)
            {
                if (security.Any())
                {
                    var user = security.FirstOrDefault();

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.CustomerID.ToString()),
                        new Claim(ClaimTypes.Role, "Administrator"),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new Microsoft.AspNetCore.Authentication.AuthenticationProperties
                    {
                        //AllowRefresh = <bool>,
                        // Refreshing the authentication session should be allowed.

                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                        // The time at which the authentication ticket expires. A 
                        // value set here overrides the ExpireTimeSpan option of 
                        // CookieAuthenticationOptions set with AddCookie.

                        IsPersistent = true,
                        // Whether the authentication session is persisted across 
                        // multiple requests. Required when setting the 
                        // ExpireTimeSpan option of CookieAuthenticationOptions 
                        // set with AddCookie. Also required when setting 
                        // ExpiresUtc.

                        //IssuedUtc = <DateTimeOffset>,
                        // The time at which the authentication ticket was issued.

                        //RedirectUri = <string>
                        // The full path or absolute URI to be used as an http 
                        // redirect response value.
                    };

                    _httpContextAccessor.HttpContext.SignInAsync(
                       CookieAuthenticationDefaults.AuthenticationScheme,
                       new ClaimsPrincipal(claimsIdentity),
                       authProperties);

                    _basketTransferSAL.Post(new BasketTransfer{
                        CustomerID = user.CustomerID,
                        BasketGUID = GUID
                    });

                    return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
                }


            }

            return new DataResponse() { Type = Model.Enum.Response.DataResponseType.UNAUTHENTICATED, Details = ""};
        }
    }
}
