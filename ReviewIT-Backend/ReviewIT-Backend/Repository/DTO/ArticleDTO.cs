using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewIT_Backend.Repository.DTO
{
    public class ArticleDTO
    {
        public int A_Id { get; set; }
        public int S_Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}