using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Purchase
{
    public class OrderStatus : BaseObject
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int StatusID { get; set; }

        public string StatusDate { get; set; }
    }
}
