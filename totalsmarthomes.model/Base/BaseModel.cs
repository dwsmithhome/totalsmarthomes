using System.Collections.Generic;
using System.Linq;
using System;
using StoreFront.Model.Interface;

namespace StoreFront.Model.Base
{
    public class BaseModel : IContent
    {
        public BaseModel()
        {
            properties = new List<Property>();
        }

        List<Property> properties;

        public string Name { get; set; }
        public string DocumentTypeAlias { get; set; }
        public Content.Content Parent { get; set; }

        public void AddProperty(string identifier, object value)
        {
            properties.Add(new Property { Identifier = identifier, Value = value });
        }

        public T GetPropertyValue<T>(string identifier)
        {
            if (HasValue(identifier))
            {
                return (T)properties.FirstOrDefault(x => x.Identifier == identifier).Value;
            }

            return default(T);
        }

        public T GetPropertyValue<T>(string identifier, object defaultValue)
        {
            if (HasValue(identifier))
            {
                return (T)properties.FirstOrDefault(x => x.Identifier == identifier).Value;
            }

            return (T)defaultValue;
        }

        public bool HasValue(string identifier)
        {
            return properties.Any(x => x.Identifier == identifier && x.Value != null);
        }

        public bool HasProperty(string identifier)
        {
            return properties.Any(x => x.Identifier == identifier);
        }

        public Content.Content CurrentPage { get; set; }

        public Content.Content Content { get; set; }

        public string Url { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
