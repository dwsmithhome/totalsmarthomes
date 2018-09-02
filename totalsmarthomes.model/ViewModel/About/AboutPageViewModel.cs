using System;
using StoreFront.Model.Base;
using StoreFront.Model.PageModel.About;

namespace StoreFront.Model.ViewModel.About
{
    public class AboutPageViewModel : BaseViewModel<BaseModel>
    {
        readonly AboutPageModel _currentPage;

        public AboutPageViewModel(AboutPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}
