using System;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Account;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.Account;
using StoreFront.Service.Base;

namespace StoreFront.Service.Account
{
    public class Account : BasePage, IPage<AccountPageViewModel, AccountPageModel>
    {
        public Account(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public AccountPageViewModel Load(params SearchParameter[] list)
        {

            var accountPageModel = new AccountPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new AccountPageViewModel(accountPageModel);
        }

        public AccountPageViewModel Load(BaseModel model)
        {
            return new AccountPageViewModel((AccountPageModel)model);
        }

        public DataResponse Process(AccountPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
