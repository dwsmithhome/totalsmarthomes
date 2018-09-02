using System;
using System.Collections.Generic;
using StoreFront.Model.APIModel.Resource;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.Delivery
{
    public class DeliveryPageModel : BaseModel, IContent
    {
        public bool UserInvoiceAddress { get; set; }

        public bool NewAddress { get; set; }

        public string InvoiceAddress1 { get; set; }

        public string InvoiceAddress2 { get; set; }

        public string InvoiceAddress3 { get; set; }

        public string InvoiceAddress4 { get; set; }

        public string Postcode { get; set; }

        public string DeliveryAddress1 { get; set; }

        public string DeliveryAddress2 { get; set; }

        public string DeliveryAddress3 { get; set; } 

        public string DeliveryAddress4 { get; set; }

        public string DeliveryPostcode { get; set; }

        public ICollection<DeliveryOption> DeliveryOptions { get; set; }

        public int DeliverySelection { get; set; }
    }
}
