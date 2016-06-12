using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
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