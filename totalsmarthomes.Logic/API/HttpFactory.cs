using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using StoreFront.Model.Interface;

namespace StoreFront.Service.API
{
    public class HttpFactory : IHttpFactory
    {
        private readonly IConfiguration _configuration;

        public HttpFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public HttpClient SetupClient(string baseAddress)
        {
            var client = new HttpClient { BaseAddress = new Uri(baseAddress) };

            var credential =
                Convert.ToBase64String(
                    new ASCIIEncoding().GetBytes(string.Format("{0}:{1}", _configuration["Store.API.Username"],
                                                               _configuration["Store.API.Password"])));

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "Z1JoWiRDUksjRDhCM0ItLzpGIWhOJix7S2ApLWNQczZn");
            return client;
        }
    }
}
