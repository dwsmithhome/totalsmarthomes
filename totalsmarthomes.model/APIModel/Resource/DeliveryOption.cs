using System;
using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Resource
{
    public class DeliveryOption : BaseObject
    {
        [Key]
        public int DeliveryOptionID { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int DeliveryPeriod { get; set; }

        public int CountryID { get; set; }

    }
}
