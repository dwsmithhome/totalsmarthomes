using System;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.TextPage;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.TextPage;
using StoreFront.Service.Base;

namespace StoreFront.Service.TextPage
{
    public class TextPage : BasePage, IPage<TextPageViewModel, TextPageModel>
    {
        public TextPage(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public TextPageViewModel Load(params SearchParameter[] list)
        {

            var textPageModel = new TextPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new TextPageViewModel(textPageModel);
        }

        public TextPageViewModel Load(BaseModel model)
        {
            return new TextPageViewModel((TextPageModel)model);
        }

        public DataResponse Process(TextPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
