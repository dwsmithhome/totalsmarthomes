using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using StoreFront.Model.Interface;
using StoreFront.Model.Response;
using StoreFront.Model.Parameter;

namespace StoreFront.Service.API
{
    public class GenericSAL<ReturnType> : ISAL<ReturnType> 
    {
        readonly IHttpManager<ReturnType> _httpManager;
        readonly IConfiguration _configuration;
        string _url = "";

        public GenericSAL(IHttpManager<ReturnType> httpManager, IConfiguration configuration)
        {
            _httpManager = httpManager;
            _configuration = configuration;

            _url = _configuration["Store.API"] + "/" + typeof(ReturnType).Namespace.Substring(typeof(ReturnType).Namespace.LastIndexOf('.')).Trim('.') + "/" + typeof(ReturnType).Name + "/";
                
        }

        public DataResponse Post(ReturnType request)
        {
            return _httpManager.PostRequest<DataResponse>(_url + "Post/", request);
        }

        public DataResponse Delete(string id)
        {
            return _httpManager.DeleteRequest<DataResponse>(_url + "Delete/" + id);
        }

        public ReturnType Get(string id)
        {
            return _httpManager.GetRequest<ReturnType>(_url + "Get/" + id);
        }

        public ICollection<ReturnType> GetAll()
        {
            return _httpManager.GetRequest<ICollection<ReturnType>>(_url + "GetAll/");
        }

        public ICollection<ReturnType> Search(IEnumerable<SearchParameter> request)
        {
            return _httpManager.PostRequest<ICollection<ReturnType>>(_url + "Search/", request);
        }

        public DataResponse Put(ReturnType request, string id)
        {
            return _httpManager.PutRequest<DataResponse>(_url + "Put/" + id, request);
        }
    }
}
