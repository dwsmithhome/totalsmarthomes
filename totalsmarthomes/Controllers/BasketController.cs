using System;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Basket;
using StoreFront.Model.ViewModel.Basket;

namespace totalsmarthomes.Controllers
{
    public class BasketController : Controller
    {
        IPage<BasketPageViewModel, BasketPageModel> _page;

        public BasketController(IPage<BasketPageViewModel, BasketPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index", _page.Load());
        }

        public IActionResult Delete(string id)
        {
            var page = (StoreFront.Service.Basket.Basket)_page;

            var success = page.DeleteItem(id);

            if (success)
                return RedirectToAction("Index");
            
            return View();

        }

        [HttpGet]
        public ActionResult UpdateQuantity(string value, string id)
        {
            var page = (StoreFront.Service.Basket.Basket)_page;
            var result = page.UpdateQuantity(Int32.Parse(id), Int32.Parse(value));

            if(result.Type == StoreFront.Model.Enum.Response.DataResponseType.SUCCESS)
                return Json(new { status = "Success", message = "Success" });

            return Json(new { status = "Error", message = "Error" });
                
        }
    }
}
