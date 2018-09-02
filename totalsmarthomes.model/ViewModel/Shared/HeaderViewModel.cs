using System.Collections.Generic;
using StoreFront.Model.Interface;
using StoreFront.Model.ViewModel.Shared.Header;


namespace StoreFront.Model.ViewModel.Shared
{
    public class HeaderViewModel
    {
        private readonly IContent _content;

        public HeaderViewModel(IContent content)
        {
            _content = content.Parent ?? content;

        }

        public SiteViewModel Site { get { return _content.GetPropertyValue<SiteViewModel>("site"); } }


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