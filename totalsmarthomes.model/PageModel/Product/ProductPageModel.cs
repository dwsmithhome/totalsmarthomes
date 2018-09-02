using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.Product
{
    public class ProductPageModel : BaseModel, IContent
    {
        public int SortOrder { get; set; }
    }
}
