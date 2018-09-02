using System.Collections.Generic;
using StoreFront.Model.Response;

namespace StoreFront.Model.Interface
{
    public interface IHttpManager<T>
    {
        
        T PostRequest<T>(string apiPath, object request);
        T GetRequest<T>(string apiPath);
        T PutRequest<T>(string apiPath, object request);
        T DeleteRequest<T>(string apiPath);
        T PostRequest<T>(string apiPath, object parameters, string username, string password);


    }
}
