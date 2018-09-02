using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using System.Collections.Generic;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.APIModel.Resource;

namespace StoreFront.Model.PageModel.Checkout
{
    public class CheckoutPageModel : BaseModel, IContent
    {
        public IEnumerable<BasketListItem> Basket { get; set;  }
        public APIModel.Customer.DeliveryAddress DeliveryAddress { get; set; }
        public APIModel.Customer.InvoiceAddress InvoiceAddress { get; set; }
        public BasketDelivery SelectedBasketDelivery { get; set; }
        public DeliveryOption DeliveryOption { get; set; }
    }
}
