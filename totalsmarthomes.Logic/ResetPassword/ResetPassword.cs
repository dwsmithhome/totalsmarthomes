using System;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.ResetPassword;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.ResetPassword;
using StoreFront.Service.Base;
using StoreFront.Model.Base;

namespace StoreFront.Service.ResetPassword
{
    public class ResetPassword : BasePage, IPage<ResetPasswordPageViewModel, ResetPasswordPageModel>
    {
        public ResetPassword(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public ResetPasswordPageViewModel Load(params SearchParameter[] list)
        {

            var profilePageModel = new ResetPasswordPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new ResetPasswordPageViewModel(profilePageModel);
        }

        public ResetPasswordPageViewModel Load(BaseModel model)
        {
            return new ResetPasswordPageViewModel((ResetPasswordPageModel)model);
        }

        public DataResponse Process(ResetPasswordPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
