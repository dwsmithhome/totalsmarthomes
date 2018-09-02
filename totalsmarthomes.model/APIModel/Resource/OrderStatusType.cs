using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Resource
{
    public class OrderStatusType : BaseObject
    {
        [Key]
        public int OrderStatusTypeID { get; set; }

        public int Title { get; set; }

    }
}
