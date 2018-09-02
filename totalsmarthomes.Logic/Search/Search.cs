using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Search;
using StoreFront.Model.ViewModel.Search;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;

namespace StoreFront.Service.Search
{
    public class Search : BasePage, IPage<SearchPageViewModel, SearchPageModel>
    {
        public Search(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public SearchPageViewModel Load(params SearchParameter[] list)
        {

            var searchPageModel = new SearchPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new SearchPageViewModel(searchPageModel);
        }

        public SearchPageViewModel Load(BaseModel model)
        {
            return new SearchPageViewModel((SearchPageModel)model);
        }

        public DataResponse Process(SearchPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
