using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared.Footer
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

        public string Url {get { return _content.GetPropertyValue<string>("url");}}

        public string Name { get { return _content.GetPropertyValue<string>("name"); } }
    }
}