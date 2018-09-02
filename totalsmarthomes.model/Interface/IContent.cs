using System;

namespace StoreFront.Model.Interface
{
    public interface IContent
    {
        T GetPropertyValue<T>(string identifier);

        T GetPropertyValue<T>(string identifier, object defaultValue);

        void AddProperty(string identifier, object value);

        bool HasValue(string identifier);

        bool HasProperty(string identifier);

        string Name { get; set; }

        string DocumentTypeAlias { get; set; }

        Content.Content Parent { get; set; }

        string Url { get; }

        DateTime CreateDate { get; set; }

        DateTime UpdateDate { get; set; }
    }
}
