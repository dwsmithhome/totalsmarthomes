using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using StoreFront.Model.APIModel.Product;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Product;
using StoreFront.Model.Parameter;
using StoreFront.Model.ViewModel.Product;
using StoreFront.Service.Base;
using System.Linq;
using Microsoft.AspNetCore.Http;
using StoreFront.Model.Base;
using StoreFront.Model.Response;
using StoreFront.Model.Paging;
using System.Threading.Tasks;

namespace StoreFront.Service.Product
{
    public class Product : BasePage, IPage<ProductPageViewModel, ProductPageModel>
    {
        IListSAL<ProductListItem> _productListService;
        IConfiguration _configuration;

        public string Category { get; set; }
        public int PageIndex { get; set; }
        public int PagingSize { get; set; }
        public int SortOrder { get; set; }

        public Product(IContent page, ISAL<Model.APIModel.Purchase.Basket> basketService, IListSAL<ProductListItem> productListService, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(page, basketService, httpContextAccessor)
        {
            Category = "";
            _productListService = productListService;
            _configuration = configuration;
        }

        public ProductPageViewModel Load(params SearchParameter[] list)
        {
            Category = (string)list.FirstOrDefault(x => x.Name == "Category").Value;
            PageIndex = (int)list.FirstOrDefault(x => x.Name == "PageIndex").Value;
            SortOrder = (int)list.FirstOrDefault(x => x.Name == "SortOrder").Value;
            PagingSize = Int32.Parse(_configuration["PagingSize"]);


            var productsPageModel = new ProductPageModel
            {
                Content = (Model.Content.Content)_model
            };


            var productList = GetProducts();



            productsPageModel.AddProperty("productList", productList);
            productsPageModel.AddProperty("category", Category);
            productsPageModel.AddProperty("pageIndex", PageIndex);

            return new ProductPageViewModel(productsPageModel);
        }

        private PaginatedList<ProductListItem> GetProducts()
        {
            var products = _productListService.Search(new List<SearchParameter>
            {
                new SearchParameter{
                    Name = "Category",
                    Value = Category
                },
                new SearchParameter{
                    Name = "CountryID",
                    Value = _configuration["CountryID"]
                }

            }).OrderBy(x => x.Price);

            if(SortOrder == 1)
            {
                products = products.OrderByDescending(x => x.Price);
            }

            return PaginatedList<ProductListItem>.Create(_productListService.Search(new List<SearchParameter>
            {
                new SearchParameter{
                    Name = "Category",
                    Value = Category
                },
                new SearchParameter{
                    Name = "CountryID",
                    Value = _configuration["CountryID"]
                }

            }).AsQueryable(), PageIndex, PagingSize);
        }

        public ProductPageViewModel Load(BaseModel model)
        {
            return new ProductPageViewModel((ProductPageModel)model);
        }

        public DataResponse Process(ProductPageModel model)
        {
            return new DataResponse { Type = Model.Enum.Response.DataResponseType.SUCCESS, Details = "" };
        }
    }
}
