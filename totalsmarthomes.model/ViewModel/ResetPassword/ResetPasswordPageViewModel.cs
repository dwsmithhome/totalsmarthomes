using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.ResetPassword;

namespace StoreFront.Model.ViewModel.ResetPassword
{
    public class ResetPasswordPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly ResetPasswordPageModel _currentPage;

        public ResetPasswordPageViewModel(ResetPasswordPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}
