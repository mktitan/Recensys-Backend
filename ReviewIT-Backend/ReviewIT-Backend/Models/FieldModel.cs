using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewIT_Backend.Models
{

    public enum FieldType
    {
        Text, Bool, Radio, Checkbox, 
    }

    public class FieldModel
    {
        public int Id { get; set; }
        public FieldType FieldType { get; set; }
    }
}