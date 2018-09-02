using System;
using System.Collections.Generic;
using StoreFront.Model.APIModel.Resource;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;
using StoreFront.Model.PageModel.Delivery;

namespace StoreFront.Model.ViewModel.Delivery
{
    public class DeliveryPageViewModel: BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        readonly DeliveryPageModel _currentPage;

        public DeliveryPageViewModel(DeliveryPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public bool UserInvoiceAddress { get { return _currentPage.UserInvoiceAddress; } set { _currentPage.UserInvoiceAddress = value; } }

        public bool NewAddress { get { return _currentPage.NewAddress; } set { _currentPage.NewAddress = value; } }

        public string InvoiceAddress1 { get { return _currentPage.InvoiceAddress1; } set { _currentPage.InvoiceAddress1 = value; } }

        public string InvoiceAddress2 { get { return _currentPage.InvoiceAddress2; } set { _currentPage.InvoiceAddress2 = value; } }

        public string InvoiceAddress3 { get { return _currentPage.InvoiceAddress3; } set { _currentPage.InvoiceAddress3 = value; } }

        public string InvoiceAddress4 { get { return _currentPage.InvoiceAddress4; } set { _currentPage.InvoiceAddress4 = value; } }

        public string Postcode { get { return _currentPage.Postcode; } set { _currentPage.Postcode = value; } }


        public string DeliveryAddress1 { get { return _currentPage.DeliveryAddress1; } set { _currentPage.DeliveryAddress1 = value; } }

        public string DeliveryAddress2 { get { return _currentPage.DeliveryAddress2; } set { _currentPage.DeliveryAddress2 = value; } }

        public string DeliveryAddress3 { get { return _currentPage.DeliveryAddress3; } set { _currentPage.DeliveryAddress3 = value; } }

        public string DeliveryAddress4 { get { return _currentPage.DeliveryAddress4; } set { _currentPage.DeliveryAddress4 = value; } }

        public string DeliveryPostcode { get { return _currentPage.DeliveryPostcode; } set { _currentPage.DeliveryPostcode = value; } }

        public ICollection<DeliveryOption> DeliveryOptions { get { return _currentPage.DeliveryOptions; } }

        public int DeliverySelection { get { return _currentPage.DeliverySelection; } set{ _currentPage.DeliverySelection = value;}}
    }
}
