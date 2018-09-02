using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Profile;
using StoreFront.Model.ViewModel.Profile;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace totalsmarthomes.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        IPage<ProfilePageViewModel, ProfilePageModel> _page;

        public ProfileController(IPage<ProfilePageViewModel, ProfilePageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_page.Load());
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
