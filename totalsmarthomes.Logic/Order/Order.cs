using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Order;
using StoreFront.Model.ViewModel.Order;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;

namespace StoreFront.Service.Order
{
    public class Order : BasePage, IPage<OrderPageViewModel, OrderPageModel>
    {
        public Order(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public OrderPageViewModel Load(params SearchParameter[] list)
        {

            var orderPageModel = new OrderPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new OrderPageViewModel(orderPageModel);
        }

        public OrderPageViewModel Load(BaseModel model)
        {
            return new OrderPageViewModel((OrderPageModel)model);
        }

        public DataResponse Process(OrderPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
