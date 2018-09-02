using System;
using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.Register
{
	public class RegisterPageModel : BaseModel, IContent
    {
        [StringLength(50, MinimumLength = 0)]
        public string Address2 { get; set; }

        [StringLength(50, MinimumLength = 0)]
        public string Address3 { get; set; }

        [Required]
        public string ForeName { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string RepeatPassword { get; set; }
    }
}
