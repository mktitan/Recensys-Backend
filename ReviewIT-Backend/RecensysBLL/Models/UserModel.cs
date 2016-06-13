using Microsoft.Build.Framework;

namespace RecensysBLL.Models
{
    public class UserModel
    {
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Metadata { get; set; }
    }
}