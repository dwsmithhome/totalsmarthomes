using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Pages
{
    public class ArticleContentBlockViewModel
    {
        private readonly IContent _content;

        public ArticleContentBlockViewModel(IContent content)
        {
            _content = content;
        }

        public IContent BannerImage { get { return _content.GetPropertyValue<IContent>("bannerImage"); } }

        public string AlternativeText { get { return _content.GetPropertyValue<string>("altText"); } }

        public string Heading { get { return _content.GetPropertyValue<string>("heading"); } }

        public string MainContent { get { return _content.GetPropertyValue<string>("mainContent"); } }

        public bool ImageToLeft { get { return _content.GetPropertyValue<bool>("imageToLeft"); } }

        public IContent MobileBannerImage { get { return _content.GetPropertyValue<IContent>("mobileBannerImage"); } }
    }
}