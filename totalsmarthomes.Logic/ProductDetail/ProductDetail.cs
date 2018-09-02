using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using StoreFront.Model.APIModel.Product;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.ProductDetail;
using StoreFront.Model.Parameter;
using StoreFront.Model.Response;
using StoreFront.Model.ViewModel.ProductDetail;
using StoreFront.Service.Base;

namespace StoreFront.Service.ProductDetail
{
    public class ProductDetail : BasePage, IPage<ProductDetailPageViewModel, ProductDetailPageModel>
    {
        ISAL<Model.APIModel.Product.Product> _productService;
        ISAL<Price> _priceService;
        ISAL<Model.APIModel.Purchase.Basket> _basketService;
        IConfiguration _configuration;

        public int ProductID { get; set; }

        public ProductDetail(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, ISAL<Model.APIModel.Product.Product> productService, ISAL<Price> priceService, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(page, basketService, httpContextAccessor)
        {
            _priceService = priceService;
            _productService = productService;
            _basketService = basketService;
            _configuration = configuration;
        }

        public ProductDetailPageViewModel Load(params SearchParameter[] list)
        {
            ProductID = (int)list.FirstOrDefault(x => x.Name == "ProductID").Value;
            var product = _productService.Get(ProductID.ToString());
            var price = _priceService.Search(new List<SearchParameter>{
                new SearchParameter{
                    Name = "CountryID",
                    Value = Int32.Parse(_configuration["CountryID"])
                },
                new SearchParameter{
                    Name = "ProductID",
                    Value = ProductID
                }
            });

            var productDetailPageModel = new ProductDetailPageModel
            {
                Content = (Model.Content.Content)_model
            };

            productDetailPageModel.AddProperty("product", product);
            productDetailPageModel.Price = price.FirstOrDefault().Value;

            return new ProductDetailPageViewModel(productDetailPageModel);
        }

        public bool AddToBasket(Model.APIModel.Purchase.Basket item)
        {
            if (item.BasketID == 0)
            {
                return _basketService.Post(item).Type == Model.Enum.Response.DataResponseType.SUCCESS;
            }
            else
            { 
                return _basketService.Put(item, item.BasketID.ToString()).Type == Model.Enum.Response.DataResponseType.SUCCESS;
            }
        }

        public ProductDetailPageViewModel Load(BaseModel model)
        {
            return new ProductDetailPageViewModel((ProductDetailPageModel)model);
        }

        public DataResponse Process(ProductDetailPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
