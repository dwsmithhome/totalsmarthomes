using Umbraco.Web;
using Umbraco.Web.Models;

namespace AppointmentBooking.Models.PageModels.Appointment
{
    public class CancelPageModel : RenderModel
    {
        public CancelPageModel(): base(UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {
        }
    }
}