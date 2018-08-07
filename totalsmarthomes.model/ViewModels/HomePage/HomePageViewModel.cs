using totalsmarthomes.Models.PageModels.HomePage;
using System.Collections.Generic;
using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.HomePage
{
    public class HomePageViewModel : BaseViewModel<HomePageModel>
    {
        readonly HomePageModel _currentPage;

        public HomePageViewModel(HomePageModel currentPage) : base(currentPage)
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