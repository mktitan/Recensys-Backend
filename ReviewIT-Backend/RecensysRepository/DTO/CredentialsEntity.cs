namespace RecensysRepository.DTO
{
    public class CredentialsEntity
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Password_Salt { get; set; }
    }
}