using StoreFront.Model.PageModel.HomePage;
using System.Collections.Generic;
using StoreFront.Model.Interface;
using StoreFront.Model.ViewModel.Shared;
using StoreFront.Model.Base;

namespace StoreFront.Model.ViewModel.HomePage
{
    public class HomePageViewModel : BaseViewModel<BaseModel>
    {
        readonly BaseModel _currentPage;

        public HomePageViewModel(BaseModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public string PageHeading => _currentPage.Content.GetPropertyValue<string>("pageHeading");

        public MainBannerViewModel MainBanner { get { return new MainBannerViewModel(_currentPage.Content.GetPropertyValue<IContent>("mainBanner")); } }


        public IEnumerable<SecondaryBannerViewModel> SecondaryBanners
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("secondaryDesktopBanners");

                var results = new List<SecondaryBannerViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new SecondaryBannerViewModel(content));
                    }
                }
                return results;
            }
        }

        public MainBannerViewModel MobileBanner { get { return new MainBannerViewModel(_currentPage.Content.GetPropertyValue<IContent>("mobileBanner")); } }

        public IEnumerable<SecondaryBannerViewModel> SecondaryMobileBanners
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("secondaryMobileBanners");
                var results = new List<SecondaryBannerViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new SecondaryBannerViewModel(content));
                    }
                }
                return results;
            }
        }


        public IEnumerable<MenuViewModel> MobileMenu
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("MobileMenu");
                var results = new List<MenuViewModel>();
                foreach (var content in publishedContent)
                {
                    results.Add(new MenuViewModel(content));
                }
                return results;
            }
        }
    }
}