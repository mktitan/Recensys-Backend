namespace RecensysBLL.Models
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