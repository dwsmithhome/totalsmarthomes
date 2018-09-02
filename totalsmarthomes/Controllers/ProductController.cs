using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Product;
using StoreFront.Model.Parameter;
using StoreFront.Model.ViewModel.Product;


namespace totalsmarthomes.Controllers
{
    public class ProductController : Controller
    {
        IPage<ProductPageViewModel, ProductPageModel> _page;

        public ProductController(IPage<ProductPageViewModel, ProductPageModel> page)
        {
            _page = page;
        }

        // GET: /<controller>/
        public IActionResult Lighting(int? pageIndex, int? sortOrder)
        {
            var pageIndexValue = pageIndex ?? 1;
            var sortOrderValue = sortOrder ?? 0;
            return CreatePage(pageIndexValue, sortOrderValue, "Lighting");
        }

        public IActionResult Heating(int? pageIndex, int? sortOrder)
        {
            var pageIndexValue = pageIndex ?? 1;
            var sortOrderValue = sortOrder ?? 0;
            return CreatePage(pageIndexValue, sortOrderValue, "Heating");
        }

        public IActionResult Security(int? pageIndex, int? sortOrder)
        {
            var pageIndexValue = pageIndex ?? 1;
            var sortOrderValue = sortOrder ?? 0;
            return CreatePage(pageIndexValue, sortOrderValue, "Security");
        }

        public IActionResult Power(int? pageIndex, int? sortOrder)
        {
            var pageIndexValue = pageIndex ?? 1;
            var sortOrderValue = sortOrder ?? 0;
            return CreatePage(pageIndexValue, sortOrderValue, "Power");
        }

        public IActionResult Appliances(int? pageIndex, int? sortOrder)
        {
            var pageIndexValue = pageIndex ?? 1;
            var sortOrderValue = sortOrder ?? 0;
            return CreatePage(pageIndexValue, sortOrderValue, "Appliances");
        }

        private IActionResult CreatePage(int pageIndexValue, int sortOrderValue, string category)
        {
            return View("Index", _page.Load(new SearchParameter { Name = "Category", Value = category }, new SearchParameter { Name = "PageIndex", Value = pageIndexValue }, new SearchParameter { Name = "SortOrder", Value = sortOrderValue }));
        }
    }
}
