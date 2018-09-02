using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Purchase
{
    public class Basket : BaseObject
    {
        [Key]
        public int BasketID { get; set; }

        public string BasketGUID { get; set; }

        public int? CustomerID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }
    }
}
