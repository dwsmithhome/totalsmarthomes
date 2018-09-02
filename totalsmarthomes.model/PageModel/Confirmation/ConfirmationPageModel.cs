using System;
using StoreFront.Model.Base;
using StoreFront.Model.Interface;

namespace StoreFront.Model.PageModel.Confirmation
{
    public class ConfirmationPageModel : BaseModel, IContent
    {
        public ConfirmationPageModel()
        {
        }

        public string TransactionID { get; set; }
    }
}
