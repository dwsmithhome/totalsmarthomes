using System.Collections.Generic;
using totalsmarthomes.Models.PageModels.TextPages;
using totalsmarthomes.Models.ViewModels.Shared.Footer;
using totalsmarthomes.Models.ViewModels.Shared.Pages;
using totalsmarthomes.Models.ViewModels;
using totalsmarthomes.Models.Interfaces;

namespace AppointmentBooking.Models.ViewModels.TextPages
{
    public class TextPageViewModel : BaseViewModel<TextPageModel>
    {
        private readonly TextPageModel _currentPage;

        public TextPageViewModel(TextPageModel currentPage) : base(currentPage)
        {
            _currentPage = currentPage;
        }

        public bool HideSearch { get; set; }

        //Common

        public string PageHeading { get { return _currentPage.Content.GetPropertyValue<string>("pageHeading") == null ? _currentPage.Content.GetPropertyValue<string>("pageName") : _currentPage.Content.GetPropertyValue<string>("pageHeading"); } }

        //TextPage

        public string PageContent { get { return _currentPage.Content.GetPropertyValue<string>("pageContent"); } }

        //TextPageWithBannerCTA & TwoColumnArticlePageWithBanner & GlassesBrandCategory
        public ArticlePageMainBannerViewModel PageMainBanner { get { return new ArticlePageMainBannerViewModel(_currentPage.Content.GetPropertyValue<IContent>("pageMainBanner")); } }
    
        //TextPageWithBannerCTA
        public IEnumerable<ContentBlockViewModel> MainContent
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("mainContent");

                var results = new List<ContentBlockViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new ContentBlockViewModel(content));
                    }
                }
                return results;

            }
        }


        public PageCtaButtonViewModel PageCta { get { return new PageCtaButtonViewModel(_currentPage.Content.GetPropertyValue<IContent>("pageCTA")); } }

        public IEnumerable<ContentBlockViewModel> ContentBlockList
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("contentBlockList");

                var results = new List<ContentBlockViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new ContentBlockViewModel(content));
                    }
                }
                return results;
            }
        }

        public IContent ProductPromotionImage { get { return _currentPage.Content.GetPropertyValue<IContent>("productPromotionImage"); } }

        public string ProductPromotionAltText { get { return _currentPage.Content.GetPropertyValue<string>("productPromotionAltText"); } }

        //TwoColumnArticlePageWithBanner
        public IEnumerable<ArticleContentBlockViewModel> ContentBlocks
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("contentBlocks");

                var results = new List<ArticleContentBlockViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new ArticleContentBlockViewModel(content));
                    }
                }
                return results;
            }
        }

        //GlassesBrandCategory
        public IEnumerable<ArticleContentBlockViewModel> BrandBlocks
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("brandBlocks");

                var results = new List<ArticleContentBlockViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new ArticleContentBlockViewModel(content));
                    }
                }
                return results;
            }
        }

        //GlassesBrandCategory
        public IEnumerable<BrandBlockViewModel> BrandsList
        {
            get
            {
                var publishedContent = _currentPage.Content.GetPropertyValue<IEnumerable<IContent>>("brandsList");

                var results = new List<BrandBlockViewModel>();
                if (publishedContent != null)
                {
                    foreach (var content in publishedContent)
                    {
                        results.Add(new BrandBlockViewModel(content));
                    }
                }
                return results;
            }
        }
    }
}