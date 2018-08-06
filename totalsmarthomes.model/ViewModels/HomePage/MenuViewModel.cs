using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.HomePage
{
    public class MenuViewModel
    {
        private readonly IContent _content;

        public MenuViewModel(IContent content) 
        {
            _content = content;
        }

        public string MenuItemTitle { get { return _content.GetPropertyValue<string>("menuItemTitle"); } }

        public IContent PageLink { get { return _content.GetPropertyValue<IContent>("pageLink"); } }

        public bool IsCtaMenu { get { return _content.GetPropertyValue<bool>("isCtaMenu"); } }
    }
}