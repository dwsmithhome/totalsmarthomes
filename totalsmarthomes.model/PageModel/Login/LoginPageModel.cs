using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.Login
{
    public class LoginPageModel : BaseModel, IContent
    {
        
        public string Email { get; set; }

        public string Password { get; set; }

        public string LoginError { get; set; }
    }
}
