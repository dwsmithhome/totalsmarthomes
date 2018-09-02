using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Payment;
using StoreFront.Model.ViewModel.Payment;

namespace totalsmarthomes.Controllers
{
    public class PaymentController : Controller
    {
        IPage<PaymentPageViewModel, PaymentPageModel> _page;

        public PaymentController(IPage<PaymentPageViewModel, PaymentPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_page.Load());
        }

        public IActionResult Pay(PaymentPageModel model)
        {
            var result = _page.Process(model);

            if (result.Type == StoreFront.Model.Enum.Response.DataResponseType.SUCCESS)
            { 
                return RedirectToAction("Index", "Confirmation", new { id = result.Details }); 
            }

            return View("Index", _page.Load(model));

        }
    }
}
