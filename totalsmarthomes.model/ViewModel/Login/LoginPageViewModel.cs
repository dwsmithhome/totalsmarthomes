using System;
using StoreFront.Model.Base;
using StoreFront.Model.PageModel.Login;

namespace StoreFront.Model.ViewModel.Login
{
    public class LoginPageViewModel : BaseViewModel<BaseModel>
    {
        readonly LoginPageModel _currentPage;

        public LoginPageViewModel(LoginPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string LoginError { get; set; }
    }
}
