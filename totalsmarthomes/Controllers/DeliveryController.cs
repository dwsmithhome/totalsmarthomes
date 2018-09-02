using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Delivery;
using StoreFront.Model.ViewModel.Delivery;

namespace totalsmarthomes.Controllers
{
    [Authorize]
    public class DeliveryController : Controller
    {
        IPage<DeliveryPageViewModel, DeliveryPageModel> _page;

        public DeliveryController(IPage<DeliveryPageViewModel, DeliveryPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_page.Load());
        }

        public IActionResult Continue(DeliveryPageModel model)
        {
            var result = _page.Process(model);

            if (result.Type == StoreFront.Model.Enum.Response.DataResponseType.SUCCESS)
            {
                return RedirectToAction("Index", "Checkout");
            }

            return View(_page.Load(model));   
                
        }
    }
}
