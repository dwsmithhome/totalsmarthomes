using System;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Purchase
{
    public class PlaceOrder : BaseObject
    {
        public int CustomerID { get; set; }

        public int CountryID { get; set; }

        public string TransactionID { get; set; }
    }
}
