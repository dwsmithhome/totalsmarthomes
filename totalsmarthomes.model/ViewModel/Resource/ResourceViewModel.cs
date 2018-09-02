using System.Collections.Generic;
using StoreFront.Model.Interface;

namespace StoreFront.Model.ViewModel.Resource
{
    public class ResourceViewModel
    {
        private readonly IContent _content;

        public ResourceViewModel(IContent content)
        {
            _content = content;
        }

        public string Disclaimer { get { return _content.GetPropertyValue<string>("disclaimer"); } }

        public string Close { get { return _content.GetPropertyValue<string>("close"); } }
    }
}