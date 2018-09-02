using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Product
{
    public class Category : BaseObject
    {
        [Key]
        public int CategoryID { get; set; }

        public string Title { get; set; }

    }
}
