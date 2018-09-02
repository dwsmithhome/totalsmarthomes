using System;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Brand;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.Brand;
using StoreFront.Service.Base;

namespace StoreFront.Service.Brand
{
    public class Brand : BasePage, IPage<BrandPageViewModel, BrandPageModel>
    {
        public Brand(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {
            
        }

        public BrandPageViewModel Load(params SearchParameter[] list)
        {
            
            var brandsPageModel = new BrandPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new BrandPageViewModel(brandsPageModel);
        }

        public BrandPageViewModel Load(BaseModel model)
        {
            return new BrandPageViewModel((BrandPageModel)model);
        }

        public DataResponse Process(BrandPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
