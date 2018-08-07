

namespace totalsmarthomes.Models.Interfaces
{
    public interface IContent
    {
        T GetPropertyValue<T>(string identifier);

        void AddProperty(string identifier, object value);

        bool HasValue(string identifier);

        string Name { get; set; }

        string DocumentTypeAlias { get; set; }

        Content.Content Parent { get; set; }

        string Url { get; }
    }
}
