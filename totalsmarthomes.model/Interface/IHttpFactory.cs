using System.Net.Http;

namespace StoreFront.Model.Interface
{
    public interface IHttpFactory
    {
        HttpClient SetupClient(string baseAddress);
    }
}
