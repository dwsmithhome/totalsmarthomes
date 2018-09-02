using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Customer
{
    public class Contact : BaseObject
    {
        [Key]
        public int CustomerID { get; set; }

        [Key]
        public int ContactTypeID { get; set; }

        public string Value { get; set; }

    }
}
