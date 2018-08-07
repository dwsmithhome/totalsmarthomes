using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Pages
{
    public class ArticlePageMainBannerViewModel
    {
        private readonly IContent _content;

        public ArticlePageMainBannerViewModel(IContent content)
        {
            _content = content;
        }

        public IContent BannerImage { get { return _content.GetPropertyValue<IContent>("bannerImage"); } }

        public string AlternativeText { get { return _content.GetPropertyValue<string>("alternativeText"); } }

        public string BannerCaptionText { get { return _content.GetPropertyValue<string>("bannerCaptionText"); } }

        public string PageIntroText { get { return _content.GetPropertyValue<string>("pageIntroText"); } }

    }
}