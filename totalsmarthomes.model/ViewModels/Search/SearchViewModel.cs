using System.Collections.Generic;
using totalsmarthomes.Models.PageModels.Search;
using totalsmarthomes.Models.Interfaces;
using totalsmarthomes.Models.Search;

namespace totalsmarthomes.Models.ViewModels.Search
{
    public class SearchViewModel : BaseViewModel<SearchPageModel>
    {
        private readonly SearchPageModel _currentPage;

        public SearchViewModel(SearchPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }


        public int PageSize { get { return _currentPage.Content.GetPropertyValue<int>("pageSize") == 0 ? 5 : _currentPage.Content.GetPropertyValue<int>("pageSize"); } }

        public string SearchTerm { get; set; }

        public SearchResultsModel SearchResults { get; set; }
    }
}