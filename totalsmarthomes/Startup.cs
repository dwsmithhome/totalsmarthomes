using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreFront.Model.Interface;
using StoreFront.Model.Content;
using StoreFront.Service.API;
using StoreFront.Model.APIModel.Customer;
using StoreFront.Model.APIModel.Product;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.APIModel.Resource;
using StoreFront.Service;
using StoreFront.Model.ViewModel.Basket;
using StoreFront.Model.ViewModel.About;
using StoreFront.Model.ViewModel.Brand;
using StoreFront.Model.ViewModel.Checkout;
using StoreFront.Model.ViewModel.Confirmation;
using StoreFront.Model.ViewModel.Delivery;
using StoreFront.Model.ViewModel.HomePage;
using StoreFront.Model.ViewModel.Legal;
using StoreFront.Model.ViewModel.Order;
using StoreFront.Model.ViewModel.Payment;
using StoreFront.Model.ViewModel.Product;
using StoreFront.Model.ViewModel.Profile;
using StoreFront.Model.ViewModel.Register;
using StoreFront.Model.ViewModel.TextPage;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using StoreFront.Model.ViewModel.Login;
using StoreFront.Model.ViewModel.Account;
using Microsoft.AspNetCore.DataProtection;
using StoreFront.Model.ViewModel.ProductDetail;
using StoreFront.Model.PageModel.Account;
using StoreFront.Model.PageModel.About;
using StoreFront.Model.PageModel.Basket;
using StoreFront.Model.PageModel.Brand;
using StoreFront.Model.PageModel.Checkout;
using StoreFront.Model.PageModel.Confirmation;
using StoreFront.Model.PageModel.Delivery;
using StoreFront.Model.PageModel.HomePage;
using StoreFront.Model.PageModel.Legal;
using StoreFront.Model.PageModel.Order;
using StoreFront.Model.PageModel.Payment;
using StoreFront.Model.PageModel.Product;
using StoreFront.Model.PageModel.Search;
using StoreFront.Model.PageModel.Register;
using StoreFront.Model.PageModel.Profile;
using StoreFront.Model.PageModel.TextPage;
using StoreFront.Model.PageModel.Login;
using StoreFront.Model.PageModel.ProductDetail;
using StoreFront.Service.Render;
using StoreFront.Model.ViewModel.ResetPassword;
using StoreFront.Model.PageModel.ResetPassword;

