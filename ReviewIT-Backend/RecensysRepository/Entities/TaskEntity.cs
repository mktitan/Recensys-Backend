namespace RecensysRepository.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public int Study_Id { get; set; }
        public int User_Id { get; set; }
        public int TaskType_Id { get; set; }
    }
}