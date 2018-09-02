using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreFront.Model.APIModel.Product;
using StoreFront.Model.Base;
using StoreFront.Model.PageModel.Product;
using StoreFront.Model.Paging;

namespace StoreFront.Model.ViewModel.Product
{
    public class ProductPageViewModel : BaseViewModel<BaseModel>
    {
        readonly ProductPageModel _currentPage;

        public ProductPageViewModel(ProductPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public SelectList SortList
        {
            get
            {
                return new SelectList(new List<SelectListItem>{
                    new SelectListItem{ Text = "Price (Low to High)", Value = "1" },
                    new SelectListItem{ Text = "Price (High to Low)", Value = "2" },
                }, "Value", "Text");
            }
        }

        public int SortOrder { get { return _currentPage.SortOrder; } set { _currentPage.SortOrder = value; }}

        public PaginatedList<ProductListItem> ProductList { get { return _currentPage.GetPropertyValue<PaginatedList<ProductListItem>>("productList"); } }
    
        public string Category { get { return _currentPage.GetPropertyValue<string>("category"); } }

        public int PageIndex { get { return _currentPage.GetPropertyValue<int>("pageIndex"); } }
    }
}
