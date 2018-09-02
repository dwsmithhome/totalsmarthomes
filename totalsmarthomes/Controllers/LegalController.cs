using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Legal;
using StoreFront.Model.ViewModel.Legal;

namespace totalsmarthomes.Controllers
{
    public class LegalController : Controller
    {
        IPage<LegalPageViewModel, LegalPageModel> _page;

        public LegalController(IPage<LegalPageViewModel, LegalPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Termsandconditions()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Cookiesandprivacypolicy()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Accessibility()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Acceptableusepolicy()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Delivery()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Returns()
        {
            return View("Index", _page.Load());
        }
    }
}
