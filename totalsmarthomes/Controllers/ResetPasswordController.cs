using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.ResetPassword;
using StoreFront.Model.ViewModel.ResetPassword;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace totalsmarthomes.Controllers
{
    public class ResetPasswordController : Controller
    {
        // GET: api/values
        IPage<ResetPasswordPageViewModel, ResetPasswordPageModel> _page;

        public ResetPasswordController(IPage<ResetPasswordPageViewModel, ResetPasswordPageModel> page)
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
