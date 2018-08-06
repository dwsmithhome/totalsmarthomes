using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Pages
{
    public class ContentBlockViewModel
    {
        private readonly IContent _content;

        public ContentBlockViewModel(IContent content)
        {
            _content = content;
        }

        public string ContentBlockTitle { get { return _content.GetPropertyValue<string>("contentBlockTitle"); } }

        public string AdditionalContent { get { return _content.GetPropertyValue<string>("additionalContent"); } }
    }
}