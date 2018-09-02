using System;
using StoreFront.Model.Base;
using StoreFront.Model.PageModel.Account;

namespace StoreFront.Model.ViewModel.Account
{
    public class AccountPageViewModel : BaseViewModel<BaseModel>
    {
        readonly AccountPageModel _currentPage;

        public AccountPageViewModel(AccountPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}

