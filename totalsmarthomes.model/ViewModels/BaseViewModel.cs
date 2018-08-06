using totalsmarthomes.Models.Interfaces;
using System.Globalization;


namespace totalsmarthomes.Models.ViewModels
{
    public class BaseViewModel<T> : IBaseViewModel<T> where T : Base.BaseModel
    {
        public T CurrentPage { get; private set; }

        public BaseViewModel(T currentPage)
        {
            CurrentPage = currentPage;

            var region = new RegionInfo(Culture.LCID);
            CountryName = region.TwoLetterISORegionName;
            Language = Culture.Name;

            // Defaults
            CustomDateFormat = string.IsNullOrEmpty(DateFormat) ? Culture.DateTimeFormat.ShortDatePattern : DateFormat;
        }

        public string SummaryMessage { get; set; }
        public string ErrorMessage { get; set; }
        public CultureInfo DefaultCulture { get; } = new CultureInfo("en-GB");
        public string CountryName { get; set; }
        public string Language { get; set; }
        public string CustomDateFormat { get; set; }

        //Layout properties from Home page - globally used
        public int CountryCode { get; set; }

        public int CompanyCode { get; set; }

        public CultureInfo Culture { get; set; }

        public string DateFormat { get; set; }
         
        public string TimeZone { get; set; }
    }   
}