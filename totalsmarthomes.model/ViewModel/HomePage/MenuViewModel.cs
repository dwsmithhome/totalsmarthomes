using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.HomePage
{
    public class MenuViewModel
    {
        readonly IContent _content;

        public MenuViewModel(IContent content)
        {
            _content = content;
        }

        public string MenuItemTitle { get { return _content.GetPropertyValue<string>("menuItemTitle"); } }

        public IContent PageLink { get { return _content.GetPropertyValue<IContent>("pageLink"); } }

        public bool IsCtaMenu { get { return _content.GetPropertyValue<bool>("isCtaMenu"); } }


    }
}