using System;
using System.Collections.Generic;
using System.Linq;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.APIModel.Resource;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Checkout;

namespace StoreFront.Model.ViewModel.Checkout
{
    public class CheckoutPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly CheckoutPageModel _currentPage;

        public CheckoutPageViewModel(CheckoutPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public IEnumerable<BasketListItem> Basket { get { return _currentPage.Basket; } }

        public decimal BasketValue { get { return _currentPage.Basket.Sum(x => x.Price * x.Quantity); }}

        public BasketDelivery SelectedBasketDelivery { get { return _currentPage.SelectedBasketDelivery;  } }

        public decimal DeliveryValue { get { return _currentPage.SelectedBasketDelivery.Value; } }

        public APIModel.Customer.DeliveryAddress DeliveryAddress { get { return _currentPage.DeliveryAddress; }}

        public DeliveryOption DeliveryOption { get { return _currentPage.DeliveryOption; } }

        public decimal TotalValue { get { return BasketValue + DeliveryValue; }}

        public APIModel.Customer.InvoiceAddress InvoiceAddress { get{ return _currentPage.InvoiceAddress; } }
    }
}
