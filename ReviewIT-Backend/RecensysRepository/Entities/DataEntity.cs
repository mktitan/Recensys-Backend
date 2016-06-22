namespace RecensysRepository.Entities
{
    public class DataEntity
    {
        public int Id { get; set; }
        public int Field_Id { get; set; }
        public int Task_Id { get; set; }
        public int Article_Id { get; set; }
        public string Data { get; set; }
        public int DataType_Id { get; set; }
    }
}