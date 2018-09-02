using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Product
{
    public class Price : BaseObject
    {
        [Key]
        public int ProductID { get; set; }

        public decimal Value { get; set; }

        public int CountryID { get; set; }

    }
}
