using StoreFront.Model.Interface;
using System.Globalization;
using StoreFront.Model.ViewModel.Shared;
using StoreFront.Model.ViewModel.Resource;

namespace StoreFront.Model.ViewModel
{
    public class BaseViewModel<T> : IBaseViewModel<T> where T : StoreFront.Model.Base.BaseModel
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

        public MetaViewModel Meta { get { return new MetaViewModel(CurrentPage.Content.GetPropertyValue<IContent>("meta")); } }
        public ResourceViewModel Resource { get { return new ResourceViewModel(CurrentPage.Content.GetPropertyValue<IContent>("resource")); } }
        public HeaderViewModel Header { get { return new HeaderViewModel(CurrentPage.Content.GetPropertyValue<IContent>("header")); } }
        public FooterViewModel Footer { get { return new FooterViewModel(CurrentPage.Content.GetPropertyValue<IContent>("footer")); }}

        public int BasketCounter { get { return CurrentPage.Content.GetPropertyValue<int>("basketCounter"); } }

        public string SummaryMessage { get; set; }
        public string ErrorMessage { get; set; }
        public CultureInfo DefaultCulture { get; } = new CultureInfo("en-GB");
        public string CountryName { get; set; }
        public string Language { get; set; }
        public string CustomDateFormat { get; set; }

        //Layout properties from Home page - globally used
        public int CountryCode { get; set; }

        public int CompanyCode { get; set; }

        public CultureInfo Culture { get { return new CultureInfo("en-GB"); } }

        public string DateFormat { get; set; }

        public string TimeZone { get; set; }
    }
}