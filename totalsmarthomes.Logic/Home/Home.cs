using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.HomePage;
using StoreFront.Model.ViewModel.HomePage;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;

namespace StoreFront.Service.Home
{
    public class Home : BasePage, IPage<HomePageViewModel, HomePageModel>
    {
        
        public Home(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {
            
        }

        public HomePageViewModel Load(params SearchParameter[] list)
        {
            var homePageModel = new HomePageModel
            {
                Content = (Model.Content.Content)_model
            };

            var mobileContent = new Model.Content.Content();
            homePageModel.Content.AddProperty("mainBanner", CreateBanner());
            homePageModel.Content.AddProperty("mobileBanner", mobileContent);

            return new HomePageViewModel(homePageModel);
        }

        private static Model.Content.Content CreateBanner()
        {
            var bannerContent = new Model.Content.Content
            {
                Url = "/Images/banner.jpg"
            };

            bannerContent.AddProperty("bannerBackgroundImage", bannerContent);
            bannerContent.AddProperty("bannerCaption", "Upgrade your life");
            bannerContent.AddProperty("captionText", "save money<br />save the environment<br />increased security<br />make life easier<br />take control of your bills");
            return bannerContent;
        }

        public HomePageViewModel Load(BaseModel model)
        {
            return new HomePageViewModel((HomePageModel)model);
        }

        public DataResponse Process(HomePageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
