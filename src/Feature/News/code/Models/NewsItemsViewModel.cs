﻿using System.Collections.Generic;

namespace Sitecore.HabitatHome.Feature.News.Models
{
    public class NewsItemsViewModel
    {
        public List<News> NewsItems { get; set; }

        public int NumberOfSearchResults { get; set; }

        public int NumberOfPages { get; set; }
    }
}