using System;
using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Customer
{
    public class Terms : BaseObject
    {
        [Key]
        public int CustomerID { get; set; }

        public bool TermsAgreed { get; set; }

        public DateTime TermsAgreedDateTime { get; set; }

    }
}
