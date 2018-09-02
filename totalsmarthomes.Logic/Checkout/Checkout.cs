using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Checkout;
using StoreFront.Model.ViewModel.Checkout;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.APIModel.Purchase;
using System.Collections.Generic;
using StoreFront.Model.APIModel.Resource;
using StoreFront.Model.Response;

namespace StoreFront.Service.Checkout
{
    public class Checkout : BasePage, IPage<CheckoutPageViewModel, CheckoutPageModel>
    {
        IListSAL<BasketListItem> _basketListItemSAL;
        IHttpContextAccessor _httpContextAccessor;
        ISAL<Model.APIModel.Customer.DeliveryAddress> _deliveryAddressSAL;
        ISAL<Model.APIModel.Customer.InvoiceAddress> _invoiceAddressSAL;
        ISAL<BasketDelivery> _basketDeliverySAL;
        ISAL<DeliveryOption> _deliveryOptionSAL;

        public Checkout(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, 
                        IHttpContextAccessor httpContextAccessor, 
                        IListSAL<BasketListItem> basketListItemSAL, 
                        ISAL<Model.APIModel.Customer.DeliveryAddress> deliveryAddressSAL,
                        ISAL<Model.APIModel.Customer.InvoiceAddress> invoiceAddressSAL,
                        ISAL<BasketDelivery> basketDeliverySAL, 
                        ISAL<DeliveryOption> deliveryOptionSAL) : base(page, basketService, httpContextAccessor)
        {
            _basketListItemSAL = basketListItemSAL;
            _httpContextAccessor = httpContextAccessor;
            _deliveryAddressSAL = deliveryAddressSAL;
            _basketDeliverySAL = basketDeliverySAL;
            _deliveryOptionSAL = deliveryOptionSAL;
            _invoiceAddressSAL = invoiceAddressSAL;
        }

        public CheckoutPageViewModel Load(params SearchParameter[] list)
        {

            var checkoutPageModel = new CheckoutPageModel
            {
                Content = (Model.Content.Content)_model
            };

            checkoutPageModel.Basket = _basketListItemSAL.Search(
                new List<SearchParameter>{
                new SearchParameter{
                    Name = "CustomerID",
                    Value = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name)
                }
            });

            checkoutPageModel.InvoiceAddress = _invoiceAddressSAL.Get(_httpContextAccessor.HttpContext.User.Identity.Name);
            checkoutPageModel.DeliveryAddress = _deliveryAddressSAL.Get(_httpContextAccessor.HttpContext.User.Identity.Name);
            checkoutPageModel.SelectedBasketDelivery = _basketDeliverySAL.Get(_httpContextAccessor.HttpContext.User.Identity.Name);
            checkoutPageModel.DeliveryOption = _deliveryOptionSAL.Get(checkoutPageModel.SelectedBasketDelivery.DeliveryOptionID.ToString());

            return new CheckoutPageViewModel(checkoutPageModel);
        }

        public CheckoutPageViewModel Load(BaseModel model)
        {
            return new CheckoutPageViewModel((CheckoutPageModel)model);
        }

        public DataResponse Process(CheckoutPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
