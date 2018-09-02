using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace totalsmarthomes.Service.API
{
    public class BaseAccess
    {
        private const string ContentType = "application/json";
        private const string AuthScheme = "Basic";
        public HttpClient Client { get; set; }

        public void SetupClient()
        {
            Client = new HttpClient
            {
                BaseAddress = new Uri("")
            };

            var ascii = new ASCIIEncoding();


            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType));
            //Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthScheme, Convert.ToBase64String(ascii.GetBytes(string.Format("{0}:{1}", userName, password))));
        }
    }
}
