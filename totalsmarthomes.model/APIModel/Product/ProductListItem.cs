using System;
namespace StoreFront.Model.APIModel.Product
{
    public class ProductListItem
    {
        public int ProductID { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string ProductCode { get; set; }

        public decimal Price { get; set; }
    }
}
