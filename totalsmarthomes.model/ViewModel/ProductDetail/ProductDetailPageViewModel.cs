using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreFront.Model.Base;
using StoreFront.Model.PageModel.ProductDetail;

namespace StoreFront.Model.ViewModel.ProductDetail
{
    public class ProductDetailPageViewModel : BaseViewModel<BaseModel>
    {
        readonly ProductDetailPageModel _currentPage;

        public ProductDetailPageViewModel(ProductDetailPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public Model.APIModel.Product.Product Product { get { return _currentPage.GetPropertyValue<Model.APIModel.Product.Product>("product"); } }

        public SelectList QuantityList
        {
            get
            {
                return new SelectList(new List<SelectListItem>{
            new SelectListItem{ Text = "1", Value = "1" },
                    new SelectListItem{ Text = "2", Value = "2" },
                    new SelectListItem{ Text = "3", Value = "3" },
                    new SelectListItem{ Text = "4", Value = "4" },
                    new SelectListItem{ Text = "5", Value = "5" },
                    new SelectListItem{ Text = "6", Value = "6" },
                    new SelectListItem{ Text = "7", Value = "7" },
                    new SelectListItem{ Text = "8", Value = "8" },
                    new SelectListItem{ Text = "9", Value = "9" },
                    new SelectListItem{ Text = "10", Value = "10" }
                }, "Text", "Value");
            }
        }

        public int Quantity { get { return _currentPage.Quantity; } set { _currentPage.Quantity = value; } }

        public decimal Price {get { return _currentPage.Price; } set { _currentPage.Price = value; } }
    }
}
