using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Legal;
using StoreFront.Model.ViewModel.Legal;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;

namespace StoreFront.Service.Legal
{
    public class Legal : BasePage, IPage<LegalPageViewModel, LegalPageModel>
    {
        public Legal(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {
            
        }

        public LegalPageViewModel Load(params SearchParameter[] list)
        {

            var legalPageModel = new LegalPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new LegalPageViewModel(legalPageModel);
        }

        public LegalPageViewModel Load(BaseModel model)
        {
            return new LegalPageViewModel((LegalPageModel)model);
        }

        public DataResponse Process(LegalPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
