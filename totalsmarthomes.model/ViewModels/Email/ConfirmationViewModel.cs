

namespace AppointmentBooking.Models.ViewModels.Email
{
    public class ConfirmationViewModel
    {
       

        public ConfirmationViewModel()
        {

        }

        public string SubjectLine { get; set; }


        public string EmailHeader { get; set; }


        public string EmailFooter { get; set; }

       
        public string EmailBody { get; set; }


        public string SameDayMessage { get; set; }


        public string FutureDayMessage { get; set; }


        public string TelephoneLabel { get; set; }
    }
}