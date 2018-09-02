using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Payment;

namespace StoreFront.Model.ViewModel.Payment
{
    public class PaymentPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly PaymentPageModel _currentPage;

        public PaymentPageViewModel(PaymentPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public decimal PurchaseValue { get { return _currentPage.PurchaseValue; } set { _currentPage.PurchaseValue = value;  }}

        public string CardholderName { get { return _currentPage.CardholderName; } set { _currentPage.CardholderName = value; } }

        public string CardNumber { get { return _currentPage.CardNumber; } set { _currentPage.CardNumber = value; } }

        public string ExpiryDate { get { return _currentPage.ExpiryDate; } set { _currentPage.ExpiryDate = value; } }

        public string SECCode { get { return _currentPage.SECCode; } set { _currentPage.SECCode = value; } }
    }
}
