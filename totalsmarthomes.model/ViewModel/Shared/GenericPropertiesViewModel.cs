
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Shared
{
    public class GenericPropertiesViewModel : BaseModel
    {
        private readonly IContent _content;

        public GenericPropertiesViewModel(IContent content)
        {
            _content = content;
        }

        public bool FooterCallToAction {get{return _content.GetPropertyValue<bool>("footerCallToAction");}}
    }
}