using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Pages
{
    public class BrandBlockViewModel
    {
        private readonly IContent _content;

        public BrandBlockViewModel(IContent content)
        {
            _content = content;
        }

        public IContent BrandImage { get { return _content.GetPropertyValue<IContent>("brandImage"); } }

        public string AlternativeText { get { return _content.GetPropertyValue<string>("altText"); } }

        public string BrandDescription { get { return _content.GetPropertyValue<string>("brandDescription"); } }
    }
}