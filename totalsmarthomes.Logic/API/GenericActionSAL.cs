using System;
using Microsoft.Extensions.Configuration;
using StoreFront.Model.Interface;
using StoreFront.Model.Response;

namespace StoreFront.Service.API
{
    public class GenericActionSAL<ReturnType> : IActionSAL<ReturnType>
    {
        readonly IHttpManager<ReturnType> _httpManager;
        readonly IConfiguration _configuration;
        string _url = "";

        public GenericActionSAL(IHttpManager<ReturnType> httpManager, IConfiguration configuration)
        {
            _httpManager = httpManager;
            _configuration = configuration;

            _url = _configuration["Store.API"] + "/" + typeof(ReturnType).Namespace.Substring(typeof(ReturnType).Namespace.LastIndexOf('.')).Trim('.') + "/" + typeof(ReturnType).Name + "/";
        }

        public DataResponse Post(ReturnType request)
        {
            return _httpManager.PostRequest<DataResponse>(_url + "Post/", request);
        }
    }
}
