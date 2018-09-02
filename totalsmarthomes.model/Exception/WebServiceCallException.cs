
using System.Net.Http;
using StoreFront.Model.Response;

namespace StoreFront.Model.Exception
{
    public class WebServiceCallException : System.Exception
    {
        public ServiceResponse ServiceResponse { get; set; }
        public HttpContent Content { get; set; }
        public string APIPath { get; set; }

        public WebServiceCallException(string message) : base(message) { }
    }
}
