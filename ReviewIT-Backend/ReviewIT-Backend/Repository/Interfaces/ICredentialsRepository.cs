using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository.Interfaces
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
