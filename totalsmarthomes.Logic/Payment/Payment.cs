using System;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Payment;
using StoreFront.Model.ViewModel.Payment;
using StoreFront.Service.Base;
using StoreFront.Model.Parameter;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;
using StoreFront.Model.APIModel.Purchase;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;
using StoreFront.Model.APIModel.Customer;
using System.Collections.Generic;
using System.Linq;
using StoreFront.Service.Render;
using System.Net.Mime;
using System.Text;

namespace StoreFront.Service.Payment
{
    public class Payment : BasePage, IPage<PaymentPageViewModel, PaymentPageModel>
    {
        IActionSAL<PlaceOrder> _placeOrderSAL;
        ISAL<Contact> _contactSAL;
        IHttpContextAccessor _httpContextAccessor;
        IConfiguration _configuration;
        private readonly IViewRenderService _viewRenderService;

        public Payment(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IHttpContextAccessor httpContextAccessor,
                       IActionSAL<PlaceOrder> placeOrderSAL, IConfiguration configuration, ISAL<Contact> contactSAL, IViewRenderService viewRenderService) : base(page, basketService, httpContextAccessor)
        {
            _placeOrderSAL = placeOrderSAL;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _contactSAL = contactSAL;
            _viewRenderService = viewRenderService;
        }

        public PaymentPageViewModel Load(params SearchParameter[] list)
        {

            var paymentPageModel = new PaymentPageModel
            {
                Content = (Model.Content.Content)_model
            };

            return new PaymentPageViewModel(paymentPageModel);
        }

        public PaymentPageViewModel Load(BaseModel model)
        {
            return new PaymentPageViewModel((PaymentPageModel)model);
        }

        public DataResponse Process(PaymentPageModel model)
        {
            var result = _placeOrderSAL.Post(new PlaceOrder{
                CustomerID = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name),
                CountryID = Int32.Parse(_configuration["CountryID"]),
                TransactionID = "TempID" + DateTime.Now.TimeOfDay

            });

            var email = _contactSAL.Search(new List<SearchParameter>
            {
                new SearchParameter{
                    Name = "CustomerID",
                    Value = Int32.Parse(_httpContextAccessor.HttpContext.User.Identity.Name)
                },
                new SearchParameter{
                    Name = "ContactTypeID",
                    Value = (int)Model.Enum.Customer.ContactType.Email
                }
            });



            var emailBody = _viewRenderService.RenderToStringAsync("Render/Receipt", new object()).Result;

            SmtpClient client = new SmtpClient("relay.hostinguk.net");
            client.UseDefaultCredentials = true;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("info@totalsmarthomes.com");
            mailMessage.To.Add(email.FirstOrDefault().Value);

            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.SubjectEncoding = Encoding.UTF8;

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(emailBody);
            htmlView.ContentType = new ContentType("text/html");
            mailMessage.Body = emailBody;
            mailMessage.AlternateViews.Add(htmlView);
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = "Your receipt from totalsmarthomes.com";
            client.Send(mailMessage);

            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = result.Details };
        }
    }
}
