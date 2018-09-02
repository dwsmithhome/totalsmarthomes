using System.Collections.Generic;
using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared.Header
{
    public class PrimaryNavigationViewModel
    {
        readonly IContent _content;

        public PrimaryNavigationViewModel(IContent content)
        {
            _content = content;
        }

    
        public string MenuItemTitle { get { return _content.GetPropertyValue<string>("menuItemTitle"); } }


        public string PageLink { get { return _content.GetPropertyValue<string>("pageLink"); } }

        public string Url { get { return _content.GetPropertyValue<string>("url"); } }


        public bool IsCTAMenu { get { return _content.GetPropertyValue<bool>("isCTAMenu"); } }


        public IEnumerable<PrimaryNavigationViewModel> ChildMenus
        {
            get
            {
                var publishedContent = _content.GetPropertyValue<IEnumerable<IContent>>("childMenus");

                var results = new List<PrimaryNavigationViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new PrimaryNavigationViewModel(content));
                    }
                }
                return results;

            }
        }
    }
}