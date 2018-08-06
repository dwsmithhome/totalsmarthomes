﻿using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.HomePage
{
    public class SecondaryBannerViewModel
    {
        private readonly IContent _content;

        private readonly int captionLengthLimitForLgAndMd = 90;
        private readonly int captionLengthLimitForSm = 45;
        private readonly int captionSubstringLimit = 5;

        public SecondaryBannerViewModel(IContent content)
        {
            _content = content;
        }

        public string BannerCaption { get { return _content.GetPropertyValue<string>("bannerCaption"); } }

        public bool TextToLeft { get { return _content.GetPropertyValue<bool>("textToLeft"); } }

        public IContent BannerBackgroundImage { get { return _content.GetPropertyValue<IContent>("bannerBackgroundImage"); } }

        public string CaptionTextLgAndMd
        {
            get
            {
                var caption = _content.GetPropertyValue<string>("captionText");
                return caption.Length > captionLengthLimitForLgAndMd ? caption.Substring(0, captionLengthLimitForLgAndMd - captionSubstringLimit) + " ..." : caption;
            }
        }

        public string CaptionTextSm
        {
            get
            {
                var caption = _content.GetPropertyValue<string>("captionText");
                return caption.Length > captionLengthLimitForSm ? caption.Substring(0, captionLengthLimitForSm - captionSubstringLimit) + " ..." : caption;
            }
        }

        public string CtaButtonText { get { return _content.GetPropertyValue<string>("ctaButtonText"); } }

        public string CtaButtonImage { get { return _content.GetPropertyValue<string>("ctaButtonImage"); } }

        public string CtaPageLink { get { return _content.GetPropertyValue<string>("ctaPageLink"); } }

        public string BannerAltText { get { return _content.GetPropertyValue<string>("bannerAltText"); } }
    }
}