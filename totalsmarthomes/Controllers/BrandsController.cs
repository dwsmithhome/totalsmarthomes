using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Brand;
using StoreFront.Model.ViewModel.Brand;

namespace totalsmarthomes.Controllers
{
    public class BrandsController : Controller
    {

        IPage<BrandPageViewModel, BrandPageModel> _page;

        public BrandsController(IPage<BrandPageViewModel, BrandPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Yale()
        {
            return View("Index", _page.Load());
        }
    }
}
