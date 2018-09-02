using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using StoreFront.Model.Interface;
using StoreFront.Model.Parameter;

namespace StoreFront.Service.API
{
    public class GenericSearchSAL<ReturnType> : ISearchSAL<ReturnType>
    {
        readonly IHttpManager<ReturnType> _httpManager;
        readonly IConfiguration _configuration;
        readonly string _url = "";

        public GenericSearchSAL(IHttpManager<ReturnType> httpManager, IConfiguration configuration)
        {
            _httpManager = httpManager;
            _configuration = configuration;

            _url = _configuration["Store.API"] + "/" + typeof(ReturnType).Namespace.Substring(typeof(ReturnType).Namespace.LastIndexOf('.')).Trim('.') + "/" + typeof(ReturnType).Name + "/";
        }

        public ICollection<ReturnType> Search(IEnumerable<SearchParameter> request)
        {
            return _httpManager.PostRequest<List<ReturnType>>(_url + "Search/", request);
        }
    }
}
