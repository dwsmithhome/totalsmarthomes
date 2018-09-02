using System;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.Model.APIModel.Purchase
{
    public class BasketDelivery
    {
        [Key]
        public int CustomerID { get; set; }

        [Key]
        public int DeliveryOptionID { get; set; }


        public decimal Value { get; set; }
    }
}
