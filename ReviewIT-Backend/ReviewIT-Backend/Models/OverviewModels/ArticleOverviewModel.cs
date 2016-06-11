using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace ReviewIT_Backend.Models.OverviewModels
{
    public class ArticleOverviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        
    }
}