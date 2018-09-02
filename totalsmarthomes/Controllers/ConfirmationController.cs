using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Confirmation;
using StoreFront.Model.Parameter;
using StoreFront.Model.ViewModel.Confirmation;

namespace totalsmarthomes.Controllers
{
    public class ConfirmationController : Controller
    {
        IPage<ConfirmationPageViewModel, ConfirmationPageModel> _page;

        public ConfirmationController(IPage<ConfirmationPageViewModel, ConfirmationPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            return View(_page.Load(new SearchParameter{ Name = "TransactionID", Value = id}));
        }
    }
}
