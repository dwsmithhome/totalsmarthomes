using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.HomePage
{
    public class MainBannerViewModel
    {
        public IContent _content;

        public MainBannerViewModel(IContent content)
        {
            _content = content;
        }

        public string BannerCaption { get { return _content.GetPropertyValue<string>("bannerCaption"); } }

        public IContent BannerBackgroundImage { get { return _content.GetPropertyValue<IContent>("bannerBackgroundImage"); } }

        public string CaptionText { get { return _content.GetPropertyValue<string>("captionText"); } }

        public string CtaButtonText { get { return _content.GetPropertyValue<string>("ctaButtonText"); } }

        public string CtaButtonImage { get { return _content.GetPropertyValue<string>("ctaButtonImage"); } }

        public IContent CtaPageLink { get { return _content.GetPropertyValue<IContent>("ctaPageLink"); } }

        public string BannerAltText { get { return _content.GetPropertyValue<string>("bannerAltText"); } }
    }
}