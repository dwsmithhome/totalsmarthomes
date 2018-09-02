using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.HomePage;
using StoreFront.Model.ViewModel.HomePage;

namespace totalsmarthomes.Controllers
{
    public class HomeController : Controller
    {
        IPage<HomePageViewModel, HomePageModel> _page;

        public HomeController(IPage<HomePageViewModel, HomePageModel> page)
        {
            _page = page;
        }

        public IActionResult Index()
        {
            return View(_page.Load());
        }

        public IActionResult SplashPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
