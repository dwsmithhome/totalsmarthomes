using StoreFront.Model.Base;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;

namespace StoreFront.Model.Interface
{
    public interface IPage<ViewModel, PageModel>
    {
        ViewModel Load(params SearchParameter[] list);

        ViewModel Load(BaseModel model);

        DataResponse Process(PageModel model);
    }
}
