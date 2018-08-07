
using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared
{
    public class GenericPropertiesViewModel
    {
        private readonly IContent _content;

        public GenericPropertiesViewModel(IContent content)
        {
            _content = content;
        }

        public bool FooterCallToAction {get{return _content.GetPropertyValue<bool>("footerCallToAction");}}
    }
}