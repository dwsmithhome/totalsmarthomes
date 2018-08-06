using System.Collections.Generic;
using totalsmarthomes.Models.Interfaces;
using totalsmarthomes.Models.ViewModels.Shared.Footer;


namespace totalsmarthomes.Models.ViewModels.Shared
{
    public class FooterViewModel
    {
        private readonly IContent _content;

        public FooterViewModel(IContent content)
        {
            _content = content.Parent == null ? content : content.Parent;
            Site = new SiteViewModel(_content);
            GenericProperties = new GenericPropertiesViewModel(content);
        }

        public SiteViewModel Site { get; set; }

        public GenericPropertiesViewModel GenericProperties { get; set; }        


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

        public string FooterExternalLink
        {
            get
            {
                return _content.GetPropertyValue<string>("externalLink");
            }
        }
    }
}