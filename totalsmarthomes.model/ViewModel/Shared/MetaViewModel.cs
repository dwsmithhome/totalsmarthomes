using System.Text;
using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared
{
    public class MetaViewModel
    {
        private readonly IContent _content;

        public MetaViewModel(IContent content)
        {
            _content = content;
        }

        public IContent CurrentContent { get { return _content; } }

        public string FavIcon { get { return _content.GetPropertyValue<string>("favIcon"); } }

        public string Name { get { return _content.GetPropertyValue<string>("siteName") == null ? _content.GetPropertyValue<string>("pageName") : _content.GetPropertyValue<string>("siteName"); } }

        public string MetaDescription { get { return _content.GetPropertyValue<string>("metaDescription"); } }

        public string MetaKeywords { get { return _content.GetPropertyValue<string>("metaKeywords"); } }

        public string Title
        {
            get
            {
                var title = _content.HasValue("metaTitle") ? _content.GetPropertyValue<string>("metaTitle") : null;
                var heading = _content.GetPropertyValue<string>("pageHeading");

                string pageName;

                if (!string.IsNullOrEmpty(heading) && heading.Length < 70)
                {
                    pageName = heading;
                }
                else
                {
                    pageName = _content.Name;
                }

                var pageMetaTitle = new StringBuilder(title);

                if (pageMetaTitle.Length == 0)
                {
                    pageMetaTitle.Append(pageName);
                }

                if (_content.DocumentTypeAlias == "home")
                {
                    if (!string.IsNullOrEmpty(Name))
                    {

                        var siteName = Name;
                        title = $"{pageMetaTitle} | {siteName}";
                    }
                }

                // if we still don't have a title, use page name
                if (string.IsNullOrEmpty(title))
                {
                    title = pageName;
                }

                return title;
            }
        }
        
        
        public bool DoNotIndex { get { return _content.GetPropertyValue<bool>("doNotIndex"); } }

        public IContent Image { get { return _content.GetPropertyValue<IContent>("image"); } }

        public string GoogleSiteVerification { get { return _content.GetPropertyValue<string>("googleSiteVerification"); } }
    }
}