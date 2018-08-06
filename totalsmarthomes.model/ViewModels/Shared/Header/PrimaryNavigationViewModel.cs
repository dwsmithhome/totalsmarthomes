using System.Collections.Generic;
using totalsmarthomes.Models.Content;
using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Header
{
    public class PrimaryNavigationViewModel
    {
        private readonly IContent _content;

        public PrimaryNavigationViewModel(IContent content)
        {
            _content = content;
        }

    
        public string MenuItemTitle { get { return _content.GetPropertyValue<string>("menuItemTitle"); } }


        public string PageLink { get { return _content.GetPropertyValue<string>("pageLink"); } }


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