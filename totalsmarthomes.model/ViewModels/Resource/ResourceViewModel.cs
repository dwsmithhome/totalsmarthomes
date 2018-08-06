using System.Collections.Generic;

namespace totalsmarthomes.Models.ViewModels.Resource
{
    public class ResourceViewModel
    {
        public Dictionary<string, string> Item { get; set; }

        public ResourceViewModel()
        {
            Item = new Dictionary<string, string>();
        }
    }
}