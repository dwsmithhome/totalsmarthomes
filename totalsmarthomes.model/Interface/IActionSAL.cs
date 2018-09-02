using System;
using StoreFront.Model.Response;

namespace StoreFront.Model.Interface
{
    public interface IActionSAL<ReturnType>
    {
        DataResponse Post(ReturnType request);
    }
}
