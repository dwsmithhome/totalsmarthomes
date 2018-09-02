using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.ProductDetail;
using StoreFront.Model.Parameter;
using StoreFront.Model.ViewModel.ProductDetail;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace totalsmarthomes.Controllers
{
    public class ProductDetailController : Controller
    {
        IPage<ProductDetailPageViewModel, ProductDetailPageModel> _page;
        private readonly IHttpContextAccessor _httpContextAccessor; 


        public ProductDetailController(IPage<ProductDetailPageViewModel, ProductDetailPageModel> page, IHttpContextAccessor httpContextAccessor)
        {
            _page = page;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            
            return View(_page.Load(new SearchParameter{
                Name = "ProductID",
                Value = id
            }));
        }

        public IActionResult Add(ProductDetailPageModel model)
        {
            var page = (StoreFront.Service.ProductDetail.ProductDetail)_page;
            var success = false;
            var quantity = model.Quantity;
            var basketID = 0;

            if (page.Basket.Any(x => x.ProductID == model.Product.ProductID))
            {
                var row = page.Basket.FirstOrDefault(x => x.ProductID == model.Product.ProductID);

                if (quantity + row.Quantity <= 10)
                {
                    quantity += row.Quantity;
                }
                else
                { 
                    quantity = 10; 
                }

                basketID = row.BasketID;
            }

            success = page.AddToBasket(new StoreFront.Model.APIModel.Purchase.Basket
            {
                BasketID = basketID,
                CustomerID = User.Identity.IsAuthenticated ? Int32.Parse(User.Identity.Name) : (int?)null,
                ProductID = model.Product.ProductID,
                Quantity = quantity,
                BasketGUID = User.Identity.IsAuthenticated ? "" : page.GUID,
            });

            if(success)
            {
                return RedirectToAction("Index", "Basket");
            }



            return View(_page.Load(new SearchParameter
            {
                Name = "ProductID",
                Value = model.Product.ProductID
            }));
        }


    }
}
