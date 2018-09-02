

using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared
{
    public class SiteViewModel
    {
        private readonly IContent _content;

        public SiteViewModel(IContent content)
        {
            _content = content;
        }

        //Site related properties
        public string SiteEmailAddress {get{return _content.GetPropertyValue<string>("siteEmailAddress");}}

        public string SiteName { get { return _content.GetPropertyValue<string>("siteName"); } }

        public IContent SiteLogo { get { return _content.GetPropertyValue<IContent>("siteLogo"); } }

        public IContent SiteMonochromeLogo { get { return _content.GetPropertyValue<IContent>("siteMonochromeLogo"); } }

        public string BusinessInformation { get { return _content.GetPropertyValue<string>("businessInformation"); } }
    }
}