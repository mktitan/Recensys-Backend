using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace ReviewIT_Backend.Models
{

    public enum StageRole
    {
        Reviewer, Validator
    }

    public class StageModel
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public List<TaskModel> Tasks { get; set; }
        
        
    }
}