using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;

namespace StoreFront.Model.APIModel.Resource
{
    public class Country : BaseObject
    {
        [Key]
        public int CountryID { get; set; }

        public string Title { get; set; }

        public string Culture { get; set; }
    }
}
