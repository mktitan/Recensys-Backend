using System.Collections.Generic;

namespace RecensysBLL.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public Dictionary<FieldModel, List<FieldDataModel>> Fields { get; set; }
        
    }
}