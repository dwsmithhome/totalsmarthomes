using System;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.Model.APIModel.Customer
{
    public class Security
    {
        [Key]
        public int CustomerID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
