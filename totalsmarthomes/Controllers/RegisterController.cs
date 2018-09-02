using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.APIModel.Customer;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Register;
using StoreFront.Model.ViewModel.Register;
using StoreFront.Service.Security;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace totalsmarthomes.Controllers
{
    public class RegisterController : Controller
    {
        IPage<RegisterPageViewModel, RegisterPageModel> _page;

        ISAL<Customer> _customerService;
        ISAL<Security> _securityService;
        ISAL<StoreFront.Model.APIModel.Customer.InvoiceAddress> _invoiceAddressService;
        ISAL<Contact> _contactService;
        IActionSAL<BasketTransfer> _transferService;

        public RegisterController(IPage<RegisterPageViewModel, RegisterPageModel> page, ISAL<Customer> customerService, ISAL<Security> securityService, ISAL<StoreFront.Model.APIModel.Customer.InvoiceAddress> invoiceAddressService, ISAL<Contact> contactService, IActionSAL<BasketTransfer> transferService)
        {
            _page = page;

            _customerService = customerService;
            _securityService = securityService;
            _invoiceAddressService = invoiceAddressService;
            _contactService = contactService;
            _transferService = transferService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_page.Load());
        }

        public IActionResult Register(RegisterPageModel model)
        {
            if(ModelState.IsValid)
            {
                var customer = _customerService.Post(new Customer
                {
                    Forename = model.ForeName,
                    Surname = model.SurName,
                });

                if(customer.Type == StoreFront.Model.Enum.Response.DataResponseType.SUCCESS){
                    var customerID = Int32.Parse(customer.Details);


                    var addressStatus = _invoiceAddressService.Post(new StoreFront.Model.APIModel.Customer.InvoiceAddress
                    {
                        CustomerID = customerID,
                        Address1 = model.Address1,
                        Address2 = model.Address2 ?? "",
                        Address3 = model.Address3 ?? "",
                        Address4 = model.Town,
                        Address5 = "",
                        Postcode = model.Postcode
                        
                    });

                    var contactStatus = _contactService.Post(new Contact
                    {
                        CustomerID = customerID,
                        Value = model.Email,
                        ContactTypeID = 1
                    });


                    var securityStatus = _securityService.Post(new Security
                    {
                        CustomerID = customerID,
                        Username = Encryption.EncryptString(model.Email),
                        Password = Encryption.EncryptString(model.Password)
                    });


                    var page = (StoreFront.Service.Register.Register)_page;
                    var transferStatus = _transferService.Post(new BasketTransfer
                    {
                        BasketGUID = page.GUID,
                        CustomerID = customerID
                    });



                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, customerID.ToString()),
                        new Claim(ClaimTypes.Role, "Administrator"),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
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

                    HttpContext.SignInAsync(
                       CookieAuthenticationDefaults.AuthenticationScheme,
                       new ClaimsPrincipal(claimsIdentity),
                       authProperties);

                    return RedirectToAction("Index", "Delivery");
                }
                }

            return View("Index", _page.Load(model));

            }
        }
    }

