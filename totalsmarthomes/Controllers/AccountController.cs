using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Account;
using StoreFront.Model.ViewModel.Account;

namespace totalsmarthomes.Controllers
{
    public class AccountController : Controller
    {
        IPage<AccountPageViewModel, AccountPageModel> _page;

        public AccountController(IPage<AccountPageViewModel, AccountPageModel> page)
        {
            _page = page;
        }
    }
}
