using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Brand;

namespace StoreFront.Model.ViewModel.Brand
{
    public class BrandPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly BrandPageModel _currentPage;

        public BrandPageViewModel(BrandPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}