namespace totalsmarthomes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie((CookieAuthenticationOptions obj) => obj.LoginPath = "/Login/Index/");

            services.AddDataProtection();

            services.AddTransient<ISAL<Contact>, GenericSAL<Contact>>();
            services.AddTransient<ISAL<Security>, GenericSAL<Security>>();
            services.AddTransient<ISAL<Customer>, GenericSAL<Customer>>();
            services.AddTransient<ISAL<StoreFront.Model.APIModel.Customer.DeliveryAddress>, GenericSAL<StoreFront.Model.APIModel.Customer.DeliveryAddress>>();
            services.AddTransient<ISAL<StoreFront.Model.APIModel.Customer.InvoiceAddress>, GenericSAL<StoreFront.Model.APIModel.Customer.InvoiceAddress>>();
            services.AddTransient<ISAL<Terms>, GenericSAL<Terms>>();

            services.AddTransient<ISAL<Category>, GenericSAL<Category>>();
            services.AddTransient<ISAL<Price>, GenericSAL<Price>>();
            services.AddTransient<ISAL<Product>, GenericSAL<Product>>();
            services.AddTransient<IListSAL<ProductListItem>, GenericListSAL<ProductListItem>>();
            services.AddTransient<ISAL<ProductCategory>, GenericSAL<ProductCategory>>();
            services.AddTransient<ISearchSAL<Detail>, GenericSearchSAL<Detail>>();
            services.AddTransient<ISearchSAL<Extra>, GenericSearchSAL<Extra>>();
            services.AddTransient<ISearchSAL<Specification>, GenericSearchSAL<Specification>>();

            services.AddTransient<ISAL<Basket>, GenericSAL<Basket>>();
            services.AddTransient<ISAL<BasketDelivery>, GenericSAL<BasketDelivery>>();
            services.AddTransient<IListSAL<BasketListItem>, GenericListSAL<BasketListItem>>();
            services.AddTransient<ISAL<BasketDelivery>, GenericSAL<BasketDelivery>>();
            services.AddTransient<ISAL<StoreFront.Model.APIModel.Purchase.DeliveryAddress>, GenericSAL<StoreFront.Model.APIModel.Purchase.DeliveryAddress>>();
            services.AddTransient<ISAL<StoreFront.Model.APIModel.Purchase.InvoiceAddress>, GenericSAL<StoreFront.Model.APIModel.Purchase.InvoiceAddress>>();
            services.AddTransient<ISAL<Order>, GenericSAL<Order>>();

            services.AddTransient<IActionSAL<BasketTransfer>, GenericActionSAL<BasketTransfer>>();
            services.AddTransient<IActionSAL<PlaceOrder>, GenericActionSAL<PlaceOrder>>();
            services.AddTransient<ISAL<OrderItem>, GenericSAL<OrderItem>>();
            services.AddTransient<ISAL<OrderStatus>, GenericSAL<OrderStatus>>();
            services.AddTransient<ISAL<Transaction>, GenericSAL<Transaction>>();
            services.AddTransient<ISAL<OrderDelivery>, GenericSAL<OrderDelivery>>();
            services.AddTransient<ISAL<ContactType>, GenericSAL<ContactType>>();
            services.AddTransient<ISAL<Country>, GenericSAL<Country>>();
            services.AddTransient<ISAL<DeliveryOption>, GenericSAL<DeliveryOption>>();
            services.AddTransient<ISAL<OrderStatusType>, GenericSAL<OrderStatusType>>();

            services.AddTransient<IPage<AccountPageViewModel, AccountPageModel>, StoreFront.Service.Account.Account>();
            services.AddTransient<IPage<AboutPageViewModel, AboutPageModel>, StoreFront.Service.About.About>();
            services.AddTransient<IPage<BasketPageViewModel, BasketPageModel>, StoreFront.Service.Basket.Basket>();
            services.AddTransient<IPage<BrandPageViewModel, BrandPageModel>, StoreFront.Service.Brand.Brand>();
            services.AddTransient<IPage<CheckoutPageViewModel, CheckoutPageModel>, StoreFront.Service.Checkout.Checkout>();
            services.AddTransient<IPage<ConfirmationPageViewModel, ConfirmationPageModel>, StoreFront.Service.Confirmation.Confirmation>();
            services.AddTransient<IPage<DeliveryPageViewModel, DeliveryPageModel>, StoreFront.Service.Delivery.Delivery>();
            services.AddTransient<IPage<HomePageViewModel, HomePageModel>, StoreFront.Service.Home.Home>();
            services.AddTransient<IPage<LegalPageViewModel, LegalPageModel>, StoreFront.Service.Legal.Legal>();
            services.AddTransient<IPage<OrderPageViewModel, OrderPageModel>, StoreFront.Service.Order.Order>();
            services.AddTransient<IPage<PaymentPageViewModel, PaymentPageModel>, StoreFront.Service.Payment.Payment>();
            services.AddTransient<IPage<ProductPageViewModel, ProductPageModel>, StoreFront.Service.Product.Product>();
            services.AddTransient<IPage<ProfilePageViewModel, ProfilePageModel>, StoreFront.Service.Profile.Profile>();
            services.AddTransient<IPage<RegisterPageViewModel, RegisterPageModel>, StoreFront.Service.Register.Register>();
            services.AddTransient<IPage<StoreFront.Model.ViewModel.Search.SearchPageViewModel, SearchPageModel>, StoreFront.Service.Search.Search>();
            services.AddTransient<IPage<TextPageViewModel, TextPageModel>, StoreFront.Service.TextPage.TextPage>();
            services.AddTransient<IPage<LoginPageViewModel, LoginPageModel>, StoreFront.Service.Login.Login>();
            services.AddTransient<IPage<ProductDetailPageViewModel, ProductDetailPageModel>, StoreFront.Service.ProductDetail.ProductDetail>();
            services.AddTransient<IPage<ResetPasswordPageViewModel, ResetPasswordPageModel>, StoreFront.Service.ResetPassword.ResetPassword>();

            services.AddTransient<IHttpManager<Contact>, HttpManager<Contact>>();
            services.AddTransient<IHttpManager<Customer>, HttpManager<Customer>>();
            services.AddTransient<IHttpManager<StoreFront.Model.APIModel.Customer.DeliveryAddress>, HttpManager<StoreFront.Model.APIModel.Customer.DeliveryAddress>>();
            services.AddTransient<IHttpManager<StoreFront.Model.APIModel.Customer.InvoiceAddress>, HttpManager<StoreFront.Model.APIModel.Customer.InvoiceAddress>>();
            services.AddTransient<IHttpManager<Security>, HttpManager<Security>>();
            services.AddTransient<IHttpManager<Terms>, HttpManager<Terms>>();

            services.AddTransient<IHttpManager<Category>, HttpManager<Category>>();
            services.AddTransient<IHttpManager<Price>, HttpManager<Price>>();
            services.AddTransient<IHttpManager<Product>, HttpManager<Product>>();
            services.AddTransient<IHttpManager<ProductCategory>, HttpManager<ProductCategory>>();
            services.AddTransient<IHttpManager<ProductListItem>, HttpManager<ProductListItem>>();

            services.AddTransient<IHttpManager<Basket>, HttpManager<Basket>>();
            services.AddTransient<IHttpManager<BasketDelivery>, HttpManager<BasketDelivery>>();
            services.AddTransient<IHttpManager<BasketListItem>, HttpManager<BasketListItem>>();
            services.AddTransient<IHttpManager<BasketDelivery>, HttpManager<BasketDelivery>>();
            services.AddTransient<IHttpManager<OrderDelivery>, HttpManager<OrderDelivery>>();
            services.AddTransient<IHttpManager<StoreFront.Model.APIModel.Purchase.DeliveryAddress>, HttpManager<StoreFront.Model.APIModel.Purchase.DeliveryAddress>>();
            services.AddTransient<IHttpManager<StoreFront.Model.APIModel.Purchase.InvoiceAddress>, HttpManager<StoreFront.Model.APIModel.Purchase.InvoiceAddress>>();
            services.AddTransient<IHttpManager<Order>, HttpManager<Order>>();
            services.AddTransient<IHttpManager<OrderItem>, HttpManager<OrderItem>>();
            services.AddTransient<IHttpManager<OrderStatus>, HttpManager<OrderStatus>>();
            services.AddTransient<IHttpManager<Transaction>, HttpManager<Transaction>>();
            services.AddTransient<IHttpManager<BasketTransfer>, HttpManager<BasketTransfer>>();
            services.AddTransient<IHttpManager<PlaceOrder>, HttpManager<PlaceOrder>>();


            services.AddTransient<IHttpManager<ContactType>, HttpManager<ContactType>>();
            services.AddTransient<IHttpManager<Country>, HttpManager<Country>>();
            services.AddTransient<IHttpManager<DeliveryOption>, HttpManager<DeliveryOption>>();
            services.AddTransient<IHttpManager<OrderStatusType>, HttpManager<OrderStatusType>>();

            services.AddScoped<IViewRenderService, ViewRenderService>();
            services.AddTransient<IHttpFactory, HttpFactory>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IContent, Content>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            var cookiePolicyOptions = new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict,
            };

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy(cookiePolicyOptions);


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=SplashPage}/{id?}");

                routes.MapRoute(
                    name: "item",
                    template: "{controller=Home}/{action=SplashPage}/{id?}/{item}");
            });
        }
    }
}
