using StoreFront.Model.PageModel.Search;
using StoreFront.Model.Interface;
using StoreFront.Model.Search;
using StoreFront.Model.Base;

namespace StoreFront.Model.ViewModel.Search
{
    public class SearchPageViewModel : BaseViewModel<BaseModel>, IBaseViewModel<BaseModel>
    {
        private readonly SearchPageModel _currentPage;

        public SearchPageViewModel(SearchPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public int PageSize { get { return _currentPage.Content.GetPropertyValue<int>("pageSize") == 0 ? 5 : _currentPage.Content.GetPropertyValue<int>("pageSize"); } }

        public string SearchTerm { get; set; }

        public SearchResultsModel SearchResults { get; set; }
    }
}