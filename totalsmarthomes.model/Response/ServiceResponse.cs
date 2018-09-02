using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using StoreFront.Model.Enum.Response;

namespace StoreFront.Model.Response
{
    [ExcludeFromCodeCoverage]
    public class ServiceResponse
    {
        public DataResponseType Type { get; set; }
        public string Description { get; set; }
        public string ResultJson { get; set; }
        public List<string> Messages { get; set; }
    }
}