using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Profile;

namespace StoreFront.Model.ViewModel.Profile
{
    public class ProfilePageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly ProfilePageModel _currentPage;

        public ProfilePageViewModel(ProfilePageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}
