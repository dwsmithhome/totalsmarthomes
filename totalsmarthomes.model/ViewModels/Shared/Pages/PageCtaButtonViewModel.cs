﻿using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.ViewModels.Shared.Pages
{
    public class PageCtaButtonViewModel
    {
        private readonly IContent _content;

        public PageCtaButtonViewModel(IContent content)
        {
            _content = content;
        }

        public string ButtonCaption { get { return _content.GetPropertyValue<string>("buttonCaption"); } }

        public string PageLink { get { return _content.GetPropertyValue<string>("pageLink"); } }
    }
}