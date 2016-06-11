using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<UserDTO> GetAll();

        void Create(UserDTO user);

        UserDTO Read(int id);

        void Update(UserDTO user);

        void Delete(int id);
        
    }
}