using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Confirmation;

namespace StoreFront.Model.ViewModel.Confirmation
{
    public class ConfirmationPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly ConfirmationPageModel _currentPage;

        public ConfirmationPageViewModel(ConfirmationPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public string TransactionID { get { return _currentPage.TransactionID; } set { _currentPage.TransactionID = value; }}
    }
}
