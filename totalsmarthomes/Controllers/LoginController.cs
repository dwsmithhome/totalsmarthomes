using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.APIModel.Customer;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Login;
using StoreFront.Model.ViewModel.Login;

namespace totalsmarthomes.Controllers
{

    public class LoginController : Controller
    {
        IPage<LoginPageViewModel, LoginPageModel> _page;
        ISAL<Security> _security;
        string _returnUrl;

        public LoginController(IPage<LoginPageViewModel, LoginPageModel> page, ISAL<Security> security)
        {
            _page = page;
            _security = security;

        }

        public IActionResult Index(string ReturnUrl)
        {
            _returnUrl = ReturnUrl;
            return View(_page.Load());

        }

        public  IActionResult Login(LoginPageModel model)
        {

            var response = _page.Process(model);

            if(response.Type == StoreFront.Model.Enum.Response.DataResponseType.SUCCESS){
                return Redirect(Request.Query["ReturnURL"].ToString());
            }

            model.LoginError = "User not valid, please check your details and try again.";
            return View("Index", new LoginPageViewModel(model));
        }
    }
}
