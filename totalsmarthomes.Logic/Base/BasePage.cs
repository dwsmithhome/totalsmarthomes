using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.Parameter;
using StoreFront.Model.ViewModel;
using StoreFront.Model.ViewModel.Shared;



namespace StoreFront.Service.Base
{
    public class BasePage
    {
        protected IContent _model;
        ISAL<Model.APIModel.Purchase.Basket> _basketService;
        IEnumerable<Model.APIModel.Purchase.Basket> _basket;
        IHttpContextAccessor _httpContextAccessor;


        public BasePage(IContent model, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor)
        {
            _model = model;
            _basketService = basketService;
            _httpContextAccessor = httpContextAccessor;

            GetBasket();



            _model.AddProperty("meta", CreateMeta());
            _model.AddProperty("resource", CreateResource());
            _model.AddProperty("header", CreateHeader());
            _model.AddProperty("footer", CreateFooter());
            _model.AddProperty("basket", _basket);
            _model.AddProperty("basketCounter", _basket.Count());
        }

        private void GetBasket()
        {

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                _basket = _basketService.Search(new List<SearchParameter>(){
                new SearchParameter{
                    Name = "CustomerID",
                        Value = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name)

                }
            });

                _httpContextAccessor.HttpContext.Response.Cookies.Delete("GUID");
            }
            else
            {
                _basket = _basketService.Search(new List<SearchParameter>(){
                new SearchParameter{
                        Name = "BasketGUID",
                        Value = GUID
                }
            });
            }
        }

        public string GUID
        {
            get
            {
                return _httpContextAccessor.HttpContext.Request.Cookies["GUID"] ?? CreateTempBasketCookie();
            }
        }

        public IEnumerable<Model.APIModel.Purchase.Basket> Basket  {
            get { return _basket; }
        }



        private string CreateTempBasketCookie()
        {
            var guid = Guid.NewGuid().ToString();
            _httpContextAccessor.HttpContext.Response.Cookies.Append("GUID", guid);

            return guid;
        }


        private static Model.Content.Content CreateFooter()
        {
            var footerContent = new Model.Content.Content();


            footerContent.AddProperty("site", CreateSite());
            footerContent.AddProperty("genericProperties", CreateGenericProperties());
            footerContent.AddProperty("footerCTAButton", CreateFooterCTA());
            footerContent.AddProperty("footerMenu", CreateFooterMenu());


            return footerContent;
        }

        private static List<Model.Content.Content> CreateFooterMenu()
        {
            var footerMenuHeadings = new List<Model.Content.Content>();

            var menuHeading1 = new Model.Content.Content();
            menuHeading1.AddProperty("heading", "legal");

            var menuItems1 = new List<Model.Content.Content>();

            var menuItem1 = new Model.Content.Content
            {
                Name = "terms & conditions",
                Url = "termsandconditions"
            };
            menuItems1.Add(menuItem1);

            var menuItem2 = new Model.Content.Content
            {
                Name = "cookies & privacy policy",
                Url = "cookiesandprivacypolicy"
            };
            menuItems1.Add(menuItem2);

            var menuItem3 = new Model.Content.Content
            {
                Name = "accessibility",
                Url = "accessibility"
            };
            menuItems1.Add(menuItem3);

            var menuItem4 = new Model.Content.Content
            {
                Name = "acceptable use policy",
                Url = "acceptableusepolicy"
            };
            menuItems1.Add(menuItem4);

            var menuItem5 = new Model.Content.Content
            {
                Name = "delivery",
                Url = "delivery"
            };
            menuItems1.Add(menuItem5);

            var menuItem6 = new Model.Content.Content
            {
                Name = "returns",
                Url = "returns"
            };
            menuItems1.Add(menuItem6);


            var menuHeading2 = new Model.Content.Content();
            menuHeading2.AddProperty("heading", "about");

            var menuItems2 = new List<Model.Content.Content>();

            var menuItem21 = new Model.Content.Content
            {
                Name = "totalsmarthomes.com",
                Url = "about"
            };
            menuItems2.Add(menuItem21);

            var menuItem22 = new Model.Content.Content
            {
                Name = "products",
                Url = "products"
            };
            menuItems2.Add(menuItem22);

            var menuItem23 = new Model.Content.Content
            {
                Name = "services",
                Url = "services"
            };
            menuItems2.Add(menuItem23);



            var menuHeading3 = new Model.Content.Content();
            menuHeading3.AddProperty("heading", "brands");

            var menuItems3 = new List<Model.Content.Content>();

            var menuItem31 = new Model.Content.Content
            {
                Name = "Yale",
                Url = "Yale"
            };
            menuItems3.Add(menuItem31);


            menuHeading1.AddProperty("links", menuItems1);
            menuHeading2.AddProperty("links", menuItems2);
            menuHeading3.AddProperty("links", menuItems3);

            footerMenuHeadings.Add(menuHeading1);
            footerMenuHeadings.Add(menuHeading2);
            footerMenuHeadings.Add(menuHeading3);

            return footerMenuHeadings;
        }

        private static Model.Content.Content CreateFooterCTA()
        {
            var footerCTAContent = new Model.Content.Content();
            footerCTAContent.AddProperty("ctaButtonText", "View Products");
            footerCTAContent.AddProperty("url", "Products");
            footerCTAContent.AddProperty("name", "Products");
            return footerCTAContent;
        }

        private static GenericPropertiesViewModel CreateGenericProperties()
        {
            var genericPropertiesContent = new Model.Content.Content();

            genericPropertiesContent.AddProperty("footerCallToAction", false);

            var genericProperties = new GenericPropertiesViewModel(genericPropertiesContent);
            return genericProperties;
        }

        private static Model.Content.Content CreateMeta()
        {
            var metaContent = new Model.Content.Content();
            metaContent.AddProperty("favIcon", "/images/favicon.ico");
            metaContent.AddProperty("metaDescription", "www.totalsmarthomes.com, for all your smart home needs. save money, the environment and make your home more comfortable, accessible and secure.");
            return metaContent;
        }

        private static Model.Content.Content CreateResource()
        {
            var resourceContent = new Model.Content.Content();
            resourceContent.AddProperty("disclaimer", "To give you the best possible experience, this site uses cookies. Continuing to use totalsmarthomes.com means you agree to our cookies policy, if you would like to learn more about the cookies we use please <a href=''>click here to find out more.</a>");
            resourceContent.AddProperty("close", "close");
            return resourceContent;
        }

        private static Model.Content.Content CreateHeader()
        {
            var headerContent = new Model.Content.Content();
            headerContent.AddProperty("site", CreateSite());
            headerContent.AddProperty("menuLevel1", CreateMenu());
            return headerContent;
        }

        private static SiteViewModel CreateSite()
        {
            var siteLogoContent = new Model.Content.Content();
            var siteContent = new Model.Content.Content();

            siteLogoContent.Url = "/Images/logo.gif";
            siteLogoContent.Name = "totalsmarthomes.com";

            siteContent.AddProperty("siteLogo", siteLogoContent);
            siteContent.AddProperty("siteName", "totalsmarthomes");
            var siteViewModel = new SiteViewModel(siteContent);
            return siteViewModel;
        }

        private static List<Model.Content.Content> CreateMenu()
        {
            var topLevelNavigationOptions = new List<Model.Content.Content>();


            var menuItem1 = new Model.Content.Content();
            menuItem1.AddProperty("menuItemTitle", "lighting");
            menuItem1.AddProperty("pageLink", "lighting");
            menuItem1.AddProperty("url", "lighting");
            menuItem1.AddProperty("isCTAMenu", false);
            menuItem1.AddProperty("childMenus", null);

            topLevelNavigationOptions.Add(menuItem1);

            var menuItem2 = new Model.Content.Content();
            menuItem2.AddProperty("menuItemTitle", "heating");
            menuItem2.AddProperty("pageLink", "heating");
            menuItem2.AddProperty("url", "heating");
            menuItem2.AddProperty("isCTAMenu", false);
            menuItem2.AddProperty("childMenus", null);

            topLevelNavigationOptions.Add(menuItem2);


            var menuItem3 = new Model.Content.Content();
            menuItem3.AddProperty("menuItemTitle", "power");
            menuItem3.AddProperty("pageLink", "power");
            menuItem3.AddProperty("url", "power");
            menuItem3.AddProperty("isCTAMenu", false);
            menuItem3.AddProperty("childMenus", null);

            topLevelNavigationOptions.Add(menuItem3);

            var menuItem4 = new Model.Content.Content();
            menuItem4.AddProperty("menuItemTitle", "security");
            menuItem4.AddProperty("pageLink", "security");
            menuItem4.AddProperty("url", "security");
            menuItem4.AddProperty("isCTAMenu", false);
            menuItem4.AddProperty("childMenus", null);

            topLevelNavigationOptions.Add(menuItem4);


            var menuItem5 = new Model.Content.Content();
            menuItem5.AddProperty("menuItemTitle", "appliances");
            menuItem5.AddProperty("pageLink", "appliances");
            menuItem5.AddProperty("url", "appliances");
            menuItem5.AddProperty("isCTAMenu", false);
            menuItem5.AddProperty("childMenus", null);

            topLevelNavigationOptions.Add(menuItem5);

            return topLevelNavigationOptions;
        }
    }
}
