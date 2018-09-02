using System.ComponentModel.DataAnnotations;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Register;

namespace StoreFront.Model.ViewModel.Register
{
    public class RegisterPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly RegisterPageModel _currentPage;

        public RegisterPageViewModel(RegisterPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public string Address2 { get; set; }

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
