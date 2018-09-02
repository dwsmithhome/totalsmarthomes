using System;
using StoreFront.Model.Base;
using StoreFront.Model.PageModel.Legal;

namespace StoreFront.Model.ViewModel.Legal
{
    public class LegalPageViewModel : BaseViewModel<BaseModel>
    {
        readonly LegalPageModel _currentPage;

        public LegalPageViewModel(LegalPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}
