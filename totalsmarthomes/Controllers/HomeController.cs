using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using totalsmarthomes.Models;
using totalsmarthomes.Models.ViewModels.HomePage;

namespace totalsmarthomes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var homePageModel = new Models.PageModels.HomePage.HomePageModel();



            var pageContent = new Models.Content.Content();
            var mobileContent = new Models.Content.Content();
            var bannerContent = new Models.Content.Content();


            bannerContent.Url = "~/Images/banner.jpg";
            bannerContent.AddProperty("bannerBackgroundImage", bannerContent);

            mobileContent.AddProperty("BannerCaption", "hello");

            pageContent.AddProperty("mainBanner", bannerContent);
            pageContent.AddProperty("mobileBanner", mobileContent);


            homePageModel.Content = pageContent;
            var homePageViewModel = new HomePageViewModel(homePageModel);



            return View(homePageViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
