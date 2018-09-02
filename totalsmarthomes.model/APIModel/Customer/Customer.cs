using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Customer
{
    public class Customer : BaseObject
    {
        [Key]
        public int CustomerID { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }
    }
}
