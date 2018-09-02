using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.Payment
{
    public class PaymentPageModel : BaseModel, IContent
    {
        public decimal PurchaseValue { get; set; }
        public string CardholderName { get; internal set; }
        public string CardNumber { get; internal set; }
        public string ExpiryDate { get; internal set; }
        public string SECCode { get; internal set; }
    }
}
