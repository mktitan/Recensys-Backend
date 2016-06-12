using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface ICredentialsRepository : IDisposable
    {
        IEnumerable<CredentialsDTO> GetAll();

        void Create(CredentialsDTO item);

        CredentialsDTO Read(int id);

        void Update(CredentialsDTO item);

        void Delete(int id);
    }
}
