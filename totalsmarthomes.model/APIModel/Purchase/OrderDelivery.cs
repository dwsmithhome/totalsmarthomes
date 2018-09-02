using System;
using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Purchase
{
    public class OrderDelivery : BaseObject
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int DeliveryOptionID { get; set; }
    }
}
