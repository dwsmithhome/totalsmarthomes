
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using StoreFront.Model.Enum.Response;
using StoreFront.Model.Exception;
using StoreFront.Model.Response;
using StoreFront.Model.Interface;

namespace StoreFront.Service.API
{
    public class HttpManager<T> : IHttpManager<T>
    {
        private readonly IHttpFactory _httpFactory;

        private HttpClient _client;
        private const string ContentType = "application/json";

        public HttpManager(IHttpFactory httpFactory)
        {
            _httpFactory = httpFactory;
        }

        public T PostRequest<T>(string apiPath, object request)
        {
            try
            {
                _client = _httpFactory.SetupClient(apiPath);
               
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json);

                content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);

                var result = _client.PostAsync(apiPath, content).Result;
                var resultContent = result.Content.ReadAsStringAsync();
                var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result,
                    new KeyValuePairConverter());

                if (deserialisedResult.Type != DataResponseType.SUCCESS)
                {
                    throw new WebServiceCallException(deserialisedResult.Description)
                    {
                        ServiceResponse = deserialisedResult,
                        Content = content,
                        APIPath = apiPath
                    };
                }

                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty,
                    new KeyValuePairConverter());
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public T GetRequest<T>(string apiPath)
        {
            try
            {
                _client = _httpFactory.SetupClient(apiPath);

                var result = _client.GetAsync(apiPath).Result;
                var resultContent = result.Content.ReadAsStringAsync();

                var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result,
                    new KeyValuePairConverter());

                if (deserialisedResult.Type != DataResponseType.SUCCESS)
                    throw new WebServiceCallException(deserialisedResult.Description)
                    {
                        ServiceResponse = deserialisedResult,
                        APIPath = apiPath
                    };

                if (deserialisedResult.Type != DataResponseType.SUCCESS)
                    throw new WebServiceCallException(deserialisedResult.Description)
                    {
                        ServiceResponse = deserialisedResult,
                        APIPath = apiPath
                    };

                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty,
                    new KeyValuePairConverter());
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public T PutRequest<T>(string apiPath, object request)
        {
            _client = _httpFactory.SetupClient(apiPath);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);

            var result = _client.PutAsync(apiPath, content).Result;
            var resultContent = result.Content.ReadAsStringAsync();

            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result,
                    new KeyValuePairConverter());

            if (deserialisedResult.Type != DataResponseType.SUCCESS)
                throw new WebServiceCallException(deserialisedResult.Description) { ServiceResponse = deserialisedResult, APIPath = apiPath };

            return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());
        }

        public T DeleteRequest<T>(string apiPath)
        {
            _client = _httpFactory.SetupClient(apiPath);

            var result = _client.DeleteAsync(apiPath).Result;
            var resultContent = result.Content.ReadAsStringAsync();

            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result,
                    new KeyValuePairConverter());

            if (deserialisedResult.Type != DataResponseType.SUCCESS)
                throw new WebServiceCallException(deserialisedResult.Description) { ServiceResponse = deserialisedResult, APIPath = apiPath };

            return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());
        }

        public T PostRequest<T>(string apiPath, object parameters, string username, string password)
        {
            _client = _httpFactory.SetupClient(apiPath);


            var credential = Convert.ToBase64String(new System.Text.ASCIIEncoding().GetBytes(string.Format("{0}:{1}", username, password)));

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credential);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            var json = JsonConvert.SerializeObject(parameters);
            var content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);

            var result = _client.PostAsync(apiPath, content).Result;
            var resultContent = result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result,
                new KeyValuePairConverter());

            if (deserialisedResult.Type != DataResponseType.SUCCESS)
            {
                

                throw new WebServiceCallException(deserialisedResult.Description)
                {
                    ServiceResponse = deserialisedResult,
                    Content = content,
                    APIPath = apiPath
                };
            }

            return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty,
                new KeyValuePairConverter());
        }
    }
}
