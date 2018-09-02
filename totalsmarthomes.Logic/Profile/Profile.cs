using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Profile;
using StoreFront.Model.ViewModel.Profile;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;

namespace StoreFront.Service.Profile
{
    public class Profile : BasePage, IPage<ProfilePageViewModel, ProfilePageModel>
    {
        public Profile(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {

        }

        public ProfilePageViewModel Load(params SearchParameter[] list)
        {

            var profilePageModel  = new ProfilePageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new ProfilePageViewModel(profilePageModel);
        }

        public ProfilePageViewModel Load(BaseModel model)
        {
            return new ProfilePageViewModel((ProfilePageModel)model);
        }

        public DataResponse Process(ProfilePageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
