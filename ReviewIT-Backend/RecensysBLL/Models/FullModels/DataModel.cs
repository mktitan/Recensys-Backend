namespace RecensysBLL.Models.FullModels
{
    public enum DataType
    {
        Visible, Text, Bool, Radio, Checkbox, Resource
    }
    public class DataModel
    {
        public int Id { get; set; }
        public DataType DataType { get; set; }
        public int ArticleId { get; set; }
        public string Data { get; set; }
    }
}