using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Product
{
    public class Product : BaseObject
    {
        [Key]
        public int ProductID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ProductCode { get; set; }

    }
}
