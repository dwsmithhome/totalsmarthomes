﻿using System.Collections.Generic;
using totalsmarthomes.Models.Interfaces;

namespace totalsmarthomes.Models.Search
{
    public class SearchResultsModel
    {
        public string SearchTerm { get; set; }
        public string Culture { get; set; }
        public List<IContent> Results { get; set; }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public int ResultTotal { get; set; }
        public PagingBoundsModel PagingBounds { get; set; }
        public string SiteURL { get; internal set; }
    }
}