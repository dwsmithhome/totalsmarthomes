using System.Collections.Generic;
using StoreFront.Model.Interface;
using StoreFront.Model.ViewModel.Shared.Footer;


namespace StoreFront.Model.ViewModel.Shared
{
    public class FooterViewModel
    {
        readonly IContent _content;

        public FooterViewModel(IContent content)
        {
            _content = content.Parent ?? content;
        }

        public SiteViewModel Site { get { return _content.GetPropertyValue<SiteViewModel> ("site"); } }

        public GenericPropertiesViewModel GenericProperties { get { return _content.GetPropertyValue<GenericPropertiesViewModel>("genericProperties"); } }


        public IEnumerable<FooterColumnLinkViewModel> FooterMenu
        {
            get
            {
                var publishedContent = _content.GetPropertyValue<IEnumerable<IContent>>("footerMenu");

                var results = new List<FooterColumnLinkViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new FooterColumnLinkViewModel(content));
                    }
                }
                return results;

            }
        }

        public FooterCtaButtonViewModel FooterCtaButton { get { return new FooterCtaButtonViewModel(_content.GetPropertyValue<IContent>("footerCTAButton")); } }

        public IContent FooterExternalLink
        {
            get
            {
                return _content.GetPropertyValue<IContent>("externalLink");
            }
        }
    }
}