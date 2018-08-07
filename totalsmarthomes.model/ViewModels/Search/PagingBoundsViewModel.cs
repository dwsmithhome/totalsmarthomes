﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace totalsmarthomes.Models.ViewModels.Search
{
    public class PagingBoundsViewModel
    {
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public bool ShowFirstButton { get; set; }
        public bool ShowLastButton { get; set; }

        public PagingBoundsViewModel(int startPage, int endPage, bool showFirstButton, bool showLastButton)
        {
            StartPage = startPage;
            EndPage = endPage;
            ShowFirstButton = showFirstButton;
            ShowLastButton = showLastButton;
        }
    }
}