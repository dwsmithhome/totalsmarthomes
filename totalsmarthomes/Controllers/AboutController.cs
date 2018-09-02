using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.About;
using StoreFront.Model.ViewModel.About;

namespace totalsmarthomes.Controllers
{
    public class AboutController : Controller
    {
        IPage<AboutPageViewModel, AboutPageModel> _page;

        public AboutController(IPage<AboutPageViewModel, AboutPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult About()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Products()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Services()
        {
            return View("Index", _page.Load());
        }

    }
}
