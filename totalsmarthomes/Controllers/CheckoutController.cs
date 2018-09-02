using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Checkout;
using StoreFront.Model.ViewModel.Checkout;

namespace totalsmarthomes.Controllers
{
    public class CheckoutController : Controller
    {

        IPage<CheckoutPageViewModel, CheckoutPageModel> _page;

        public CheckoutController(IPage<CheckoutPageViewModel, CheckoutPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_page.Load());
        }
    }
}
