using System.Collections.Generic;
using totalsmarthomes.Models.Interfaces;
using totalsmarthomes.Models.ViewModels.Shared.Header;


namespace totalsmarthomes.Models.ViewModels.Shared
{
    public class HeaderViewModel
    {
        private readonly IContent _content;

        public HeaderViewModel(IContent content)
        {
            _content = content.Parent == null ? content : content.Parent;
            Site = new SiteViewModel(_content);
        }

        public SiteViewModel Site { get; set; }


        public IEnumerable<PrimaryNavigationViewModel> PrimaryNavigation
        {
            get
            {
                var publishedContent = _content.GetPropertyValue<IEnumerable<IContent>>("menuLevel1");

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

       public IEnumerable<PrimaryNavigationViewModel> MobilePrimaryNavigation
        {
            get
            {
                var publishedContent = _content.GetPropertyValue<IEnumerable<IContent>>("mobileMenu");

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

        public bool HideStoreSearch { get; set; }

        public string SearchUrl { get; } = "/search/";
    }
}