using System;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.About;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.About;
using StoreFront.Service.Base;

namespace StoreFront.Service.About
{
    public class About : BasePage, IPage<AboutPageViewModel, AboutPageModel>
    {
        public About(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public AboutPageViewModel Load(params SearchParameter[] list)
        {

            var aboutPageModel = new AboutPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new AboutPageViewModel(aboutPageModel);
        }

        public AboutPageViewModel Load(BaseModel model)
        {
            return new AboutPageViewModel((AboutPageModel)model);
        }

        public DataResponse Process(AboutPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
