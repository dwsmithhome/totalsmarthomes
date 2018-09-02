using System;
using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Purchase
{
    public class Transaction : BaseObject
    {
        [Key]
        public int OrderID { get; set; }

        public string Reference { get; set; }

        [Key]
        public DateTime TransactionDateTime { get; set; }

    }
}
