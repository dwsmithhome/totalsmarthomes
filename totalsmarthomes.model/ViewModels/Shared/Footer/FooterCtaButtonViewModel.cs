using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Footer
{
    public class FooterCtaButtonViewModel
    {
        private readonly IContent _content;

        public FooterCtaButtonViewModel(IContent content)
        {
            _content = content;
        }

        public string CtaButtonText { get { return _content.GetPropertyValue<string>("ctaButtonText"); } }

        public string CtaButtonImage { get { return _content.GetPropertyValue<string>("ctaButtonImage"); } }

        public string PageLink { get { return _content.GetPropertyValue<string>("PageLink"); } }
    }
}