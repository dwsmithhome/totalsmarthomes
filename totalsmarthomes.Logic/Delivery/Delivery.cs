using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using StoreFront.Model.APIModel.Customer;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.APIModel.Resource;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Delivery;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.Delivery;
using StoreFront.Service.Base;

namespace StoreFront.Service.Delivery
{
    public class Delivery : BasePage, IPage<DeliveryPageViewModel, DeliveryPageModel>
    {
        ISAL<Model.APIModel.Customer.InvoiceAddress> _invoiceAddressService;
        ISAL<Model.APIModel.Customer.DeliveryAddress> _deliveryAddressService;
        ISAL<DeliveryOption> _deliveryOptionSAL;
        ISAL<BasketDelivery> _basketDeliverySAL;
        IHttpContextAccessor _httpContextAccessor;
        IConfiguration _configuration;


        public Delivery(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor, ISAL<Model.APIModel.Customer.InvoiceAddress> invoiceAddressService, ISAL<Model.APIModel.Customer.DeliveryAddress> deliveryAddressService, ISAL<DeliveryOption> deliveryOptionSAL, IConfiguration configuration, ISAL<BasketDelivery> basketDeliverySAL) : base(page, basketService, httpContextAccessor)
        {
            _invoiceAddressService = invoiceAddressService;
            _deliveryAddressService = deliveryAddressService;
            _httpContextAccessor = httpContextAccessor;
            _deliveryOptionSAL = deliveryOptionSAL;
            _basketDeliverySAL = basketDeliverySAL;
            _configuration = configuration;
        }

        public DeliveryPageViewModel Load(params SearchParameter[] list)
        {

            var deliveryPageModel = new DeliveryPageModel
            {
                Content = (Model.Content.Content)_model
            };

            var options = _deliveryOptionSAL.Search(new List<SearchParameter>{
                new SearchParameter{
                    Name = "CountryID",
                    Value = _configuration["CountryID"]
                }
            });

            var customerID = _httpContextAccessor.HttpContext.User.Identity.Name;

            var invoiceAddress = _invoiceAddressService.Get(customerID);

            deliveryPageModel.UserInvoiceAddress = true;
            deliveryPageModel.InvoiceAddress1 = invoiceAddress.Address1;
            deliveryPageModel.InvoiceAddress2 = invoiceAddress.Address2;
            deliveryPageModel.InvoiceAddress3 = invoiceAddress.Address3;
            deliveryPageModel.InvoiceAddress4 = invoiceAddress.Address4;
            deliveryPageModel.Postcode = invoiceAddress.Postcode;
            deliveryPageModel.DeliveryOptions = options;

            return new DeliveryPageViewModel(deliveryPageModel);
        }

        public DataResponse Process(DeliveryPageModel model)
        {

            var deliveryOptionExists = _basketDeliverySAL.Search(new List<SearchParameter>{
                new SearchParameter{
                    Name = "CustomerID",
                    Value = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name)
                }
            });


            var deliveryOptionPrice = _deliveryOptionSAL.Get(model.DeliverySelection.ToString()).Price;

            if (!deliveryOptionExists.Any())
            {
                _basketDeliverySAL.Post(new BasketDelivery
                {
                    DeliveryOptionID = model.DeliverySelection,
                    CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                    Value = deliveryOptionPrice
                });
            }
            else
            {
                _basketDeliverySAL.Put(new BasketDelivery
                {
                    DeliveryOptionID = model.DeliverySelection,
                    CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                    Value = deliveryOptionPrice
                }, deliveryOptionExists.FirstOrDefault().CustomerID.ToString());
            }
                 
            var addressExists = _deliveryAddressService.Get(_httpContextAccessor.HttpContext.User.Identity.Name);
            if(model.UserInvoiceAddress)
            {
                
                if (addressExists == null)
                {
                    _deliveryAddressService.Post(new Model.APIModel.Customer.DeliveryAddress
                    {
                        CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                        Address1 = model.InvoiceAddress1,
                        Address2 = model.InvoiceAddress2,
                        Address3 = model.InvoiceAddress3,
                        Address4 = model.InvoiceAddress4,
                        Address5 = "",
                        Postcode = model.Postcode
                    });
                }
                else
                {
                    _deliveryAddressService.Put(new Model.APIModel.Customer.DeliveryAddress
                    {
                        CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                        Address1 = model.InvoiceAddress1,
                        Address2 = model.InvoiceAddress2,
                        Address3 = model.InvoiceAddress3,
                        Address4 = model.InvoiceAddress4,
                        Address5 = "",
                        Postcode = model.Postcode
                    }, _httpContextAccessor.HttpContext.User.Identity.Name);
                }
            }

            if(model.NewAddress)
            {
                if (addressExists == null)
                {
                    _deliveryAddressService.Post(new Model.APIModel.Customer.DeliveryAddress
                    {
                        CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                        Address1 = model.DeliveryAddress1,
                        Address2 = model.DeliveryAddress2,
                        Address3 = model.DeliveryAddress3,
                        Address4 = model.DeliveryAddress4,
                        Address5 = "",
                        Postcode = model.DeliveryPostcode
                    });
                }
                else
                {
                    _deliveryAddressService.Put(new Model.APIModel.Customer.DeliveryAddress
                    {
                        CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                        Address1 = model.DeliveryAddress1,
                        Address2 = model.DeliveryAddress2,
                        Address3 = model.DeliveryAddress3,
                        Address4 = model.DeliveryAddress4,
                        Address5 = "",
                        Postcode = model.DeliveryPostcode
                    }, _httpContextAccessor.HttpContext.User.Identity.Name);
                }
            }

            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }

        public DeliveryPageViewModel Load(BaseModel model)
        {
            return new DeliveryPageViewModel((DeliveryPageModel)model);
        }
    }
}
