using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewIT_Backend.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Metadata { get; set; }
    }
}