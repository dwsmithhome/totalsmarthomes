using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Product
{
    public class ProductCategory : BaseObject
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        public int CategoryID { get; set; }


    }
}
