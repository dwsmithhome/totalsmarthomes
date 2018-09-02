using System.Collections.Generic;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;

namespace StoreFront.Model.Interface
{
    public interface ISAL<ReturnType>
    {
        DataResponse Post(ReturnType request);
        DataResponse Put(ReturnType request, string id);
        DataResponse Delete(string id);
        ReturnType Get(string id);
        ICollection<ReturnType> GetAll();
        ICollection<ReturnType> Search(IEnumerable<SearchParameter> request);
    }
}
