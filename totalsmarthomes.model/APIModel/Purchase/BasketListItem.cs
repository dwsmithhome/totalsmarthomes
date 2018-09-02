using System;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.Model.APIModel.Purchase
{
    public class BasketListItem
    {
        [Key]
        public int BasketID { get; set; }

        public int ProductID { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string ProductCode { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal CalculatedPrice { get; set; }
    }
}
