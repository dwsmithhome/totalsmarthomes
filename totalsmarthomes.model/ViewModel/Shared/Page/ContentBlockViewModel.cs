using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared.Page
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