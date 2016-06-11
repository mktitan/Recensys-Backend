using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewIT_Backend.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public Dictionary<FieldModel, List<FieldDataModel>> Fields { get; set; }
        
    }
}