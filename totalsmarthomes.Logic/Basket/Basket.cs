using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Basket;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.Basket;
using StoreFront.Service.Base;

namespace StoreFront.Service.Basket
{
    public class Basket : BasePage, IPage<BasketPageViewModel, BasketPageModel>
    {
        IListSAL<Model.APIModel.Purchase.BasketListItem> _basketListService;
        ISAL<Model.APIModel.Purchase.Basket> _basketService;
        IHttpContextAccessor _httpContextAccessor;

        public Basket(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IListSAL<Model.APIModel.Purchase.BasketListItem> basketListService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {
            _basketListService = basketListService;
            _httpContextAccessor = httpContextAccessor;
            _basketService = basketService;
        }

        public DataResponse UpdateQuantity(int id, int value)
        {
            var item = _basketService.Get(id.ToString());
            var result = _basketService.Put(new Model.APIModel.Purchase.Basket
            {
                BasketID = id,
                Quantity = value,
                ProductID = item.ProductID,
                BasketGUID = item.BasketGUID
            }, id.ToString());


            return new DataResponse { Type = result.Type };

        }

        public bool DeleteItem(string id)
        {
            var loggedIn = _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;

            var response = _basketService.Delete(id);

            if (response.Type == Model.Enum.Response.DataResponseType.SUCCESS)
            { 
                return true; 
            }

            return false;
        }

        public BasketPageViewModel Load(params SearchParameter[] list)
        {
            var loggedIn = _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;

            var basket = _basketListService.Search(new List<SearchParameter>{
                new SearchParameter{
                    Name = loggedIn ? "CustomerID" : "BasketGUID",
                    Value = loggedIn ? (object)Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name) : GUID
                }
            });

            var basketPageModel = new BasketPageModel
            {
                Content = (Model.Content.Content)_model
            };

            basketPageModel.AddProperty("basket", basket); 

            return new BasketPageViewModel(basketPageModel);
        }

        public BasketPageViewModel Load(BaseModel model)
        {
            return new BasketPageViewModel((BasketPageModel)model);
        }

        public DataResponse Process(BasketPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
