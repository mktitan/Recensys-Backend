using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewIT_Backend.Models
{
    public class FieldDataModel
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Data { get; set; }
    }
}