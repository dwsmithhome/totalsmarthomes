using System.Collections.Generic;
using StoreFront.Model.Parameter;

namespace StoreFront.Model.Interface
{
    public interface IListSAL<ReturnType>
    {
        ICollection<ReturnType> Search(IEnumerable<SearchParameter> request);
    }
}
