using Umbraco.Web;
using Umbraco.Web.Models;

namespace AppointmentBooking.Models.PageModels.Appointment
{
    public class AppointmentPageModel : RenderModel
    {
        public AppointmentPageModel() : base(UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {
        }
    }
}