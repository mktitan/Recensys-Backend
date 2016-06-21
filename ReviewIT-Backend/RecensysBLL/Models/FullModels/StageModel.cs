using System.Collections.Generic;

namespace RecensysBLL.Models.FullModels
{
    public class StageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}