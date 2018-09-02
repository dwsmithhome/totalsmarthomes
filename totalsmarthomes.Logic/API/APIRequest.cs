using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Hanssens.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using totalsmarthomes.Model.Response;

namespace totalsmarthomes.Service.API
{
    public static class APIRequest
    {
        private const string ContentType = "application/json";

        public static T PostRequest<T>(string apiPath, object request, string uri)
        {
            var client = new HttpClient { BaseAddress = new Uri(uri) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);
            content.Headers.Add("Authorization", GetTokenValue());
            var result = client.PostAsync(apiPath, content).Result;
            var resultContent = result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());

            return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());
        }

        private static string GetTokenValue()
        {
            var storage = new LocalStorage();
            var tokenValue = "";
            if (storage.Get<string>("token") != null)
            {
                tokenValue = GetTokenFromAPI();
                storage.Store("token", tokenValue);
                storage.Persist();
                return tokenValue;
            }

            return storage.Get<string>("token");
        }

        private static string GetTokenFromAPI()
        {
            return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoidDB0NGw1M2N1cjF0eSIsIm5iZiI6IjE1MzQ1Mzc3MTAiLCJleHAiOiIxNTM0NjI0MTEwIn0.ezINjslDoEkaShc_HjS14omxCcnHq1gwV8oTHlyOdZg";
        }

        public static T GetRequest<T>(List<string> parameters, string apiPath, string uri)
        {
            var builder = new StringBuilder();

            builder.Append("/");

            foreach (var item in parameters)
                builder.Append(item + "/");

            var client = new HttpClient { BaseAddress = new Uri(uri) };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = client.GetAsync(apiPath + builder);
            var resultContent = result.Result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());

            if (deserialisedResult != null)
                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());

            return default(T);
        }

        public static T GetRequest<T>(int id, string apiPath, string uri)
        {
            var builder = new StringBuilder();

            builder.Append("/");
            builder.Append(id + "/");

            var client = new HttpClient { BaseAddress = new Uri(uri) };


            var result = client.GetAsync(apiPath + builder);
            var resultContent = result.Result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());

            if (deserialisedResult != null)
                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());

            return default(T);
        }

        public static T GetRequest<T>(string id, string apiPath, string uri)
        {
            var builder = new StringBuilder();

            builder.Append("/");
            builder.Append(id + "/");

            var client = new HttpClient { BaseAddress = new Uri(uri) };

            var result = client.GetAsync(apiPath + builder);
            var resultContent = result.Result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());

            if (deserialisedResult != null)
                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());

            return default(T);
        }

        public static T PutRequest<T>(string apiPath, object request, string uri)
        {
            var client = new HttpClient { BaseAddress = new Uri(uri) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);

            var result = client.PutAsync(apiPath, content);

            var resultContent = result.Result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());


            if (deserialisedResult != null)
                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());

            return default(T);
        }


        public static T DeleteRequest<T>(string apiPath, int id, string uri)
        {
            var client = new HttpClient { BaseAddress = new Uri(uri) };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var builder = new StringBuilder();
            builder.Append("/");
            builder.Append(id);

            var result = client.DeleteAsync(apiPath + builder);

            var resultContent = result.Result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());

            if (deserialisedResult != null)
                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());

            return default(T);
        }

        public static T DeleteRequest<T>(string apiPath, string id, string uri)
        {
            var client = new HttpClient { BaseAddress = new Uri(uri) };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var builder = new StringBuilder();
            builder.Append("/");
            builder.Append(id);

            var result = client.DeleteAsync(apiPath + builder);

            var resultContent = result.Result.Content.ReadAsStringAsync();
            var deserialisedResult = JsonConvert.DeserializeObject<ServiceResponse>(resultContent.Result, new KeyValuePairConverter());

            if (deserialisedResult != null)
                return JsonConvert.DeserializeObject<T>(deserialisedResult.ResultJson ?? String.Empty, new KeyValuePairConverter());

            return default(T);
        }

    }
}
