using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Order;
using StoreFront.Model.ViewModel.Order;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace totalsmarthomes.Controllers
{
    public class OrderController : Controller
    {
        IPage<OrderPageViewModel, OrderPageModel> _page;

        public OrderController(IPage<OrderPageViewModel, OrderPageModel> page)
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
