using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Register;
using StoreFront.Model.ViewModel.Register;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;

namespace StoreFront.Service.Register
{
    public class Register : BasePage, IPage<RegisterPageViewModel, RegisterPageModel>
    {
        public Register(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public RegisterPageViewModel Load(params SearchParameter[] list)
        {

            var registerPageModel = new RegisterPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new RegisterPageViewModel(registerPageModel);
        }

        public RegisterPageViewModel Load(BaseModel model)
        {
            model.Content = (Model.Content.Content)_model;
            return new RegisterPageViewModel((RegisterPageModel)model);
        }

        public DataResponse Process(RegisterPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
