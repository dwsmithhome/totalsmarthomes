using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Search;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace totalsmarthomes.Controllers
{

    public class SearchController : Controller
    {
        IPage<StoreFront.Model.ViewModel.Search.SearchPageViewModel, SearchPageModel> _page;

        public SearchController(IPage<StoreFront.Model.ViewModel.Search.SearchPageViewModel, SearchPageModel> page)
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
