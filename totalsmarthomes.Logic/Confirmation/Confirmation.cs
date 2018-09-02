using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Confirmation;
using StoreFront.Model.ViewModel.Confirmation;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;
using System.Linq;

namespace StoreFront.Service.Confirmation
{
    public class Confirmation : BasePage, IPage<ConfirmationPageViewModel, ConfirmationPageModel>
    {
        public Confirmation(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public ConfirmationPageViewModel Load(params SearchParameter[] list)
        {

            var confirmationPageModel = new ConfirmationPageModel
            {
                Content = (Model.Content.Content)_model
            };

            confirmationPageModel.TransactionID = list.Where(x => x.Name == "TransactionID").FirstOrDefault().Value.ToString();

            return new ConfirmationPageViewModel(confirmationPageModel);
        }

        public ConfirmationPageViewModel Load(BaseModel model)
        {
            return new ConfirmationPageViewModel((ConfirmationPageModel)model);
        }

        public DataResponse Process(ConfirmationPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
