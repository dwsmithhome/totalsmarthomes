using totalsmarthomes.Models.Content;
using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.Base
{
    public class BaseModel : IContent
    {
        public BaseModel()
        {
        }

        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string DocumentTypeAlias { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Content.Content Parent { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public T GetPropertyValue<T>(string identifier)
        {
            throw new System.NotImplementedException();
        }

        public bool HasValue(string identifier)
        {
            throw new System.NotImplementedException();
        }

        public Content.Content CurrentPage { get; }

        public Content.Content Content { get; }

        public string Url { get; }
    }
}
