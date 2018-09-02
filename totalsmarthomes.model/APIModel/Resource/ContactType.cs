using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Resource
{
    public class ContactType : BaseObject
    {
        [Key]
        public int ContactTypeID { get; set; }

        public string Title { get; set; }

    }
}
