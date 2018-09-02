using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.ProductDetail
{
    public class ProductDetailPageModel : BaseModel, IContent
    {
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public APIModel.Product.Product Product { get; set; }
    }
}
