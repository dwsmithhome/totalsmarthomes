using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreFront.Model.APIModel.Purchase;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Basket;

namespace StoreFront.Model.ViewModel.Basket
{
    public class BasketPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly BasketPageModel _currentPage;

        public BasketPageViewModel(BasketPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public IEnumerable<BasketListItem> Basket { get { return _currentPage.GetPropertyValue<IEnumerable<BasketListItem>>("basket"); } }

        public int BasketCount { get { return ((int)_currentPage.GetPropertyValue<int>("basketCounter"));  }}

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
    }
}
