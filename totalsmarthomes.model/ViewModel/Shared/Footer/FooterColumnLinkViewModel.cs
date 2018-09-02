using System.Collections.Generic;
using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared.Footer
{
    public class FooterColumnLinkViewModel
    {
        private readonly IContent _content;

        public FooterColumnLinkViewModel(IContent content)
        {
            _content = content;
        }

        public string Heading { get { return _content.GetPropertyValue<string>("heading"); } }

        public IEnumerable<IContent> Links { get { return _content.GetPropertyValue<IEnumerable<IContent>>("links"); } }
    }
}