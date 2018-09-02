using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Order;

namespace StoreFront.Model.ViewModel.Order
{
    public class OrderPageViewModel : BaseViewModel<BaseModel>
    {
        readonly OrderPageModel _currentPage;

        public OrderPageViewModel(OrderPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }
    }
}
